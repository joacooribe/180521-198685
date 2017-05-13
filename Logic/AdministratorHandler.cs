using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
   public  class AdministratorHandler
    {
        public AdministratorPersistenceProvider administratorFunctions { get; set; }

        public void AddAdministrator(Administrator administrator)
        {
            ValidateAdministrator(administrator);
            administratorFunctions.AddAdministrator(administrator);
        }

        public User GetUserFromColecction(string mailOfAdministrator)
        {
            Utility.Utilites.ValidateMail(mailOfAdministrator);
            return administratorFunctions.GetUserFromColecction(mailOfAdministrator);
        }

        private void ValidateAdministrator(Administrator administrator)
        {
            Utility.Utilites.ValidateNameOrSurname(administrator.name);
            Utility.Utilites.ValidateNameOrSurname(administrator.surname);
            Utility.Utilites.ValidatePassword(administrator.password);
            Utility.Utilites.ValidateMail(administrator.mail);
            Utility.Utilites.ValidateBirthDate(administrator.birthday);
        }
        public void ModifyPassword(string mailOfAdministrator,string newPassword)
        {
            Utility.Utilites.ValidatePassword(newPassword);
            
            administratorFunctions.ModifyPassword(mailOfAdministrator, newPassword);
        }
        public void LogIn(string email, string password)
        {
            User administrator = GetUserFromColecction(email);
            if (AreNotEqual(administrator.password, password))
            {
                throw new UserException();
            }
        }
        private bool AreNotEqual(string element1, string element2)
        {
            if (element1.Equals(element2))
            {
                return false;
            }
            return true;
        }
    }
}
