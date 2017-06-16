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
                                                .FirstOrDefault();
            }
            if (AdministratorNotDefined(administrator))
            {
                throw new UserException(ExceptionMessage.userNotExist);
            }
            return administrator;
        }


        public bool AdministratorNotDefined(Administrator admin)
        {
            return admin == null;
        }
        
        public bool ExistsAdministrator(Administrator administrator)
        {
            bool exists = true;
            using (ContextDB context = new ContextDB())
            {
                administrator = context.Administrators
                                                .Where(a => a.mail == administrator.mail)
                                                .FirstOrDefault(); ;
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
            systemCollection.administratorCollection.Clear();
        }

    }
}
