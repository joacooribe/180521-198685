using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
            systemCollection.teamCollection.Add(team);
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
        public void ModifyMaxUsers(Team teamToModify, int newMax)
        {
            teamToModify.maxUsers = newMax;
        }
        public void ModifyDescription(Team teamToModify, string newDescription)
        {
            teamToModify.description = newDescription;
        }
    }
}
