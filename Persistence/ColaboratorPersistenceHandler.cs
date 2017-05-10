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
            systemCollection.colaboratorList.Add(colaborator);
        }

        public Colaborator GetColaboratorFromList(Colaborator colaboratorToFind)
        {

            Colaborator colaborator = new Colaborator();
            foreach (Colaborator colaboratorFromList in systemCollection.colaboratorList)
            {
                if (colaboratorToFind.Equals(colaboratorFromList))
                {
                    colaborator = colaboratorFromList;
                    return colaborator;
                }
            }
            throw new Exception();
        }       
    }
}
