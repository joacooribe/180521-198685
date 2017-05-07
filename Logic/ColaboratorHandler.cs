using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Utility;

namespace Logic
{
    public class ColaboratorHandler
    {
        public ColaboratorPersistenceProvider colaboratorFunctions;

        public void AddColaborator(Colaborator colaborator)
        {
            ValidateColaborator(colaborator);
            colaboratorFunctions.AddColaborator(colaborator);
        }

        public void ValidateColaborator(Colaborator colaborator)
        {
            Utility.Utilites.ValidateName(colaborator.name);
        }
    }
}
