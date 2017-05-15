using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Persistence
{
    public class CommentPersistanceHandler : CommentPersistenceProvider
    {
        public Repository systemCollection;

        public CommentPersistanceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddComment(Comment comment)
        {
            AddCommentToElement(comment,comment.elementOwner);
        }

        private void AddCommentToElement(Comment comment, Element elementOwner)
        {
            if (AlreadyExistComment(comment, elementOwner))
            {
                throw new CommentException();
            }
            elementOwner.commentCollection.Add(comment);
        }

        private bool AlreadyExistComment(Comment comment, Element elementOwner)
        {
            return elementOwner.commentCollection.Contains(comment);
        }
    }
}
