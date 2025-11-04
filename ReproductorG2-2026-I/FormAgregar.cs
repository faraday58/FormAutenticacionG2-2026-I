using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorG2_2026_I
{
    public partial class FormAgregar : Form
    {
        public delegate void DeAddSong(Musica music);
        public event DeAddSong AddSong;

        private string path = "";
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void txtbAlbum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Musica musica = new Musica(txtbTitle.Text, txtbArtist.Text, txtbAlbum.Text,path);
                AddSong(musica);
            }


        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;                
            }
        }
    }
}
