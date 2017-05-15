using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Persistence
{
    public class ColaboratorPersistenceHandler : ColaboratorPersistenceProvider
    {
        public Repository systemCollection;

        public ColaboratorPersistenceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddColaborator(Colaborator colaborator)
        {
            if (ExistsUser(colaborator.mail))
            {
                throw new UserException(ExceptionMessage.userAlreadyExist);
            }
            systemCollection.colaboratorCollection.Add(colaborator);
        }

        public User GetUserFromColecction(string mailOfColaborator)
        {

            User colaborator = new Colaborator();
            foreach (Colaborator colaboratorFromColecction in systemCollection.colaboratorCollection)
            {
                if (mailOfColaborator.Equals(colaboratorFromColecction.mail))
                {
                    colaborator = colaboratorFromColecction;
                    return colaborator;
                }
            }
            throw new UserException(ExceptionMessage.userNotExist);
        }
        public void LoginColaborator(string mail,string password)
        {
            User colaboratorLogIn = GetUserFromColecction(mail);
            systemCollection.session.user = colaboratorLogIn;
        }

        public void ModifyPassword(string mailOfColaborator, string newPassword)
        {
            User colaboratorToChangePassword = GetUserFromColecction(mailOfColaborator);
            colaboratorToChangePassword.password = newPassword;
        }
        public bool ExistsUser(string mailOfUser)
        {
            foreach (Colaborator colaboratorFromColecction in systemCollection.colaboratorCollection)
            {
                if (mailOfUser.Equals(colaboratorFromColecction.mail))
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
