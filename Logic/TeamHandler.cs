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
            
            teamFunctions.AddTeam(team);
        }
    }
}
