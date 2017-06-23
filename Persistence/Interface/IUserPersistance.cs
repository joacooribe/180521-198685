using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IUserPersistance
    {
        User GetUser(string mail);
        bool ExistsUser(User user);
        void DeleteUser(string mail);
        void ModifyUserPassword(string mail, string newPassword);
        List<Team> GetTeams(User user);
        List<User> LoadUsers();
    }
}
