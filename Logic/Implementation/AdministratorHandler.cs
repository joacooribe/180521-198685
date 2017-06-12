using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using Persistence;

namespace Logic
{
    public class AdministratorHandler : IAdministratorHandler
    {
        private IAdministratorPersistance administratorFunctions { get; set; }

        public AdministratorHandler()
        {
            administratorFunctions = new AdministratorPersistenceHandler();
        }

        public void AddAdministrator(Administrator administrator)
        {
            ValidateAdministrator(administrator);
            if (ExistsAdministrator(administrator))
            {
                throw new UserException(ExceptionMessage.userAlreadyExist);
            }
            administratorFunctions.AddAdministrator(administrator);
        }

        private void ValidateAdministrator(Administrator administrator)
        {
            Utility.Utilites.ValidateName(administrator.name);
            Utility.Utilites.ValidateSurname(administrator.surname);
            Utility.Utilites.ValidatePassword(administrator.password);
            Utility.Utilites.ValidateMail(administrator.mail);
            Utility.Utilites.ValidateBirthDate(administrator.birthday);
        }

        public User GetUserFromColecction(string mailOfAdministrator)
        {
            Utility.Utilites.ValidateMail(mailOfAdministrator);
            return administratorFunctions.GetAdministrator(mailOfAdministrator);
        }
        
        public void ModifyPassword(string mailOfAdministrator,string newPassword)
        {
            Utility.Utilites.ValidatePassword(newPassword);
            User adminToChangePassword = administratorFunctions.GetAdministrator(mailOfAdministrator);
            adminToChangePassword.password = newPassword;
        }

        public bool ExistsAdministrator(Administrator administrator)
        {
            return administratorFunctions.ExistsAdministrator(administrator);
        }

        //public void LogOut()
        //{
        //    administratorFunctions.LogOut();
        //}
    }
}
