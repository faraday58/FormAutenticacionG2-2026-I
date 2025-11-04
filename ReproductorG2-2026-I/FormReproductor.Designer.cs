namespace ReproductorG2_2026_I
{
    partial class FormReproductor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstbPlayList = new ListBox();
            ptbAlbum = new PictureBox();
            label1 = new Label();
            txtbTitle = new TextBox();
            label2 = new Label();
            txtbAlbum = new TextBox();
            label3 = new Label();
            txtbArtist = new TextBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            listaDeReproducciónToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ptbAlbum).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstbPlayList
            // 
            lstbPlayList.FormattingEnabled = true;
            lstbPlayList.Location = new Point(63, 110);
            lstbPlayList.Name = "lstbPlayList";
            lstbPlayList.Size = new Size(291, 529);
            lstbPlayList.TabIndex = 0;
            lstbPlayList.SelectedIndexChanged += lstbPlayList_SelectedIndexChanged;
            // 
            // ptbAlbum
            // 
            ptbAlbum.Image = Properties.Resources.takeonme;
            ptbAlbum.Location = new Point(1046, 121);
            ptbAlbum.Name = "ptbAlbum";
            ptbAlbum.Size = new Size(344, 377);
            ptbAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAlbum.TabIndex = 1;
            ptbAlbum.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 207);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 2;
            label1.Text = "Título";
            // 
            // txtbTitle
            // 
            txtbTitle.Location = new Point(552, 201);
            txtbTitle.Name = "txtbTitle";
            txtbTitle.ReadOnly = true;
            txtbTitle.Size = new Size(341, 31);
            txtbTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 277);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Álbum";
            // 
            // txtbAlbum
            // 
            txtbAlbum.Location = new Point(552, 271);
            txtbAlbum.Name = "txtbAlbum";
            txtbAlbum.ReadOnly = true;
            txtbAlbum.Size = new Size(341, 31);
            txtbAlbum.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 353);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "Artista";
            // 
            // txtbArtist
            // 
            txtbArtist.Location = new Point(552, 347);
            txtbArtist.Name = "txtbArtist";
            txtbArtist.ReadOnly = true;
            txtbArtist.Size = new Size(341, 31);
            txtbArtist.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, listaDeReproducciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1568, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // listaDeReproducciónToolStripMenuItem
            // 
            listaDeReproducciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            listaDeReproducciónToolStripMenuItem.Name = "listaDeReproducciónToolStripMenuItem";
            listaDeReproducciónToolStripMenuItem.Size = new Size(202, 29);
            listaDeReproducciónToolStripMenuItem.Text = "Lista de Reproducción";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(178, 34);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // FormReproductor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1568, 774);
            Controls.Add(txtbArtist);
            Controls.Add(label3);
            Controls.Add(txtbAlbum);
            Controls.Add(label2);
            Controls.Add(txtbTitle);
            Controls.Add(label1);
            Controls.Add(ptbAlbum);
            Controls.Add(lstbPlayList);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormReproductor";
            Text = "Reproductor";
            Load += FormReproductor_Load;
            ((System.ComponentModel.ISupportInitialize)ptbAlbum).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbPlayList;
        private PictureBox ptbAlbum;
        private Label label1;
        private TextBox txtbTitle;
        private Label label2;
        private TextBox txtbAlbum;
        private Label label3;
        private TextBox txtbArtist;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem listaDeReproducciónToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
    }
}
