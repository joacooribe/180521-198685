using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Persistence
{
    public class BlackboardPersistenceHandler : IBlackboardPersistance
    {
        private Repository systemCollection;
        private IElementPersistance elementFunctions;

        public BlackboardPersistenceHandler()
        {
            systemCollection = Repository.GetInstance;
        }

        public void AddBlackboard(Blackboard blackboard)
        {
            systemCollection.blackboardCollection.Add(blackboard);
        }

        public bool ExistsBlackboard(Blackboard blackboard)
        {
            return systemCollection.blackboardCollection.Contains(blackboard);
        }

        public Blackboard GetBlackboard(string name, Team team)
        {
            Blackboard blackboard = new Blackboard();
            foreach (Blackboard blackboardFromColecction in systemCollection.blackboardCollection)
            {
                if (name.Equals(blackboardFromColecction.name) && team.Equals(blackboardFromColecction.teamOwner))
                {
                    blackboard = blackboardFromColecction;
                    return blackboard;
                }
            }
            throw new BlackboardException(ExceptionMessage.blackboardNotExist);
        }

        public void DeleteBlackboard(Blackboard blackboard)
        {
            DeleteElementOfBlackboard(blackboard);
            systemCollection.blackboardCollection.Remove(blackboard);
        }

        private void DeleteElementOfBlackboard(Blackboard blackboard)
        {
            foreach(Element elementOfBlackboard in blackboard.elementsInBlackboard)
            {
                elementFunctions.DeleteElement(elementOfBlackboard);
            }
        }

        public void DeleteBlackboardsOfTeam(Team team)
        {
            foreach (Blackboard blackboardOfTeam in systemCollection.blackboardCollection)
            {
                if (blackboardOfTeam.teamOwner.Equals(team))
                {
                    DeleteBlackboard(blackboardOfTeam);
                }
            }
        }

        public bool IsEmptyBlackboardCollection()
        {
            return systemCollection.blackboardCollection.Count == 0;
        }
    }
}
