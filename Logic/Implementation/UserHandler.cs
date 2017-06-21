using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using Persistence;

namespace Logic
{
    public class UserHandler : IUserHandler
    {
        private IUserPersistance userFunctions { get; set; }

        public UserHandler()
        {
            userFunctions = new UserPersistanceHandler();
        }

        public User GetUserFromColecction(string mailOfUser)
        {
            Utility.Utilites.ValidateMail(mailOfUser);
            return userFunctions.GetUser(mailOfUser);
        }

        public void ModifyPassword(string mailOfUser, string newPassword)
        {
            Utility.Utilites.ValidateMail(mailOfUser);
            Utility.Utilites.ValidatePassword(newPassword);
            userFunctions.ModifyUserPassword(mailOfUser, newPassword);
        }

        public void DeleteUser(string mailOfUser)
        {
            Utility.Utilites.ValidateMail(mailOfUser);
            userFunctions.DeleteUser(mailOfUser);
        }

        public List<Team> GetTeams(User user)
        {
            ValidateUser(user);
            return userFunctions.GetTeams(user);
        }

        private void ValidateUser(User user)
        {
            Utility.Utilites.ValidateName(user.name);
            Utility.Utilites.ValidateSurname(user.surname);
            Utility.Utilites.ValidatePassword(user.password);
            Utility.Utilites.ValidateMail(user.mail);
            Utility.Utilites.ValidateBirthDate(user.birthday);
        }
    }
}
