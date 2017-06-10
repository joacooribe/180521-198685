﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

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

        public void DeleteAdministrator(Administrator administrator)
        {
            //Falta ver como eliminarlos
        }

        public bool IsEmptyAdministratorCollection()
        {
            return systemCollection.administratorCollection.Count == 0;
        }

    }
}
