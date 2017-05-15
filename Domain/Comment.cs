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
        public User userResolving { get; set; }
    }
}
