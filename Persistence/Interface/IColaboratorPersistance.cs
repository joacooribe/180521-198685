using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface IColaboratorPersistance
    {
        void AddColaborator(Colaborator colaborator);
        Colaborator GetColaborator(string mail);
        bool ExistsColaborator(Colaborator colaborator);
        void DeleteColaborator(Colaborator colaborator);
        bool IsEmptyColaboratorCollection();
    }
}
