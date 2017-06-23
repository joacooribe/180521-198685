using System.Collections.Generic;
using Domain;

namespace Logic
{
   public interface IUserHandler
    {
        User GetUserFromColecction(string mailOfUser);
        void ModifyPassword(string mailOfUser, string newPassword);
        void DeleteUser(string mailOfUser);
        List<Team> GetTeams(User user);
        List<User> LoadUsers();
    }
}
