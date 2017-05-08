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
        private static readonly string validChars = "^[a-zA-Z]*$";


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
            Regex regularExpresion = new Regex(validChars);
            if (element == null || !(regularExpresion.IsMatch(element)) || element == "")
            {
                return true;
            }
            return false;
        }
    }
}