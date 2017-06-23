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
        IUserHandler UserHandler { get; set; }

        public SessionHandler()
        {
            UserHandler = new UserHandler();
        }

        public Session LogInAdministrator(string mail, string password)
        {
            Utility.Utilites.ValidateMail(mail);
            Utility.Utilites.ValidatePassword(password);
            User administratorLogIn = UserHandler.GetUserFromColecction(mail);
            Utility.Utilites.ValidateActive(administratorLogIn.active);
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
            Utility.Utilites.ValidateMail(mail);
            Utility.Utilites.ValidatePassword(password);
            User colaboratorLogIn = UserHandler.GetUserFromColecction(mail);
            Utility.Utilites.ValidateActive(colaboratorLogIn.active);
            ValidateDifferentPassword(colaboratorLogIn.password, password);
            Session session = new Session
            {
                user = colaboratorLogIn,
            };
            return session;
        }
    }
}
