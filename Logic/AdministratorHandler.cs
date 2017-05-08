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
        public AdministratorPersistenceProvider administratorFunctions;

        public void AddAdministrator(Administrator administrator)
        {
            ValidateAdministrator(administrator);
            administratorFunctions.AddAdministrator(administrator);
        }

        public void ValidateAdministrator(Administrator administrator)
        {
            Utility.Utilites.ValidateAdministrator(administrator.name);
        }
    }
}
