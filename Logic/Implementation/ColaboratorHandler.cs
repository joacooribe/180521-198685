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
        public IColaboratorPersistance colaboratorFunctions { get; set; }

        public List<Team> GetTeams(User colaborator)
        {
            return colaboratorFunctions.GetTeams(colaborator);
        }

        public ColaboratorHandler()
        {
            colaboratorFunctions = new ColaboratorPersistenceHandler();
        }

        public void AddColaborator(Colaborator colaborator)
        {
            ValidateColaborator(colaborator);
            if (ExistsColaborator(colaborator))
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

        public User GetUserFromColecction(string mailOfColaborator)
        {
            Utility.Utilites.ValidateMail(mailOfColaborator);
            return colaboratorFunctions.GetColaborator(mailOfColaborator);
        }

        public void ModifyPassword(string mailOfColaborator, string newPassword)
        {
            Utility.Utilites.ValidatePassword(newPassword);
            Colaborator colaboratorToChangePassword = colaboratorFunctions.GetColaborator(mailOfColaborator);
            colaboratorToChangePassword.password = newPassword;
        }

        public bool ExistsColaborator(Colaborator colaborator)
        {
            return colaboratorFunctions.ExistsColaborator(colaborator);
        }

        public void DeleteUser(string mailOfColaborator)
        {
            colaboratorFunctions.DeleteColaborator(mailOfColaborator);
        }
    }
}
