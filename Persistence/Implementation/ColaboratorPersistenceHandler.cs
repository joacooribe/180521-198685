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
        public Repository systemCollection;

        public ColaboratorPersistenceHandler()
        {
            systemCollection = Repository.GetInstance;
        }

        public void AddColaborator(Colaborator colaborator)
        {
            systemCollection.colaboratorCollection.Add(colaborator);
        }

        public Colaborator GetColaborator(string mailOfColaborator)
        {

            Colaborator colaborator = new Colaborator();
            foreach (Colaborator colaboratorFromColecction in systemCollection.colaboratorCollection)
            {
                if (mailOfColaborator.Equals(colaboratorFromColecction.mail))
                {
                    colaborator = colaboratorFromColecction;
                    return colaborator;
                }
            }
            throw new UserException(ExceptionMessage.userNotExist);
        }

        public bool ExistsColaborator(Colaborator colaborator)
        {
            bool existsColaborator = false;
            foreach (Colaborator colaboratorFromColecction in systemCollection.colaboratorCollection)
            {
                if (colaborator.Equals(colaboratorFromColecction))
                {
                    existsColaborator = true;
                }
            }
            return existsColaborator;
        }

        public void DeleteColaborator(string mailOfColaborator)
        {
            Colaborator colaboratorToChange = GetColaborator(mailOfColaborator);
            colaboratorToChange.active = false;
        }

        public bool IsEmptyColaboratorCollection()
        {
            return systemCollection.colaboratorCollection.Count == 0;
        }

        public void EmptyColaborators()
        {
            systemCollection.colaboratorCollection.Clear();
        }
    }
}
