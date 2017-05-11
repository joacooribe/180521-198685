using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logic
{
    public class ColaboratorHandler
    {
        public ColaboratorPersistenceProvider colaboratorFunctions { get; set; }

        public void AddColaborator(Colaborator colaborator)
        {
            ValidateColaborator(colaborator);
            colaboratorFunctions.AddColaborator(colaborator);
        }

        public Colaborator GetColaboratorFromColecction(Colaborator colaboratorToFind)
        {
            ValidateColaborator(colaboratorToFind);
            return colaboratorFunctions.GetColaboratorFromColecction(colaboratorToFind);
        }

        public void ValidateColaborator(Colaborator colaborator)
        {
            Utility.Utilites.ValidateNameOrSurname(colaborator.name);
            Utility.Utilites.ValidateNameOrSurname(colaborator.surname);
            Utility.Utilites.ValidatePassword(colaborator.password);
            Utility.Utilites.ValidateMail(colaborator.mail);
            Utility.Utilites.ValidateBirthDate(colaborator.birthday);
        }
    }
}
