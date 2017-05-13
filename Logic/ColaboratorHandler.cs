﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class ColaboratorHandler
    {
        public ColaboratorPersistenceProvider colaboratorFunctions { get; set; }

        public void AddColaborator(Colaborator colaborator)
        {
            ValidateColaborator(colaborator);
            colaboratorFunctions.AddColaborator(colaborator);
        }

        public User GetUserFromColecction(string mailOfColaborator)
        {
            Utility.Utilites.ValidateMail(mailOfColaborator);
            return colaboratorFunctions.GetUserFromColecction(mailOfColaborator);
        }

        private void ValidateColaborator(Colaborator colaborator)
        {
            Utility.Utilites.ValidateNameOrSurname(colaborator.name);
            Utility.Utilites.ValidateNameOrSurname(colaborator.surname);
            Utility.Utilites.ValidatePassword(colaborator.password);
            Utility.Utilites.ValidateMail(colaborator.mail);
            Utility.Utilites.ValidateBirthDate(colaborator.birthday);
        }
        public void ModifyPassword(string mailOfColaborator, string newPassword)
        {
            Utility.Utilites.ValidatePassword(newPassword);

            colaboratorFunctions.ModifyPassword(mailOfColaborator, newPassword);
        }
        public void LogIn(string email, string password)
        {   
            User colaborator = GetUserFromColecction(email);
            if (AreNotEqual(colaborator.password,password))
            {
                throw new UserException();
            }
        }
        private bool AreNotEqual(string element1, string element2)
        {
            if (element1.Equals(element2))
            {
                return false;
            }
            return true;
        }
    }
}
