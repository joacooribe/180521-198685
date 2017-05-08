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
        
        public static void ValidateName(string name)
        {
            Regex rg = new Regex("^[a-zA-Z]*$");
            if (name == null || name.Any(char.IsDigit) || !(rg.IsMatch(name)) || name == "")
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
    }
}