using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
namespace Logic
{
    public class TeamHandler
    {
        public TeamPersistenceProvider teamFunctions { get; set; }

        public void AddTeam(Team team)
        {
            ValidateTeam(team);
            teamFunctions.AddTeam(team);
        }

        private void ValidateTeam(Team team)
        {
            ValidateNameOfTeam(team.name);
            ValidateDescriptionOfTeam(team.description);
            ValidateEmptyTeam(team.usersInTeam);
            ValidateMaxUsers(team.maxUsers);
            ValidateAmountOnListNotOverMax(team.usersInTeam, team.maxUsers);
            ValidateCreationDate(team.creationDate);

        }
        private static void ValidateNameOfTeam(string name)
        {

            if (ValidateNullOrEmpty(name))
            {
                throw new TeamException();
            }
        }
        private static bool ValidateNullOrEmpty(string element)
        {
            return string.IsNullOrEmpty(element);
        }


        private static void ValidateDescriptionOfTeam(string description)
        {

            if (ValidateNullOrEmpty(description) || ValidateCorrectLenghtDescription(description.Length))
            {
                throw new TeamException();
            }
        }

        private static bool ValidateCorrectLenghtDescription(int element)
        {
            return element > 50;
        }

        private static void ValidateEmptyTeam(List<User> users)
        {

            if (ValidateNumberIsZero(users.Count))
            {
                throw new TeamException();
            }
        }
        private static bool ValidateNumberIsZero(int element)
        {
            return element == 0;
        }

        private static void ValidateMaxUsers(int max)
        {

            if (ValidateNumberIsZero(max))
            {
                throw new TeamException();
            }
        }

        private static void ValidateAmountOnListNotOverMax(List<User> users, int max)
        {

            if (ValidateMoreUsersThanMaximum(users,max))
            {
                throw new TeamException();
            }
        }
        private static bool ValidateMoreUsersThanMaximum(List<User> users, int max)
        {
            return users.Count > max;
        }
        private static void ValidateCreationDate(DateTime date)
        {
            if (ValidateIsNotFutureDate(date))
            {
                throw new TeamException();
            }
        }
        private static bool ValidateIsNotFutureDate(DateTime date)
        {
            return date > DateTime.Now;
        }
        public Team GetTeamFromCollection(string nameOfTeam)
        {
            return teamFunctions.GetTeamFromCollection(nameOfTeam);
        }
        public void ModifyMaxUsers(string nameOfTeam, int newMax)
        {
            Team teamToModify = GetTeamFromCollection(nameOfTeam);
            if (ValidateNewMaxUsers(teamToModify,newMax))
            {
                throw new TeamException();
            }
            teamFunctions.ModifyMaxUsers(teamToModify, newMax);
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
        public void ModifyDescription(string nameOfTeam, string newDescription)
        {
            Team teamToModify = GetTeamFromCollection(nameOfTeam);
            if (ValidateNullOrEmpty(newDescription) || ValidateCorrectLenghtDescription(newDescription.Length))
            {
                throw new TeamException();
            }
            teamFunctions.ModifyDescription(teamToModify, newDescription);
        }
            
    }
}
