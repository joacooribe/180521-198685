using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class ImagePersistanceHandler : ImagePersistenceProvider
    {
        public Repository systemCollection;

        public ImagePersistanceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddElement(Element element)
        {
            element.blackboardOwner.elementsInBlackboard.Add(element);
        }
    }
}
