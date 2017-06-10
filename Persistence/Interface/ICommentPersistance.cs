using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface ICommentPersistance
    {
        void AddComment(Comment comment);
        void DeleteComment(Comment comment);
    }
}
