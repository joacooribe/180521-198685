using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using System.Data.Entity;

namespace Persistence
{
    public class ColaboratorPersistenceHandler : IColaboratorPersistance
    {
        public ColaboratorPersistenceHandler()
        {
        }

        public void AddColaborator(Colaborator colaborator)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Colaborators.Add(colaborator);
                context.SaveChanges();
            }
        }
    }
}
