using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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

        public Administrator GetAdministratorFromColecction(Administrator administratorToFind)
        {
            ValidateAdministrator(administratorToFind);
            return administratorFunctions.GetAdministratorFromColecction(administratorToFind);
        }

        public void ValidateAdministrator(Administrator administrator)
        {
            Utility.Utilites.ValidateNameOrSurname(administrator.name);
            Utility.Utilites.ValidateNameOrSurname(administrator.surname);
            Utility.Utilites.ValidatePassword(administrator.password);
            Utility.Utilites.ValidateMail(administrator.mail);
            Utility.Utilites.ValidateBirthDate(administrator.birthday);
        }
    }
}
