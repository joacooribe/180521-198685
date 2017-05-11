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
        private static readonly string VALID_CHARS_NAME = "^[a-zA-Z]*$";
        private static readonly string VALID_CHARS_PASSWORD = "^(?=.*[a-zA-Z])(?=.*[0-9])";
        private static readonly string VALID_CHARS_MAIL = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$";

        public static void ValidateNameOrSurname(string name)
        {
            
            if (ValidationOfStrings(name))
            {
                throw new UserException();
            }
        }
        public static void ValidateAdministrator(string name)
        {
            if (string.IsNullOrEmpty(name))

            {
                throw new UserException();
            }
        }
        private static bool ValidationOfStrings(string element)
        {
            bool invalidName = false;
            Regex regularExpresion = new Regex(VALID_CHARS_NAME);
            if (string.IsNullOrEmpty(element) || !(regularExpresion.IsMatch(element)))
            {
                invalidName = true;
            }
            return invalidName;
        }
        public static void ValidatePassword(string password)
        {
            if (ValidationOfPassword(password))
            {
                throw new UserException();
            }
        }
        
        private static bool ValidationOfPassword(string element)
        {
            bool invalidPassword=false;

            Regex regularExpresionNumbers = new Regex(VALID_CHARS_PASSWORD);

            if (string.IsNullOrEmpty(element) || !(regularExpresionNumbers.IsMatch(element)) || element.Length < 6)
            {
                invalidPassword = true;
            }
            return invalidPassword;
        }

        public static void ValidateMail(string mail)
        {
            
            if (ValidationOfMail(mail))
            {
                throw new UserException();
            }
            
        }

        private static bool ValidationOfMail(string element)
        {
            Regex regularExpresionMail = new Regex(VALID_CHARS_MAIL);
            bool invalidMail = false;
            if (string.IsNullOrEmpty(element) || !(regularExpresionMail.IsMatch(element)))
            {
                invalidMail = true;
            }
            return invalidMail;
        }
        public static void ValidateBirthDate(DateTime date)
        {
            if (ValidateIsNotFutureDate(date))
            {
                throw new UserException();
            }
        }
      private static bool ValidateIsNotFutureDate(DateTime date)
        {
            return date > DateTime.Now;
        }

    }
}