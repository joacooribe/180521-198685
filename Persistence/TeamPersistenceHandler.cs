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
            systemCollection.teamList.Add(team);
        }
    }
}
