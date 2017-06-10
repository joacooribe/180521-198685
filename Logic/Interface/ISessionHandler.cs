using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logic
{
    public interface ISessionHandler
    {
        Session LogInAdministrator(string mail, string password);
        Session LogInColaborator(string mail, string password);
    }
}
