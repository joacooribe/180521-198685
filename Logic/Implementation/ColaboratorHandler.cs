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
        private IColaboratorPersistance ColaboratorFunctions { get; set; }
        private IUserPersistance UserFunctions { get; set; }

        public ColaboratorHandler()
        {
            ColaboratorFunctions = new ColaboratorPersistenceHandler();
            UserFunctions = new UserPersistanceHandler();
        }

        public void AddColaborator(Colaborator colaborator)
        {
            ValidateColaborator(colaborator);
            if (UserFunctions.ExistsUser(colaborator))
            {
                throw new UserException(ExceptionMessage.userAlreadyExist);
            }
            ColaboratorFunctions.AddColaborator(colaborator);
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
