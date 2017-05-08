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
            bool invalidName = false;
            Regex regularExpresion = new Regex(validCharsName);
            if (element == null || !(regularExpresion.IsMatch(element)) || element == "")
            {
                invalidName = true;
            }
            return invalidName;
        }
        public static void ValidatePassword(string password)
        {
            if (ValidationOfPassword(password))
            {
                throw new ColaboratorException();
            }
        }
        
        private static bool ValidationOfPassword(string element)
        {
            bool invalidPassword=false;

            Regex regularExpresionNumbers = new Regex(validCharsPassword);

            if (element == null || !(regularExpresionNumbers.IsMatch(element)) || element.Length < 6 || element == "")
            {
                invalidPassword = true;
            }
            return invalidPassword;
        }

    }
}