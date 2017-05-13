using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class BlackboardPersistenceHandler : BlackboardPersistenceProvider
    {

        public Repository systemCollection;

        public BlackboardPersistenceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddBlackboard(Blackboard blackboard)
        {
            systemCollection.blackboardColecction.Add(blackboard);
        }
    }
}
