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
        bool ExistsAdministrator(Administrator administrator);
        void DeleteAdministrator(Administrator administrator);
        bool IsEmptyAdministratorCollection();
    }
}
