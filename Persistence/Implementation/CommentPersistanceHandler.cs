﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using System.Data.Entity;

namespace Persistence
{
    public class CommentPersistanceHandler : ICommentPersistance
    {
        public Repository systemCollection;

        public CommentPersistanceHandler()
        {
            systemCollection = Repository.GetInstance;
        }

        public void AddComment(Comment comment)
        {
            AddCommentToElement(comment,comment.elementOwner);
        }

        private void AddCommentToElement(Comment comment, Element elementOwner)
        {
            elementOwner.commentCollection.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            DeleteCommentFromElement(comment, comment.elementOwner);
        }

        private void DeleteCommentFromElement(Comment comment, Element elementOwner)
        {
            elementOwner.commentCollection.Remove(comment);
        }
    }
}
