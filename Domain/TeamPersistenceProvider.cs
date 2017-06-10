using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface TeamPersistenceProvider
    {
        void AddTeam(Team team);
        Team GetTeamFromCollection(string nameOfTeam);
        void ModifyMaxUsers(string nameOfTeam, int newMax);
        void ModifyDescription(string nameOfTeam, string newDescription);
    }
}
