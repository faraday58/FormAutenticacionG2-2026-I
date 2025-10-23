namespace WinFormSigIn
{
    partial class FormSignIn
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
            label1 = new Label();
            txtbName = new TextBox();
            label2 = new Label();
            txtbPassword = new TextBox();
            label3 = new Label();
            txtbRepassword = new TextBox();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 148);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtbName
            // 
            txtbName.Location = new Point(332, 148);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(301, 31);
            txtbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 213);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 0;
            label2.Text = "Contraseña";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(332, 213);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.PasswordChar = '*';
            txtbPassword.Size = new Size(301, 31);
            txtbPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 294);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 0;
            label3.Text = "Reingresa Contraseña";
            // 
            // txtbRepassword
            // 
            txtbRepassword.Location = new Point(332, 294);
            txtbRepassword.Name = "txtbRepassword";
            txtbRepassword.Size = new Size(301, 31);
            txtbRepassword.TabIndex = 1;
            txtbRepassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(362, 380);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(189, 84);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Registrar";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // FormSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 585);
            Controls.Add(btnSignIn);
            Controls.Add(txtbRepassword);
            Controls.Add(label3);
            Controls.Add(txtbPassword);
            Controls.Add(label2);
            Controls.Add(txtbName);
            Controls.Add(label1);
            Name = "FormSignIn";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbName;
        private Label label2;
        private TextBox txtbPassword;
        private Label label3;
        private TextBox txtbRepassword;
        private Button btnSignIn;
    }
}
