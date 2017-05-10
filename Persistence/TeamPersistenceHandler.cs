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
        public SystemList SystemList;

        public TeamPersistenceHandler(SystemList systemList)
        {
            SystemList = systemList;
        }
        public void AddTeam(Team team)
        {
            SystemList.teamList.Add(team);
        }
    }
}
