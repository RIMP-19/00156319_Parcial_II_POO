using Parcial_II.Controlador;

namespace Parcial_II.Modelo
{
    public static class UserDAO
    {
        public static User CheckLogIn(string username, string password){
            var testUser = new User();
            var query = 
                $"SELECT username, password, \"userType\", fullname FROM \"APPUSER\" WHERE username ='{username}'";
            var dt = DBConnection.ExecuteQuery(query);
                        

            if (dt.Rows[0][0].ToString().Equals("") || 
                !PasswordHashing.CheckPassword(password, dt.Rows[0][1].ToString()))
                throw new InvalidCredentialsException("Usuario o contraseña inválidos.");

            testUser.Username = username;
            testUser.UserType = dt.Rows[0][2].ToString();
            testUser.FullName = dt.Rows[0][3].ToString();

            return testUser;
        }
    }
}