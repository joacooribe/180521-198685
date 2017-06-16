using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logic
{
   public interface IUserHandler
    {
        User GetUserFromColecction(string mailOfUser);
        void ModifyPassword(string mailOfUser, string newPassword);
        void DeleteUser(string mailOfUser);
    }
}
