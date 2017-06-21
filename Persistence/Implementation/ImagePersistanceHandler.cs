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
    public class ImagePersistanceHandler : IImagePersistance
    {
        public Repository systemCollection;
        private ICommentPersistance commentFunctions;
        
        public ImagePersistanceHandler()
        {
            systemCollection = Repository.GetInstance;
            commentFunctions = new CommentPersistanceHandler();
        }

        public void AddImage(Image image)
        {
            image.id = systemCollection.AsignNumberToElement();
            image.blackboardOwner.elementsInBlackboard.Add(image);
        }
    }
}
