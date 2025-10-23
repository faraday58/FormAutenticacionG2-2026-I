namespace ReproductorG2_2026_I
{
    partial class FormAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtbTitle = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            txtbArtist = new TextBox();
            label3 = new Label();
            txtbAlbum = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtbTitle
            // 
            txtbTitle.Location = new Point(284, 104);
            txtbTitle.Name = "txtbTitle";
            txtbTitle.Size = new Size(337, 31);
            txtbTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 104);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 1;
            label1.Text = "Título";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 31);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 168);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label1";
            // 
            // txtbArtist
            // 
            txtbArtist.Location = new Point(284, 168);
            txtbArtist.Name = "txtbArtist";
            txtbArtist.Size = new Size(337, 31);
            txtbArtist.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 168);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 1;
            label3.Text = "Artista";
            // 
            // txtbAlbum
            // 
            txtbAlbum.Location = new Point(284, 249);
            txtbAlbum.Name = "txtbAlbum";
            txtbAlbum.Size = new Size(337, 31);
            txtbAlbum.TabIndex = 0;
            txtbAlbum.KeyPress += txtbAlbum_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 249);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 1;
            label4.Text = "Álbum";
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 406);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbAlbum);
            Controls.Add(txtbArtist);
            Controls.Add(textBox2);
            Controls.Add(txtbTitle);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbTitle;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtbArtist;
        private Label label3;
        private TextBox txtbAlbum;
        private Label label4;
    }
}