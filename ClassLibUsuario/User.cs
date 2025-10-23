namespace ClassLibUsuario
{
    public class User
    {

        private string name;
        private string password;
     

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }


        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

    }
}
