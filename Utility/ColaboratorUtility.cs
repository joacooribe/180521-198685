using System;
using System.Text;
using System.Collections.Generic;
using Exceptions;

namespace Utility
{
    public class ColaboratorUtility
    {
        public static void ValidateName(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ColaboratorException();
            }
        }
    }
}