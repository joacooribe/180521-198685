using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using System.Data.Entity;

namespace Persistence
{
    public class TeamPersistenceHandler : ITeamPersistance
    {
        public Repository SystemCollection;
        private IBlackboardPersistance BlackboardFunctions;

        public TeamPersistenceHandler()
        {
            SystemCollection = Repository.GetInstance;
            BlackboardFunctions = new BlackboardPersistenceHandler();
        }

        public void AddTeam(Team team)
        {
            using (ContextDB context = new ContextDB())
            {
                team.creator = (Administrator)context.Users.Find(team.creator.OIDUser);
                List<User> newUsers = new List<User>();
                for (int i = 0; i < team.usersInTeam.Count; i++)
                {
                    var user = team.usersInTeam.ToList()[i];
                    if (!user.mail.Equals(team.creator.mail))
                    {
                        newUsers.Add(context.Users.Find(user.OIDUser));
                    }
                    else
                    {
                        newUsers.Add(team.creator);
                    }
                }
                team.usersInTeam = newUsers;
                context.Teams.Add(team);
                context.SaveChanges();
            }
        }

        public bool ExistsTeam(Team team)
        {
            bool exist = true;
            using (ContextDB context = new ContextDB())
            {
                team = context.Teams
                                .Where(t => t.name == team.name)
                                .FirstOrDefault();
            }
            if (TeamNotDefined(team))
            {
                exist = false;
            }
            return exist;
        }

        public Team GetTeam(string nameOfTeam)
        {
            Team team = new Team();
            using (ContextDB context = new ContextDB())
            {
                context.Configuration.ProxyCreationEnabled = false;
                team = context.Teams
                                .Where(t => t.name == nameOfTeam)
                                .Include(t => t.usersInTeam)
                                .FirstOrDefault();
            }
            if (TeamNotDefined(team))
            {
                throw new TeamException(ExceptionMessage.teamNotExists);
            }
            return team;
        }

        public bool TeamNotDefined(Team team)
        {
            return team == null;
        }

        public void DeleteTeam(Team team)
        {
            using (ContextDB context = new ContextDB())
            {
                var query = context.Teams.Find(team.OIDTeam);
                context.Teams.Remove(query);
                context.SaveChanges();
            }
        }

        private void DeleteBlackboardsOfTeam(Team team)
        {
            BlackboardFunctions.DeleteBlackboardsOfTeam(team);
        }

        public void ModifyTeamDescription(string nameOfTeam, string newDescription)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Teams
                         .Where(t => t.name == nameOfTeam)
                         .FirstOrDefault()
                         .description = newDescription;
                context.SaveChanges();
            }
        }

        public void ModifyTeamMaxUsers(string nameOfTeam, int newMaxUsers)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Teams
                         .Where(t => t.name == nameOfTeam)
                         .FirstOrDefault().maxUsers = newMaxUsers;
                context.SaveChanges();
            }
        }

        public List<User> GetUsersFromTeam(Team team)
        {
            using (ContextDB context = new ContextDB())
            {
                List<User> query = context.Teams.Where(t => t.name == team.name)
                                         .Include(t => t.usersInTeam)
                                         .FirstOrDefault()
                                         .usersInTeam.ToList();
                return query;
            }
        }

        public void RemoveUser(Team team, User user)
        {
            Team teamDataBase = new Team();
            using (ContextDB context = new ContextDB())
            {
                context.Configuration.ProxyCreationEnabled = false;
                teamDataBase = context.Teams.Find(team.OIDTeam);
                List<User> users = context.Teams
                            .Where(t => t.name == teamDataBase.name)
                            .Include(t => t.usersInTeam)
                            .FirstOrDefault()
                            .usersInTeam.ToList();
                users.Remove(user);
                context.Teams
                            .Where(t => t.name == teamDataBase.name)
                            .Include(t => t.usersInTeam)
                            .FirstOrDefault()
                            .usersInTeam = users;
                context.SaveChanges();
            }
            if (teamDataBase.usersInTeam.Count == 0)
            {
                DeleteTeam(team);
            }
        }
        public void ModifyTeamUsers(Team team, ICollection<User> users)
        {
            using (ContextDB context = new ContextDB())
            {
                List<User> newUsersInTeam = new List<User>();
                var teamToModify = context.Teams.Find(team.OIDTeam);
                foreach (User user in users)
                {
                    var userToAdd = context.Users.Find(user.OIDUser);
                    newUsersInTeam.Add(userToAdd);
                }
                context.Teams
                            .Where(t => t.name == team.name)
                            .Include(t => t.usersInTeam)
                            .FirstOrDefault()
                            .usersInTeam = newUsersInTeam;
                context.SaveChanges();
            }
        }

        public List<Team> LoadTeams()
        {
            List<Team> allTeams = new List<Team>();
            using (ContextDB context = new ContextDB())
            {
                allTeams = context.Teams.ToList();
            }
            return allTeams;
        }
    }
}
