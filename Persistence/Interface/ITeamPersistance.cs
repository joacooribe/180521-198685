using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface ITeamPersistance
    {
        void AddTeam(Team team);
        Team GetTeam(string name);
        bool ExistsTeam(Team team);
        void DeleteTeam(Team team);
        void ModifyTeamDescription(string NameOfTeam, string description);
        void ModifyTeamMaxUsers(string NameOfTeam, int maxUsers);
        List<User> GetUsersFromTeam(Team team);
        void RemoveUser(Team team,User user);
        void ModifyTeamUsers(Team team, ICollection<User> users);
        List<Team> LoadTeams();
    }
}
