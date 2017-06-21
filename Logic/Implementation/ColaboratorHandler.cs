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
    public class ColaboratorHandler : IColaboratorHandler
    {
        private IColaboratorPersistance colaboratorFunctions { get; set; }
        private IUserPersistance userFunctions { get; set; }

        public ColaboratorHandler()
        {
            colaboratorFunctions = new ColaboratorPersistenceHandler();
            userFunctions = new UserPersistanceHandler();
        }

        public void AddColaborator(Colaborator colaborator)
        {
            ValidateColaborator(colaborator);
            if (userFunctions.ExistsUser(colaborator))
            {
                throw new UserException(ExceptionMessage.userAlreadyExist);
            }
            colaboratorFunctions.AddColaborator(colaborator);
        }
        private void ValidateColaborator(Colaborator colaborator)
        {
            Utility.Utilites.ValidateName(colaborator.name);
            Utility.Utilites.ValidateSurname(colaborator.surname);
            Utility.Utilites.ValidatePassword(colaborator.password);
            Utility.Utilites.ValidateMail(colaborator.mail);
            Utility.Utilites.ValidateBirthDate(colaborator.birthday);
        }
    }
}
