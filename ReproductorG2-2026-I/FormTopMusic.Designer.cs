namespace ReproductorG2_2026_I
{
    partial class FormTopMusic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartMusic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            exportarImagenToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)chartMusic).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chartMusic
            // 
            chartArea1.AxisX.Title = "Canciones";
            chartArea1.AxisY.Title = "Top";
            chartArea1.Name = "ChartArea1";
            chartMusic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartMusic.Legends.Add(legend1);
            chartMusic.Location = new Point(135, 86);
            chartMusic.Name = "chartMusic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Top Music";
            series1.Name = "Series1";
            chartMusic.Series.Add(series1);
            chartMusic.Size = new Size(581, 516);
            chartMusic.TabIndex = 0;
            chartMusic.Text = "chart1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(851, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportarImagenToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarImagenToolStripMenuItem
            // 
            exportarImagenToolStripMenuItem.Name = "exportarImagenToolStripMenuItem";
            exportarImagenToolStripMenuItem.Size = new Size(245, 34);
            exportarImagenToolStripMenuItem.Text = "Exportar Imagen";
            exportarImagenToolStripMenuItem.Click += exportarImagenToolStripMenuItem_Click;
            // 
            // FormTopMusic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 743);
            Controls.Add(chartMusic);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTopMusic";
            Text = "FormTopMusic";
            ((System.ComponentModel.ISupportInitialize)chartMusic).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMusic;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem exportarImagenToolStripMenuItem;
    }
}