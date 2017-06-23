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
        public Repository SystemCollection;
        private ICommentPersistance CommentFunctions;
        
        public ImagePersistanceHandler()
        {
            SystemCollection = Repository.GetInstance;
            CommentFunctions = new CommentPersistanceHandler();
        }

        public void AddImage(Image image)
        {
            image.id = SystemCollection.AsignNumberToElement();
            image.blackboardOwner.elementsInBlackboard.Add(image);
        }
    }
}
