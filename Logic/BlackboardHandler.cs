using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class BlackboardHandler
    {
        public BlackboardPersistenceProvider blackboardFunctions { get; set; }

        public void AddBlackboard(Blackboard blackboard)
        {
            ValidateBlackboard(blackboard);
            blackboardFunctions.AddBlackboard(blackboard);
        }

        private void ValidateBlackboard(Blackboard blackboard)
        {
            ValidateName(blackboard.name);
            ValidateDescription(blackboard.description);
            ValidateUser(blackboard.userCreator);
            ValidateHigh(blackboard.high);
            ValidateWidth(blackboard.width);
            ValidateTeam(blackboard.teamOwner);
        }

        private void ValidateTeam(Team teamOwner)
        {
            if(teamOwner == null)
            {
                throw new BlackboardException();
            }
        }

        private void ValidateWidth(int width)
        {
            ValidateCero(width);
            ValidateNegativeNumber(width);
        }

        private void ValidateHigh(int high)
        {
            ValidateCero(high);
            ValidateNegativeNumber(high);
        }

        private void ValidateNegativeNumber(int high)
        {
            if(high < 0)
            {
                throw new BlackboardException();
            }
        }

        private void ValidateCero(int high)
        {
            if(high == 0)
            {
                throw new BlackboardException();
            }
        }

        private void ValidateUser(User userOwner)
        {
            if(userOwner == null)
            {
                throw new BlackboardException();
            }
        }

        private void ValidateDescription(string description)
        {
            ValidateNullOrEmpty(description);
            ValidateDescriptionToLong(description);
        }

        private void ValidateDescriptionToLong(string description)
        {
            if(description.Length > 50)
            {
                throw new BlackboardException();
            }
        }

        private void ValidateName(string name)
        {
            ValidateNullOrEmpty(name);
            ValidateNameToLong(name);
        }

        private void ValidateNullOrEmpty(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new BlackboardException();
            }
        }

        private void ValidateNameToLong(string name)
        {
            if(name.Length > 20)
            {
                throw new BlackboardException();
            }
        }
    }
}
