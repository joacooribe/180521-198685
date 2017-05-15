using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class ColaboratorHandler
    {
        public ColaboratorPersistenceProvider colaboratorFunctions { get; set; }

        public void AddColaborator(Colaborator colaborator)
        {
            ValidateColaborator(colaborator);
            colaboratorFunctions.AddColaborator(colaborator);
        }

        public User GetUserFromColecction(string mailOfColaborator)
        {
            Utility.Utilites.ValidateMail(mailOfColaborator);
            return colaboratorFunctions.GetUserFromColecction(mailOfColaborator);
        }

        private void ValidateColaborator(Colaborator colaborator)
        {
            Utility.Utilites.ValidateName(colaborator.name);
            Utility.Utilites.ValidateSurname(colaborator.surname);
            Utility.Utilites.ValidatePassword(colaborator.password);
            Utility.Utilites.ValidateMail(colaborator.mail);
            Utility.Utilites.ValidateBirthDate(colaborator.birthday);
        }
        public void ModifyPassword(string mailOfColaborator, string newPassword)
        {
            Utility.Utilites.ValidatePassword(newPassword);

            colaboratorFunctions.ModifyPassword(mailOfColaborator, newPassword);
        }
        public void LoginColaborator(string mail, string password)
        {
            User colaboratorLogIn = GetUserFromColecction(mail);
            ValidateDifferentPassword(colaboratorLogIn.password, password);
            colaboratorFunctions.LoginColaborator(mail, password);
        }

        private void ValidateDifferentPassword(string userPassword, string passwordRecived)
        {
            if (!userPassword.Equals(passwordRecived))
            {
                throw new UserException(ExceptionMessage.userLogInInvalidPassword);
            }

        }

    }
}
