﻿using System;
using System.Text;
using System.Collections.Generic;
using Domain;
using Exceptions;

namespace Test
{
    class Utility
    {
        public static void ValidateColaborator(Colaborator colaborator)
        {
            if(colaborator.name == "")
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