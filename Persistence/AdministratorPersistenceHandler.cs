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
            systemCollection.administratorCollection.Add(administrator);
        }

        public Administrator GetAdministratorFromColecction(Administrator administratorToFind)
        {
            Administrator administrator = new Administrator();
            foreach (Administrator administratorFromColecction in systemCollection.administratorCollection)
            {
                if (administratorToFind.Equals(administratorFromColecction))
                {
                    administrator = administratorFromColecction;
                    return administrator;
                }
            }
            throw new Exception();
        }

        public void LoginAdministrator(string email, string password)
        {

        }

    }
}
