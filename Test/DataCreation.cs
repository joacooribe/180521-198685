using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Test
{
    class DataCreation
    {
        public static Administrator CreateAdministrator(string name, string surname, string mail, string password, DateTime birthday)
        {
            Administrator administrator = new Administrator();
            administrator.name = name;
            administrator.surname = surname;
            administrator.mail = mail;
            administrator.password = password;
            administrator.birthday = birthday;
            return administrator;
        }

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
