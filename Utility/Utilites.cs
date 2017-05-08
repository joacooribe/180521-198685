using System;
using System.Text;
using System.Collections.Generic;
using Exceptions;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utility
{
    public class Utilites
    {
        private static readonly string validCharsName = "^[a-zA-Z]*$";
        private static readonly string validCharsPassword = "^(?=.*[a-zA-Z])(?=.*[0-9])";


        public static void ValidateNameOrSurname(string name)
        {
            
            if (ValidationOfStrings(name))
            {
                throw new ColaboratorException();
            }
        }
        public static void ValidateAdministrator(String name)
        {
            if (string.IsNullOrEmpty(name))

            {
                throw new AdministratorException();
            }
        }
        private static bool ValidationOfStrings(string element)
        {
            Regex regularExpresion = new Regex(validCharsName);
            if (element == null || !(regularExpresion.IsMatch(element)) || element == "")
            {
                return true;
            }
            return false;
        }
        public static void ValidatePassword(string password)
        {
            Regex regularExpresionNumbers = new Regex(validCharsPassword);
            if (password == null || !(regularExpresionNumbers.IsMatch(password)) || password.Length < 6 || password == "")
            {
                throw new ColaboratorException();
            }
        }

    }
}