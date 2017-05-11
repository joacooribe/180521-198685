using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
        public static void ValidateNameOfTeam(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new TeamException();
            }
        }

        public static void ValidateDescriptionOfTeam(string description)
        {

            if (string.IsNullOrEmpty(description) || description.Length > 50)
            {
                throw new TeamException();
            }
        }

        public static void ValidateEmptyTeam(List<User> users)
        {

            if (users.Count==0)
            {
                throw new TeamException();
            }
        }

        public static void ValidateMaxUsers(int max)
        {

            if (max == 0)
            {
                throw new TeamException();
            }
        }

        public static void ValidateAmountOnListNotOverMax(List<User> users, int max)
        {

            if (users.Count > max )
            {
                throw new TeamException();
            }
        }
    }
}
