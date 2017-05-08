using System;
using System.Text;
using System.Collections.Generic;
using Exceptions;

namespace Utility
{
    public class Utilites
    {
        public static void ValidateName(String name)
        {
            if (name == "")
            {
                throw new ColaboratorException();
            }
        }
        public static void ValidateAdministrator(String name)
        {
            if (name == "")
            {
                throw new AdministratorException();
            }
        }
    }
}