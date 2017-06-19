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
    public class AdministratorPersistenceHandler : IAdministratorPersistance
    {
        private Repository systemCollection;

        public AdministratorPersistenceHandler()
        {
            systemCollection = Repository.GetInstance;
        }

        public void AddAdministrator(Administrator administrator)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Administrators.Add(administrator);
                context.SaveChanges();
            }
        }

        public Administrator GetAdministrator(string mailOfAdministrator)
        {
            Administrator administrator = new Administrator();
            using (ContextDB context = new ContextDB())
            {
                administrator = context.Administrators
                                                .Where(a => a.mail == mailOfAdministrator)
                                                .Include(a => a.teams)
                                                .FirstOrDefault();
                //var admin = ObjectContext.GetObjectType(administrator.GetType());
            }
            if (AdministratorNotDefined(administrator))
            {
                throw new UserException(ExceptionMessage.userNotExist);
            }
            return administrator;
        }


        public bool AdministratorNotDefined(User admin)
        {
            return admin == null;
        }
        
        public bool ExistsAdministrator(User administrator)
        {
            bool exists = true;
            using (ContextDB context = new ContextDB())
            {
                administrator = context.Users
                                                .Where(a => a.mail == administrator.mail)
                                                .FirstOrDefault();
            }
            if (AdministratorNotDefined(administrator))
            {
                exists = false;
            }
            return exists;
        }

        public void DeleteAdministrator(string mailOfAdministrator)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Administrators
                                .Where(a => a.mail == mailOfAdministrator)
                                .FirstOrDefault()
                                .active=false;
                context.SaveChanges();
            }
               
        }

        public bool IsEmptyAdministratorCollection()
        {
            return systemCollection.administratorCollection.Count == 0;
        }

        public void EmptyAdministrators()
        {
            using (ContextDB context = new ContextDB())
            {
                context.SaveChanges();
                foreach (Administrator admin in context.Administrators)
                {
                    context.Administrators.Attach(admin);
                    context.Entry(admin).State = EntityState.Deleted;
                    context.SaveChanges();
                }
               
            }
        }

        public List<Team> GetTeams(User administrator)
        {
            using (ContextDB context = new ContextDB())
            {
                var query = context.Users.Find(administrator.OIDUser);
                List<Team> teams = new List<Team>();
                teams = query.teams.ToList();
                return teams;
            }
        }
    }
}
