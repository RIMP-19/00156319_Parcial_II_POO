namespace Parcial_II.Modelo
{
    public class User
    {
        public string Username { get; set; }        
        public string FullName { get; set; }
        public string UserType { get; set; }

        public User()
        {
            Username = "";
            FullName = "";
            UserType = "";
        }
    }
}