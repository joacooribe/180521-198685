using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class SessionHandler : ISessionHandler
    {
        IUserHandler userHandler { get; set; }

        public SessionHandler()
        {
            userHandler = new UserHandler();
        }

        public Session LogInAdministrator(string mail, string password)
        {
            User administratorLogIn = userHandler.GetUserFromColecction(mail);
            ValidateDifferentPassword(administratorLogIn.password, password);
            Session session = new Session
            {
                user = administratorLogIn,
            };
            return session;
        }


        private void ValidateDifferentPassword(string userPassword, string passwordRecived)
        {
            if (!userPassword.Equals(passwordRecived))
            {
                throw new UserException(ExceptionMessage.userLogInInvalidPassword);
            }
        }

        public Session LogInColaborator(string mail, string password)
        {
            User colaboratorLogIn = userHandler.GetUserFromColecction(mail);
            ValidateDifferentPassword(colaboratorLogIn.password, password);
            Session session = new Session
            {
                user = colaboratorLogIn,
            };
            return session;
        }
    }
}
