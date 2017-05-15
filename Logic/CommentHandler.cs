using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class CommentHandler
    {
        CommentPersistenceProvider commentFunctions { get; set; }
        public void AddComment(Comment comment)
        {
            ValidateComment(comment);
            commentFunctions.AddComment(comment);
        }

        private void ValidateComment(Comment comment)
        {
            ValidateUserCreator(comment.userCreator);
            ValidateCreationDate(comment.creationDate);
            ValidateDescription(comment.description);
        }
    }
}
