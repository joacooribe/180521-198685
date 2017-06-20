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
        private IUserPersistance userFunctions { get; set; }

        public AdministratorHandler()
        {
            administratorFunctions = new AdministratorPersistenceHandler();
            userFunctions = new UserPersistanceHandler();
        }

        public void AddAdministrator(Administrator administrator)
        {
            ValidateAdministrator(administrator);
            if (userFunctions.ExistsUser(administrator))
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
    }
}
