using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class AdministratorHandler
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
        public void LogIn(string mail,string password)
        {
            administratorFunctions.LoginAdministrator(mail,password);

        }
        public void ModifyPassword(string mailOfAdministrator,string newPassword)
        {
            Utility.Utilites.ValidatePassword(newPassword);
            
            administratorFunctions.ModifyPassword(mailOfAdministrator, newPassword);
        }
      
    }
}
