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
            systemCollection.administratorCollection.Add(administrator);
        }

        public Administrator GetAdministrator(string mailOfAdministrator)
        {
            Administrator administrator = new Administrator();
            foreach (Administrator administratorFromColecction in systemCollection.administratorCollection)
            {
                if (mailOfAdministrator.Equals(administratorFromColecction.mail))
                {
                    administrator = administratorFromColecction;
                    return administrator;
                }
            }
            throw new UserException(ExceptionMessage.userNotExist);
        }

        //public void ModifyPassword(string mailOfAdministrator,string newPassword)
        //{
        //    User adminToChangePassword = GetAdministrator(mailOfAdministrator);
        //    adminToChangePassword.password = newPassword;
        //}
        
        public bool ExistsAdministrator(Administrator administrator)
        {
            bool existsAdministrator = false;
            foreach (Administrator administratorFromColecction in systemCollection.administratorCollection)
            {
                if (administrator.Equals(administratorFromColecction))
                {
                    existsAdministrator = true;
                }
            }
            return existsAdministrator;
        }

        public void DeleteAdministrator(string mailOfAdministrator)
        {
            Administrator adminToChange = GetAdministrator(mailOfAdministrator);
            adminToChange.active = false;
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
