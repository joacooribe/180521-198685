using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Persistence
{
    public class ElementPersistenceHandler : IElementPersistance
    {
        public Repository SystemCollection;
        private ICommentPersistance CommentFunctions;

        public ElementPersistenceHandler()
        {
            SystemCollection = Repository.GetInstance;
            CommentFunctions = new CommentPersistanceHandler();
        }
        public Element GetElement(int idElement, Blackboard blackboardOwner)
        {
            foreach (Element elementFromColecction in blackboardOwner.elementsInBlackboard)
            {
                if (elementFromColecction.id.Equals(idElement) && elementFromColecction.blackboardOwner.Equals(blackboardOwner))
                {
                    return elementFromColecction;
                }
            }
            throw new ImageException(ExceptionMessage.imageNotFound);
        }

        public void DeleteElement(Element element)
        {
            DeleteAllCommentOfElement(element);
            DeleteElementFromBlackboard(element, element.blackboardOwner);
        }

        private void DeleteAllCommentOfElement(Element element)
        {
            foreach (Comment commentOfImage in element.commentCollection)
            {
                CommentFunctions.DeleteComment(commentOfImage);
            }
        }

        private void DeleteElementFromBlackboard(Element element, Blackboard blackboardOwner)
        {
            blackboardOwner.elementsInBlackboard.Remove(element);
        }
    }
}
