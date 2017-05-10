using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class AdministratorPersistenceHandler : AdministratorPersistenceProvider
    {
            public Repository systemCollection;

            public AdministratorPersistenceHandler(Repository collection)
            {
                systemCollection = collection;
            }

            public void AddAdministrator(Administrator administrator)
            {
                systemCollection.administratorList.Add(administrator);
            }

        
    }
}
