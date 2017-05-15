using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

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
            if (ExistBlackboard(blackboard))
            {
                throw new BlackboardException(ExceptionMessage.blackboardAlreadyExist);
            }
            systemCollection.blackboardCollection.Add(blackboard);
        }

        private bool ExistBlackboard(Blackboard blackboard)
        {
            return systemCollection.blackboardCollection.Contains(blackboard);
        }
    }
}
