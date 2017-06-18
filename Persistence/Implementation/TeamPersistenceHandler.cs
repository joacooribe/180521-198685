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
        public Repository systemCollection;
        private IBlackboardPersistance blackboardFunctions;

        public TeamPersistenceHandler()
        {
            systemCollection = Repository.GetInstance;
            blackboardFunctions = new BlackboardPersistenceHandler();
        }

        public void AddTeam(Team team)
        {
            using (ContextDB context = new ContextDB())
            {
                foreach (User user in team.usersInTeam)
                {
                    context.Users.Attach(user);   
                }
                context.Teams.Add(team);
                context.SaveChanges();
            }

        }

        public bool ExistsTeam(Team team)
        {
            return systemCollection.teamCollection.Contains(team);
        }

        public Team GetTeam(string nameOfTeam)
        {
            Team team = new Team();
            using (ContextDB context = new ContextDB())
            {
                team = context.Teams
                                .Where(t => t.name == nameOfTeam)
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
            DeleteBlackboardsOfTeam(team);
            systemCollection.teamCollection.Remove(team);
        }

        private void DeleteBlackboardsOfTeam(Team team)
        {
            blackboardFunctions.DeleteBlackboardsOfTeam(team);
        }

        public bool IsEmptyTeamCollection()
        {
            return systemCollection.teamCollection.Count == 0;
        }

        public void ModifyTeamDescription(string nameOfTeam, string newDescription)
        {
            using (ContextDB context = new ContextDB())
            {
               context.Teams
                        .Where(t => t.name == nameOfTeam)
                        .FirstOrDefault().description = newDescription;
               context.SaveChanges();
            }
        }

        public void ModifyTeamMaxUsers(string nameOfTeam, int newMaxUsers)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Teams
                         .Where(t => t.name == nameOfTeam)
                         .FirstOrDefault().maxUsers=newMaxUsers;
                context.SaveChanges();
            }
        }

        public void EmptyTeams()
        {
            systemCollection.teamCollection.Clear();
        }

        public List<User> GetUsersFromTeam(Team team)
        {
            using (ContextDB context = new ContextDB())
            {
                var query = context.Teams.Find(team.OIDTeam);
                return query.usersInTeam.ToList();
            }
        }

        public void RemoveUser(Team team,User user)
        {
            using (ContextDB context = new ContextDB())
            {
                var query = context.Teams.Find(team.OIDTeam);
                context.Users.Attach(user);
                query.usersInTeam.Remove(user);
                context.SaveChanges();
            }
        }
        public void AddUser(Team team, User user)
        {

        }
    }
}
