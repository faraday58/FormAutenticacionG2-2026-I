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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReproductor));
            lstbPlayList = new ListBox();
            cMenuStripReproductor = new ContextMenuStrip(components);
            eliminarCanciónToolStripMenuItem = new ToolStripMenuItem();
            ptbAlbum = new PictureBox();
            label1 = new Label();
            txtbTitle = new TextBox();
            label2 = new Label();
            txtbAlbum = new TextBox();
            label3 = new Label();
            txtbArtist = new TextBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarListaDeReproducciónToolStripMenuItem = new ToolStripMenuItem();
            importarToolStripMenuItem = new ToolStripMenuItem();
            listaDeReproducciónToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            reproducirToolStripMenuItem = new ToolStripMenuItem();
            pausarToolStripMenuItem = new ToolStripMenuItem();
            detenerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            siguienteToolStripMenuItem = new ToolStripMenuItem();
            anteriorToolStripMenuItem = new ToolStripMenuItem();
            lbStartTime = new Label();
            lbFinalTime = new Label();
            pgbTime = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            cMenuStripReproductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAlbum).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstbPlayList
            // 
            lstbPlayList.ContextMenuStrip = cMenuStripReproductor;
            lstbPlayList.FormattingEnabled = true;
            lstbPlayList.Location = new Point(63, 110);
            lstbPlayList.Name = "lstbPlayList";
            lstbPlayList.Size = new Size(291, 529);
            lstbPlayList.TabIndex = 0;
            lstbPlayList.SelectedIndexChanged += lstbPlayList_SelectedIndexChanged;
            // 
            // cMenuStripReproductor
            // 
            cMenuStripReproductor.ImageScalingSize = new Size(24, 24);
            cMenuStripReproductor.Items.AddRange(new ToolStripItem[] { eliminarCanciónToolStripMenuItem });
            cMenuStripReproductor.Name = "cMenuStripReproductor";
            cMenuStripReproductor.Size = new Size(212, 36);
            // 
            // eliminarCanciónToolStripMenuItem
            // 
            eliminarCanciónToolStripMenuItem.Name = "eliminarCanciónToolStripMenuItem";
            eliminarCanciónToolStripMenuItem.Size = new Size(211, 32);
            eliminarCanciónToolStripMenuItem.Text = "Eliminar canción";
            // 
            // ptbAlbum
            // 
            ptbAlbum.Image = Properties.Resources._default;
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
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarListaDeReproducciónToolStripMenuItem, importarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarListaDeReproducciónToolStripMenuItem
            // 
            guardarListaDeReproducciónToolStripMenuItem.Name = "guardarListaDeReproducciónToolStripMenuItem";
            guardarListaDeReproducciónToolStripMenuItem.Size = new Size(356, 34);
            guardarListaDeReproducciónToolStripMenuItem.Text = "Guardar Lista de Reproducción";
            guardarListaDeReproducciónToolStripMenuItem.Click += guardarListaDeReproducciónToolStripMenuItem_Click;
            // 
            // importarToolStripMenuItem
            // 
            importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            importarToolStripMenuItem.Size = new Size(356, 34);
            importarToolStripMenuItem.Text = "Importar";
            importarToolStripMenuItem.Click += importarToolStripMenuItem_Click;
            // 
            // listaDeReproducciónToolStripMenuItem
            // 
            listaDeReproducciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, toolStripMenuItem1, reproducirToolStripMenuItem, pausarToolStripMenuItem, detenerToolStripMenuItem, toolStripMenuItem2, siguienteToolStripMenuItem, anteriorToolStripMenuItem });
            listaDeReproducciónToolStripMenuItem.Name = "listaDeReproducciónToolStripMenuItem";
            listaDeReproducciónToolStripMenuItem.Size = new Size(202, 29);
            listaDeReproducciónToolStripMenuItem.Text = "Lista de Reproducción";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(200, 34);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(197, 6);
            // 
            // reproducirToolStripMenuItem
            // 
            reproducirToolStripMenuItem.Image = (Image)resources.GetObject("reproducirToolStripMenuItem.Image");
            reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            reproducirToolStripMenuItem.Size = new Size(200, 34);
            reproducirToolStripMenuItem.Text = "Reproducir";
            reproducirToolStripMenuItem.Click += reproducirToolStripMenuItem_Click;
            // 
            // pausarToolStripMenuItem
            // 
            pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            pausarToolStripMenuItem.Size = new Size(200, 34);
            pausarToolStripMenuItem.Text = "Pausar";
            // 
            // detenerToolStripMenuItem
            // 
            detenerToolStripMenuItem.Image = (Image)resources.GetObject("detenerToolStripMenuItem.Image");
            detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            detenerToolStripMenuItem.Size = new Size(200, 34);
            detenerToolStripMenuItem.Text = "Detener";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(197, 6);
            // 
            // siguienteToolStripMenuItem
            // 
            siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            siguienteToolStripMenuItem.Size = new Size(200, 34);
            siguienteToolStripMenuItem.Text = "Siguiente";
            // 
            // anteriorToolStripMenuItem
            // 
            anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            anteriorToolStripMenuItem.Size = new Size(200, 34);
            anteriorToolStripMenuItem.Text = "Anterior";
            // 
            // lbStartTime
            // 
            lbStartTime.AutoSize = true;
            lbStartTime.Location = new Point(475, 459);
            lbStartTime.Name = "lbStartTime";
            lbStartTime.Size = new Size(27, 25);
            lbStartTime.TabIndex = 2;
            lbStartTime.Text = "0 ";
            // 
            // lbFinalTime
            // 
            lbFinalTime.AutoSize = true;
            lbFinalTime.Location = new Point(916, 463);
            lbFinalTime.Name = "lbFinalTime";
            lbFinalTime.Size = new Size(51, 25);
            lbFinalTime.TabIndex = 2;
            lbFinalTime.Text = "2:50 ";
            // 
            // pgbTime
            // 
            pgbTime.Location = new Point(513, 473);
            pgbTime.Name = "pgbTime";
            pgbTime.Size = new Size(391, 11);
            pgbTime.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormReproductor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 215, 96);
            ClientSize = new Size(1568, 774);
            Controls.Add(pgbTime);
            Controls.Add(txtbArtist);
            Controls.Add(lbFinalTime);
            Controls.Add(lbStartTime);
            Controls.Add(label3);
            Controls.Add(txtbAlbum);
            Controls.Add(label2);
            Controls.Add(txtbTitle);
            Controls.Add(label1);
            Controls.Add(ptbAlbum);
            Controls.Add(lstbPlayList);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormReproductor";
            Text = "Reproductor";
            Load += FormReproductor_Load;
            cMenuStripReproductor.ResumeLayout(false);
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
        private Label lbStartTime;
        private Label lbFinalTime;
        private ProgressBar pgbTime;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem reproducirToolStripMenuItem;
        private ToolStripMenuItem pausarToolStripMenuItem;
        private ToolStripMenuItem detenerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem siguienteToolStripMenuItem;
        private ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarCanciónToolStripMenuItem;
        private ContextMenuStrip cMenuStripReproductor;
        private ToolStripMenuItem guardarListaDeReproducciónToolStripMenuItem;
        private ToolStripMenuItem importarToolStripMenuItem;
    }
}
