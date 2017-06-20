﻿using System;
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
                context.Users.Attach(team.creator);
                if (team.usersInTeam.Contains(team.creator))
                {
                    team.creator.teams.Add(team);
                }
                context.Entry(team.creator).State = EntityState.Modified;
                context.SaveChanges();

                foreach (User user in team.usersInTeam)
                {
                    if (!team.creator.Equals(user))
                    {
                        context.Users.Attach(user);
                        user.teams.Add(team);
                        context.Entry(user).State = EntityState.Modified;
                    }
                }
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
                context.Configuration.ProxyCreationEnabled = false;
                List<User> users = context.Teams
                            .Where(t => t.name == team.name)
                            .Include(t => t.usersInTeam)
                            .FirstOrDefault()
                            .usersInTeam.ToList();
                users.Remove(user);
                context.Teams
                            .Where(t => t.name == team.name)
                            .Include(t => t.usersInTeam)
                            .FirstOrDefault()
                            .usersInTeam = users;
                context.SaveChanges();
            }
        }
        public void ModifyTeamUsers(Team team,ICollection<User> users)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Teams.Attach(team);
                foreach (User user in users)
                {
                    if (!user.teams.Contains(team))
                    {
                        context.Users.Attach(user);
                        user.teams.Add(team);
                        context.Entry(user).State = EntityState.Modified;
                    }
                }
                context.Teams
                            .Where(t => t.name == team.name)
                            .Include(t => t.usersInTeam)
                            .FirstOrDefault()
                            .usersInTeam = users;
                context.SaveChanges();
            }
        }
    }
}
