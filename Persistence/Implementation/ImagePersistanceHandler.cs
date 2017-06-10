using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

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

        public Image GetImage(int idElement, Blackboard blackboardOwner)
        {
            Image image = new Image();
            image.id = idElement;
            image.blackboardOwner = blackboardOwner;
            foreach (Element elementFromColecction in blackboardOwner.elementsInBlackboard)
            {
                if (elementFromColecction.Equals(image))
                {
                    image = (Image)elementFromColecction;
                    return image;
                }
            }
            throw new ImageException(ExceptionMessage.imageNotFound);
        }

        public void DeleteImage(Image image)
        {
            DeleteAllCommentOfImage(image);
            DeleteImageFromBlackboard(image, image.blackboardOwner);
        }

        private void DeleteAllCommentOfImage(Image image)
        {
            foreach(Comment commentOfImage in image.commentCollection)
            {
                commentFunctions.DeleteComment(commentOfImage);
            }
        }

        private void DeleteImageFromBlackboard(Image image, Blackboard blackboardOwner)
        {
            blackboardOwner.elementsInBlackboard.Remove(image);
        }
    }
}
