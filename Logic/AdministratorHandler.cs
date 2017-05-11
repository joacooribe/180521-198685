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

        public Administrator GetAdministratorFromColecction(string mailOfAdministrator)
        {
            return administratorFunctions.GetAdministratorFromColecction(mailOfAdministrator);
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
