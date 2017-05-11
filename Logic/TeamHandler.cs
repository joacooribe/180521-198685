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
            if (date > DateTime.Now)
            {
                throw new TeamException();
            }
        }
    }
}
