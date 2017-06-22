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
        private ITeamPersistance teamFunctions { get; set; }

        public UserPersistanceHandler()
        {
            teamFunctions = new TeamPersistenceHandler();
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
                teamFunctions.RemoveUser(team, user);
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

        public void EmptyUsers()
        {
            using (ContextDB context = new ContextDB())
            {
                foreach (User user in context.Users)
                {
                    context.Users.Attach(user);
                    context.Entry(user).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        public List<Team> GetTeams(User user)
        {
            using (ContextDB context = new ContextDB())
            {
                var query = context.Users.Find(user.OIDUser);
                List<Team> teams = new List<Team>();
                teams = query.teams.ToList();
                return teams;
            }
        }
    }
}
