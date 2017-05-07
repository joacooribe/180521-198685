using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class ColaboratorPersistenceHandler : ColaboratorPersistenceProvider
    {
        public SystemList SystemList;

        public ColaboratorPersistenceHandler(SystemList systemList)
        {
            SystemList = systemList;
        }

        public void AddColaborator(Colaborator colaborator)
        {
            SystemList.ColaboratorList.Add(colaborator);
        }
       
    }
}
