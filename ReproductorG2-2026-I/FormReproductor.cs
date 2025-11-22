using System.IO;
using System.Web;


namespace ReproductorG2_2026_I
{
    public partial class FormReproductor : Form
    {
        List<Musica> playList;
        private int time;
        public FormReproductor()
        {
            playList = new List<Musica>();
            LoadMusicData();
            InitializeComponent();

        }

        private void LoadMusicData()
        {
            // Aquí puedes cargar los datos de la música en el reproductor
            playList.Add(new Musica("Desvelado", "Boby Pulido", "Desvelado", @"..\..\..\Resources\desvelado.jpeg"));
            playList.Add(new Musica("Viento", "Caifanes", "Caifanes", @"..\..\..\Resources\caifanes.jpeg"));
            playList.Add(new Musica("Take On Me", "A-Ha", "Hunting High and Low", @"..\..\..\Resources\takeonme.jpeg"));
        }

        private void AddMusicToPlaylist(Musica musica)
        {
            playList.Add(musica);
            lstbPlayList.Items.Add(musica.Title);
        }
        private void FormReproductor_Load(object sender, EventArgs e)
        {
            foreach (var musica in playList)
            {
                lstbPlayList.Items.Add(musica.Title);
            }

        }

        private void lstbPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbTitle.Text = playList[lstbPlayList.SelectedIndex].Title;
            txtbArtist.Text = playList[lstbPlayList.SelectedIndex].Artist;
            txtbAlbum.Text = playList[lstbPlayList.SelectedIndex].Album;
            ptbAlbum.Image = Image.FromFile(playList[lstbPlayList.SelectedIndex].FilePath);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.AddSong += AddMusicToPlaylist;
            formAgregar.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbStartTime.Text = time.ToString();
            pgbTime.Value = time;


            if (time == 100)
            {
                timer1.Stop();
            }
            time++;

        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guardarListaDeReproducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de texto|*.txt|Archivos separados por ','| .csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;
                try
                {
                    writer = new StreamWriter(sfd.FileName);
                    writer.WriteLine("Title,Artist,Album ");

                    foreach (var musica in playList)
                    {
                        writer.WriteLine($"{musica.Title},{musica.Artist},{musica.Album}");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);

                }
                finally
                {
                    // Cerrar el escritor si es necesario
                    writer?.Close();
                }
            }

        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto|*.txt|Archivos separados por ','| .csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(ofd.FileName);

                    string headerLine = reader.ReadLine(); // Leer la línea de encabezado

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] columns = line.Split(',');

                        if (columns.Length >= 3)
                        {
                            string title = columns[0];
                            string artist = columns[1];
                            string album = columns[2];
                            Musica musica = new Musica(title, artist, album, @"..\..\..\Resources\default.jpeg");
                            AddMusicToPlaylist(musica);
                        }

                    }

                    lstbPlayList.Refresh();

                    foreach (var musica in playList)
                    {
                        lstbPlayList.Items.Add(musica.Title);

                    }
                }
                catch (Exception IO)
                {
                    MessageBox.Show("Error al leer el archivo: " + IO.Message);
                }
                finally
                {
                    reader?.Close();
                }


            }



        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTopMusic formTopMusic = new FormTopMusic();
            formTopMusic.ShowDialog();
        }
    }
}
