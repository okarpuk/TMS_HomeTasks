using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_8_Exceptions
{
    public class Parameters
    {
        public static bool NewAutorization(string newLogin, string newPassword, string newConfirm)
        {
            var loginValid = LoginCheck(newLogin);
            var passwordValid = PasswordCheck(newPassword);
            var confirmValid = ConfirmCheck(newConfirm, newPassword);

            return loginValid && passwordValid && confirmValid;
        }

        private static bool LoginCheck(string enteredLogin)
        {
            if (enteredLogin.Length < 20 && !enteredLogin.Contains(' '))
            {
                return true;
            }
            else
            {
                throw new WrongLoginException("Error. Login length is more than 20 characters or login contains space");
            }
        }

        private static bool PasswordCheck(string enteredPassword)
        {
            if (enteredPassword.Length < 20 && !enteredPassword.Contains(' ') && enteredPassword.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                throw new WrongPasswordException("Error. Password length is more than 20 characters or password contains space or password doesn't contain digits");
            }
        }

        private static bool ConfirmCheck(string confirmPassword, string password)
        {
            if (confirmPassword == password)
            {
                return true;
            }
            else
            {
                throw new WrongPasswordException("Error. Entered password and confirmation password doesn't match");
            }
        }
    }
}









}
