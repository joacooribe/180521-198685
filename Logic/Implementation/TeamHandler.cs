using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using Persistence;

namespace Logic
{
    public class TeamHandler : ITeamHandler
    {
        public ITeamPersistance teamFunctions { get; set; }

        public TeamHandler()
        {
            teamFunctions = new TeamPersistenceHandler();
        }

        public void AddTeam(Team team)
        {
            ValidateTeam(team);
            teamFunctions.AddTeam(team);
        }

        private void ValidateTeam(Team team)
        {
            ValidateNameOfTeam(team.name);
            ValidateCreator(team.creator);
            ValidateDescriptionOfTeam(team.description);
            ValidateUsersInTeam(team.usersInTeam);
            ValidateMaxUsers(team.maxUsers);
            ValidateAmountOnCollectionNotOverMax(team.usersInTeam, team.maxUsers);
            ValidateCreationDate(team.creationDate);
        }
        
        private static void ValidateNameOfTeam(string name)
        {
            if (ValidateNullOrEmpty(name))
            {
                throw new TeamException(ExceptionMessage.teamNameNullOrEmpty);
            }
        }

        private static bool ValidateNullOrEmpty(string element)
        {
            return string.IsNullOrEmpty(element);
        }

        private static void ValidateCreator(Administrator adminCreator)
        {
            if (adminCreator==null)
            {
                throw new TeamException(ExceptionMessage.teamOwnerNull);
            }
        }
        private static void ValidateDescriptionOfTeam(string description)
        {

            if (ValidateNullOrEmpty(description) || ValidateCorrectLenghtDescription(description.Length))
            {
                throw new TeamException(ExceptionMessage.teamDescriptionInvalid);
            }
        }

        private static bool ValidateCorrectLenghtDescription(int element)
        {
            return element > 50;
        }

        private static void ValidateUsersInTeam(ICollection<User> users)
        {
            ValiadteNullUserInTeam(users);
            ValidateEmptyTeam(users);
        }

        private static void ValidateEmptyTeam(ICollection<User> users)
        {
            if (ValidateNumberIsZero(users.Count))
            {
                throw new TeamException(ExceptionMessage.teamUserListEmpty);
            }
        }

        private static bool ValidateNumberIsZero(int element)
        {
            return element == 0;
        }

        private static void ValiadteNullUserInTeam(ICollection<User> users)
        {
            if(users == null)
            {
                throw new TeamException(ExceptionMessage.usersInTeamNull);
            }
        }

        private static void ValidateMaxUsers(int max)
        {
            if (ValidateNumberIsZero(max))
            {
                throw new TeamException(ExceptionMessage.teamMaxUsers);
            }
        }

        private static void ValidateAmountOnCollectionNotOverMax(ICollection<User> users, int max)
        {
            if (ValidateMoreUsersThanMaximum(users,max))
            {
                throw new TeamException(ExceptionMessage.teamUsersListFull);
            }
        }

        private static bool ValidateMoreUsersThanMaximum(ICollection<User> users, int max)
        {
            return users.Count > max;
        }

        private static void ValidateCreationDate(DateTime date)
        {
            if (ValidateIsNotFutureDate(date))
            {
                throw new TeamException(ExceptionMessage.teamFutureDate);
            }
        }

        private static bool ValidateIsNotFutureDate(DateTime date)
        {
            return date > DateTime.Now;
        }

        public Team GetTeamFromCollection(string nameOfTeam)
        {
            return teamFunctions.GetTeam(nameOfTeam);
        }

        public void ModifyTeamMaxUsers(string nameOfTeam, int newMax)
        {
            Team teamToModify = GetTeamFromCollection(nameOfTeam);
            if (ValidateNewMaxUsers(teamToModify,newMax))
            {
                throw new TeamException(ExceptionMessage.teamModifyMaxUsers);
            }
<<<<<<< HEAD:Logic/Implementation/TeamHandler.cs
            teamFunctions.ModifyTeamMaxUsers(nameOfTeam, newMax);
=======
            teamFunctions.ModifyMaxUsers(teamToModify.name, newMax);
>>>>>>> ff27d8aa4d7caa3d617437e81f9af0a2ecfc80f9:Logic/TeamHandler.cs
        }

        private bool ValidateNewMaxUsers(Team team, int newMax)
        {
            bool invalidNewMax = false;
            if (team.usersInTeam.Count > newMax || ValidateNumberIsZero(newMax))
            {
                invalidNewMax = true;
            }
            return invalidNewMax;
        }

        public void ModifyTeamDescription(string nameOfTeam, string newDescription)
        {
<<<<<<< HEAD:Logic/Implementation/TeamHandler.cs
=======
           
>>>>>>> ff27d8aa4d7caa3d617437e81f9af0a2ecfc80f9:Logic/TeamHandler.cs
            if (ValidateNullOrEmpty(newDescription) || ValidateCorrectLenghtDescription(newDescription.Length))
            {
                throw new TeamException(ExceptionMessage.teamDescriptionInvalid);
            }
<<<<<<< HEAD:Logic/Implementation/TeamHandler.cs
            teamFunctions.ModifyTeamDescription(nameOfTeam, newDescription);
        }

        public void DeleteTeam(Team team)
        {
            teamFunctions.DeleteTeam(team);
=======
            teamFunctions.ModifyDescription(nameOfTeam, newDescription);
>>>>>>> ff27d8aa4d7caa3d617437e81f9af0a2ecfc80f9:Logic/TeamHandler.cs
        }
            
    }
}
