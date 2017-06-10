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

        public TeamPersistenceHandler()
        {
            systemCollection = Repository.GetInstance;
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

        public void ModifyMaxUsers(Team teamToModify, int newMax)
        {
            teamToModify.maxUsers = newMax;
        }

        public void ModifyDescription(Team teamToModify, string newDescription)
        {
            teamToModify.description = newDescription;
        }

        public void DeleteTeam(Team team)
        {
            //Faltan cosas
            systemCollection.teamCollection.Remove(team);
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
    }
}
