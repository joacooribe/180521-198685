using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Persistence
{
    public class TeamPersistenceHandler : ITeamPersistance
    {
        public Repository systemCollection;
        private IBlackboardPersistance blackboardFunctions;

        public TeamPersistenceHandler()
        {
            systemCollection = Repository.GetInstance;
            blackboardFunctions = new BlackboardPersistenceHandler();
        }

        public void AddTeam(Team team)
        {
            if (ExistsTeam(team))
            {
                throw new TeamException(ExceptionMessage.teamAlreadyExist);
            }
            systemCollection.teamCollection.Add(team);
        }

        public bool ExistsTeam(Team team)
        {
            return systemCollection.teamCollection.Contains(team);
        }

        public Team GetTeam(string nameOfTeam)
        {
            Team team = new Team();
            foreach (Team teamFromColecction in systemCollection.teamCollection)
            {
                if (nameOfTeam.Equals(teamFromColecction.name))
                {
                    team = teamFromColecction;
                    return team;
                }
            }
            throw new Exception();
        }

        public void DeleteTeam(Team team)
        {
            DeleteBlackboardsOfTeam(team);
            systemCollection.teamCollection.Remove(team);
        }

        private void DeleteBlackboardsOfTeam(Team team)
        {
            blackboardFunctions.DeleteBlackboardsOfTeam(team);
        }

        public bool IsEmptyTeamCollection()
        {
            return systemCollection.teamCollection.Count == 0;
        }

        public void ModifyTeamDescription(string nameOfTeam, string newDescription)
        {
            Team team = GetTeam(nameOfTeam);
            team.description = newDescription;
        }

        public void ModifyTeamMaxUsers(string nameOfTeam, int newMaxUsers)
        {
            Team team = GetTeam(nameOfTeam);
            team.maxUsers = newMaxUsers;
        }

        public void EmptyTeams()
        {
            systemCollection.teamCollection.Clear();
        }
    }
}
