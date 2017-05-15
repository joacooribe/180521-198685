using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
                throw new Exception();
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
            throw new Exception();
        }

        public void LoginAdministrator(string mail, string password)
        {
            User administratorLogIn = GetUserFromColecction(mail);
            if (administratorLogIn.password.Equals(password))
            {
                systemCollection.session.user = administratorLogIn;
            }
            else
            {
                throw new Exception();
            }
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
