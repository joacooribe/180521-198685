using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Persistence
{
    public class AdministratorPersistenceHandler : AdministratorPersistenceProvider
    {
        public Repository systemCollection;

        public AdministratorPersistenceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddAdministrator(Administrator administrator)
        {
            if (ExistsUser(administrator.mail))
            {
                throw new UserException(ExceptionMessage.userAlreadyExist);
            }
            systemCollection.administratorCollection.Add(administrator);
        }

        public User GetUserFromColecction(string mailOfAdministrator)
        {
            User administrator = new Administrator();
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

        public void LoginAdministrator(string mail, string password)
        {
            User administratorLogIn = GetUserFromColecction(mail);
            systemCollection.session.user = administratorLogIn;
        }
        public void ModifyPassword(string mailOfAdministrator,string newPassword)
        {
            User adminToChangePassword = GetUserFromColecction(mailOfAdministrator);
            adminToChangePassword.password = newPassword;
        }
        
        public bool ExistsUser(string mailOfUser)
        {
            foreach (Administrator administratorFromColecction in systemCollection.administratorCollection)
            {
                if (mailOfUser.Equals(administratorFromColecction.mail))
                {
                    return true;
                }
            }
            return false;
        }
        public void LogOut()
        {
            systemCollection.session.user = null;
        }
       

    }
}
