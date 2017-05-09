﻿using System;
using System.Text;
using System.Collections.Generic;
using Exceptions;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utility
{
    public class Utilites
    {
        private static readonly string VALID_CHARS_NAME = "^[a-zA-Z]*$";
        private static readonly string VALID_CHARS_PASSWORD = "^(?=.*[a-zA-Z])(?=.*[0-9])";
        private static readonly string VALID_CHARS_MAIL = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$";

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
            Regex regularExpresion = new Regex(VALID_CHARS_NAME);
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

            Regex regularExpresionNumbers = new Regex(VALID_CHARS_PASSWORD);

            if (element == null || !(regularExpresionNumbers.IsMatch(element)) || element.Length < 6 || element == "")
            {
                invalidPassword = true;
            }
            return invalidPassword;
        }

        public static void ValidateMail(string mail)
        {
            
            if (ValidationOfMail(mail))
            {
                throw new ColaboratorException();
            }
            
        }

        private static bool ValidationOfMail(String element)
        {
            Regex regularExpresionMail = new Regex(VALID_CHARS_MAIL);
            bool invalidMail = false;
            if (element == null || !(regularExpresionMail.IsMatch(element)) || element == "")
            {
                invalidMail = true;
            }
            return invalidMail;
        }

    }
}