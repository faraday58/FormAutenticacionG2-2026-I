using ClassLibUsuario;

namespace WinFormSigIn
{
    public partial class FormSignIn : Form
    {
        User usuario;
        public FormSignIn()
        {
            InitializeComponent();
            usuario = new User("", "");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            usuario.Name = txtbName.Text;
            usuario.Password = txtbPassword.Text;
            if(  txtbRepassword.Text == usuario.Password)
            {
                MessageBox.Show("Usuario creado con éxito");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }


        }
    }
}
