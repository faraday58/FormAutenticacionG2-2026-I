namespace FormAutenticacion_2026_I
{
    partial class FormLogin
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
            label1 = new Label();
            txtbName = new TextBox();
            label2 = new Label();
            txtbPassword = new TextBox();
            btnLogin = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 125);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.MouseHover += label1_MouseHover;
            // 
            // txtbName
            // 
            txtbName.Location = new Point(335, 122);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(280, 31);
            txtbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 233);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 0;
            label2.Text = "Contraseña";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(335, 230);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(280, 31);
            txtbPassword.TabIndex = 1;
            txtbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(378, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(196, 55);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 488);
            Controls.Add(btnLogin);
            Controls.Add(txtbPassword);
            Controls.Add(txtbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbName;
        private Label label2;
        private TextBox txtbPassword;
        private Button btnLogin;
        private ToolTip toolTip1;
    }
}
