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
        private IAdministratorPersistance AdministratorFunctions { get; set; }
        private IUserPersistance UserFunctions { get; set; }

        public AdministratorHandler()
        {
            AdministratorFunctions = new AdministratorPersistenceHandler();
            UserFunctions = new UserPersistanceHandler();
        }

        public void AddAdministrator(Administrator administrator)
        {
            ValidateAdministrator(administrator);
            if (UserFunctions.ExistsUser(administrator))
            {
                throw new UserException(ExceptionMessage.userAlreadyExist);
            }
            AdministratorFunctions.AddAdministrator(administrator);
        }
        private void ValidateAdministrator(Administrator administrator)
        {
            Utility.Utilites.ValidateName(administrator.name);
            Utility.Utilites.ValidateSurname(administrator.surname);
            Utility.Utilites.ValidatePassword(administrator.password);
            Utility.Utilites.ValidateMail(administrator.mail);
            Utility.Utilites.ValidateBirthDate(administrator.birthday);
        }
    }
}
