using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace Persistence
{
    public class AdministratorPersistenceHandler : IAdministratorPersistance
    {
        public AdministratorPersistenceHandler()
        {
        }

        public void AddAdministrator(Administrator administrator)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Administrators.Add(administrator);
                context.SaveChanges();
            }
        }
    }
}
