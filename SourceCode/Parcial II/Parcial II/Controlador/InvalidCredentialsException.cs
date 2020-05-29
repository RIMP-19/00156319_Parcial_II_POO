using System;

namespace Parcial_II.Controlador
{
    public class InvalidCredentialsException:Exception
    {
        public InvalidCredentialsException()
        {
        
        }

        public InvalidCredentialsException(string message) : base(message)
        {
        }
    }
}