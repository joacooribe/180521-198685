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
            using (ContextDB context = new ContextDB())
            {
                context.Colaborators.Add(colaborator);
                context.SaveChanges();
            }
        }

        public Colaborator GetColaborator(string mailOfColaborator)
        {

            Colaborator colaborator = new Colaborator();
            using (ContextDB context = new ContextDB())
            {
                colaborator = context.Colaborators
                                                .Where(a => a.mail == mailOfColaborator)
                                                .FirstOrDefault();
            }
            if (ColaboratorNotDefined(colaborator))
            {
                throw new UserException(ExceptionMessage.userNotExist);
            }
            return colaborator;
        }

        public bool ColaboratorNotDefined(Colaborator colab)
        {
            return colab == null;
        }

        public bool ExistsColaborator(Colaborator colaborator)
        {
            bool exists = true;
            using (ContextDB context = new ContextDB())
            {
                colaborator = context.Colaborators
                                                .Where(a => a.mail == colaborator.mail)
                                                .FirstOrDefault(); ;
            }
            if (ColaboratorNotDefined(colaborator))
            {
                exists = false;
            }
            return exists;
        }

        public void DeleteColaborator(string mailOfColaborator)
        {
            using (ContextDB context = new ContextDB())
            {
                context.Colaborators
                                    .Where(a => a.mail == mailOfColaborator)
                                    .FirstOrDefault()
                                    .active = false;
                context.SaveChanges();
            }
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
