using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Persistence
{
    public class TeamPersistenceHandler : TeamPersistenceProvider
    {
        public Repository systemCollection;

        public TeamPersistenceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddTeam(Team team)
        {
            if (ExistsTeam(team))
            {
                throw new TeamException(ExceptionMessage.teamAlreadyExist);
            }
            systemCollection.teamCollection.Add(team);
        }

        private bool ExistsTeam(Team team)
        {
            return systemCollection.teamCollection.Contains(team);
        }

        public Team GetTeamFromCollection(string nameOfTeam)
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

        public void ModifyMaxUsers(string teamToModifyName, int newMax)
        {
            Team teamToModify = GetTeamFromCollection(teamToModifyName);
            teamToModify.maxUsers = newMax;
        }

        public void ModifyDescription(string teamToModifyName, string newDescription)
        {
            Team teamToModify = GetTeamFromCollection(teamToModifyName);
            teamToModify.description = newDescription;
        }
    }
}
