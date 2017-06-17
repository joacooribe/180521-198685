using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IAdministratorPersistance
    {
        void AddAdministrator(Administrator administrator);
        Administrator GetAdministrator(string mail);
        bool ExistsAdministrator(User administrator);
        void DeleteAdministrator(string mail);
        bool IsEmptyAdministratorCollection();
        void EmptyAdministrators();
        List<Team> GetTeams(User administrator);
    }
}
