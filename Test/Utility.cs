using System;
using System.Text;
using System.Collections.Generic;
using Domain;
namespace Test
{
    class Utility
    {
        public static Colaborator CreateColaborator(string name, string surname, string mail, string password, DateTime birthday)
        {
            Colaborator colaborator = new Colaborator();
            colaborator.name = name;
            colaborator.surname = surname;
            colaborator.mail = mail;
            colaborator.password = password;
            colaborator.birthday = birthday;
            return colaborator;
        }
    }
}