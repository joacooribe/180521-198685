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
            if (String.IsNullOrEmpty(name))
            {
                throw new ColaboratorException();
            }
        }
        public static void ValidateAdministrator(Administrator administrator)
        {
            if (administrator.name == "")
            {
                throw new AdministratorException();
            }
        }
    }
}