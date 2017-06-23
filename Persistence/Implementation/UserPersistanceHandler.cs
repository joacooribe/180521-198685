using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace Persistence
{
    public class UserPersistanceHandler : IUserPersistance
    {
        private ITeamPersistance TeamFunctions { get; set; }

        public UserPersistanceHandler()
        {
            TeamFunctions = new TeamPersistenceHandler();
        }

        public User GetUser(string mailOfUser)
        {
            User user = null;
            using (ContextDB context = new ContextDB())
            {
                context.Configuration.ProxyCreationEnabled = false;
                user = context.Users
                            .Where(u => u.mail == mailOfUser)
                            .Include(u => u.teams)
                            .FirstOrDefault(); 
            }
            if (UserNotDefined(user))
            {
                throw new UserException(ExceptionMessage.userNotExist);
            }
            return user;
        }

        public bool UserNotDefined(User user)
        {
            return user == null;
        }

        public bool ExistsUser(User user)
        {
            bool exists = true;
            using (ContextDB context = new ContextDB())
            {
                user = context.Users
                                    .Where(a => a.mail == user.mail)
                                    .FirstOrDefault();
            }
            if (UserNotDefined(user))
            {
                exists = false;
            }
            return exists;
        }

        public void DeleteUser(string mailOfUser)
        {
            User user = null;
            using (ContextDB context = new ContextDB())
            {
                context.Configuration.ProxyCreationEnabled = false;
                context.Users.Include(a => a.teams).Load();
                user = context.Users
                                    .Where(a => a.mail == mailOfUser)
                                    .Include(a => a.teams)
                                    .FirstOrDefault();
                context.Users
                                .Where(a => a.mail == mailOfUser)
                                .FirstOrDefault()
                                .active = false;
                context.SaveChanges();
            }
            foreach(Team team in user.teams)
            {
                TeamFunctions.RemoveUser(team, user);
            }
        }

        public void ModifyUserPassword(string mailOfUser, string newPassword)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Users
                                .Where(a => a.mail == mailOfUser)
                                .FirstOrDefault()
                                .password = newPassword;
                context.SaveChanges();
            }
        }

        public List<Team> GetTeams(User user)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Configuration.ProxyCreationEnabled = false;
                var query = context.Users
                                         .Where(u => u.mail == user.mail)
                                         .Include(u => u.teams)
                                         .FirstOrDefault();
                List<Team> teams = new List<Team>();
                teams = query.teams.ToList();
                return teams;
            }
        }

        public List<User> LoadUsers()
        {
            List<User> allUsers = new List<User>();
            using (ContextDB context = new ContextDB())
            {
                context.Configuration.ProxyCreationEnabled = false;
                allUsers = context.Users.ToList();
            }
            return allUsers;
        }
    }
}
