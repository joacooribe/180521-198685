﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using System.Data.Entity;

namespace Persistence
{
    public class BlackboardPersistenceHandler : IBlackboardPersistance
    {
        private Repository SystemCollection;
        private IElementPersistance ElementFunctions;

        public BlackboardPersistenceHandler()
        {
            SystemCollection = Repository.GetInstance;
            ElementFunctions = new ElementPersistenceHandler();
        }

        public void AddBlackboard(Blackboard blackboard)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Blackboards.Add(blackboard);
                context.SaveChanges();
            }
        }

        public bool ExistsBlackboard(Blackboard blackboard)
        {
            bool exists = true;
            using (ContextDB context = new ContextDB())
            {
                blackboard = context.Blackboards
                                                .Where(b => b.name == blackboard.name)
                                                .FirstOrDefault(); ;
            }
            if (BlackboardNotDefined(blackboard))
            {
                exists = false;
            }
            return exists;
        }

        public Blackboard GetBlackboard(string name, Team team)
        {
            Blackboard blackboard = new Blackboard();
            using (ContextDB context = new ContextDB())
            {
                blackboard = context.Blackboards
                                                .Where(b => b.name == name)
                                                .FirstOrDefault();
            }
            if (BlackboardNotDefined(blackboard))
            {
                throw new BlackboardException(ExceptionMessage.blackboardNotExist);
            }
            return blackboard;
        }

        public bool BlackboardNotDefined(Blackboard blackboard)
        {
            return blackboard == null;
        }

        public void DeleteBlackboard(Blackboard blackboard)
        {
            DeleteElementOfBlackboard(blackboard);
            SystemCollection.BlackboardCollection.Remove(blackboard);
        }

        private void DeleteElementOfBlackboard(Blackboard blackboard)
        {
            foreach(Element elementOfBlackboard in blackboard.elementsInBlackboard)
            {
                ElementFunctions.DeleteElement(elementOfBlackboard);
            }
        }

        public void DeleteBlackboardsOfTeam(Team team)
        {
            foreach (Blackboard blackboardOfTeam in SystemCollection.BlackboardCollection)
            {
                if (blackboardOfTeam.teamOwner.Equals(team))
                {
                    DeleteBlackboard(blackboardOfTeam);
                }
            }
        }

        public bool IsEmptyBlackboardCollection()
        {
            return SystemCollection.BlackboardCollection.Count == 0;
        }
    }
}
