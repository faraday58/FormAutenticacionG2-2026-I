using ClassLibUsuario;
using System.Collections;
using ReproductorG2_2026_I;

namespace FormAutenticacion_2026_I
{
    public partial class FormLogin : Form
    {

        ArrayList usuarios;
        // User usuario;

        public FormLogin()
        {
            InitializeComponent();

            //   usuario = new User("admin","1234admn");
            AgregarUsuario();
        }

        private void AgregarUsuario()
        {
            usuarios = new ArrayList();
            //new User corresponde a un objeto anónimo
            usuarios.Add(new User("usuario1", "usuario123"));
            usuarios.Add(new User("usuario2", "usuario456"));
            usuarios.Add(new User("usuario3", "usuario789"));

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (var objeto in usuarios)
            {

                var usuario = (User)objeto;

                if (txtbName.Text == usuario.Name && txtbPassword.Text == usuario.Password)
                {

                    //Instanciar form reproductor
                    FormReproductor formReproductor = new FormReproductor();
                    formReproductor.Show();
                    return;
                }

            }

            MessageBox.Show("Usuario o contraseña incorrecto");


        }

        private void label1_MouseHover(object mensajero, EventArgs evento)
        {
            toolTip1.SetToolTip(label1, "Ingrese su nombre de usuario");


        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnLogin, "Click para iniciar sesión");
        }
    }
}
