using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment
    {
        public DateTime creationDate { get; set; }
        public DateTime resolvedDate { get; set; }
        public User userCreator { get; set; }
        public User userSolver { get; set; }
        public bool commentResolved { get; set; }
        public string description { get; set; }
        public Element elementOwner { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Comment comment = (Comment)obj;
                if (HaveTheSameUserCreator(this.userCreator,comment.userCreator) && HaveTheSameCreationDate(this.creationDate,comment.creationDate) && HaveTheSameDescription(this.description,comment.description))
                {
                    return true;
                }
            }
            return false;
        }

        private bool HaveTheSameDescription(string description, string anotherDescription)
        {
            return description.Equals(anotherDescription);
        }

        private bool HaveTheSameCreationDate(DateTime creationDate, DateTime anotherCreationDate)
        {
            return creationDate.Equals(anotherCreationDate);
        }

        private bool HaveTheSameUserCreator(User userCreator, User anotherUserCreator)
        {
            return userCreator.Equals(anotherUserCreator);
        }
    }
}
