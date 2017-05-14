using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public interface UserPersistenceProvider
    {
        User GetUserFromColecction(string mailOfUser);
        void ModifyPassword(string mailOfUser, string newPassword);
        bool ExistsUser(string mailOfUser);
        void LogOut();
    }
}
