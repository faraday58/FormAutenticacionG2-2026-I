using System.Collections.Generic;
namespace ReproductorG2_2026_I
{
    public partial class FormReproductor : Form
    {
        List<Musica> playList;
        public FormReproductor()
        {
            playList = new List<Musica>();
            LoadMusicData();
            InitializeComponent();

        }

        private void LoadMusicData()
        {
            // Aquí puedes cargar los datos de la música en el reproductor
            playList.Add(new Musica("Desvelado", "Boby Pulido", "Desvelado",@"..\..\..\Resources\desvelado.jpeg"));
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
    }
}
