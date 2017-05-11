using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class ColaboratorPersistenceHandler : ColaboratorPersistenceProvider
    {
        public Repository systemCollection;

        public ColaboratorPersistenceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddColaborator(Colaborator colaborator)
        {
            systemCollection.colaboratorCollection.Add(colaborator);
        }

        public Colaborator GetColaboratorFromColecction(Colaborator colaboratorToFind)
        {

            Colaborator colaborator = new Colaborator();
            foreach (Colaborator colaboratorFromColecction in systemCollection.colaboratorCollection)
            {
                if (colaboratorToFind.Equals(colaboratorFromColecction))
                {
                    colaborator = colaboratorFromColecction;
                    return colaborator;
                }
            }
            throw new Exception();
        }

        public void LoginColaborator(string email, string password)
        {
            
        }
    }
}
