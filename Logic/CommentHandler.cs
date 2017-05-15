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
        const int MAMIMUXSIZEDESCRIPTION = 50;
        public CommentPersistenceProvider commentFunctions { get; set; }
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

        private void ValidateDescription(string description)
        {
            ValidateNullOrEmptyDescription(description);
            ValidateSizeOfDescription(description);
        }

        private void ValidateSizeOfDescription(string description)
        {
            if(description.Length > MAMIMUXSIZEDESCRIPTION)
            {
                throw new CommentException();
            }
        }

        private void ValidateNullOrEmptyDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new CommentException();
            }
        }

        private void ValidateCreationDate(DateTime creationDate)
        {
            if (ValidateIsNotFutureDate(creationDate))
            {
                throw new CommentException();
            }
        }
        private static bool ValidateIsNotFutureDate(DateTime creationDate)
        {
            return creationDate > DateTime.Now;
        }

        private void ValidateUserCreator(User userCreator)
        {
            if(userCreator == null)
            {
                throw new CommentException();
            }
        }
    }
}
