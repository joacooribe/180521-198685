using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class AdministratorPersistenceHandler
    {
            public SystemList systemList;

            public AdministratorPersistenceHandler(SystemList sList)
            {
                systemList = sList;
            }

            public void AddAdministrator(Administrator administrator)
            {
                systemList.administratorList.Add(administrator);
            }

        
    }
}
