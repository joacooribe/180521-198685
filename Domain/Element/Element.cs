using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Element
    {
        public int id { get; set; }
        public User creator { get; set; }
        public Blackboard blackboardOwner { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int originPoint { get; set; }
        public ICollection<Comment> commentCollection { get; set; }
    }
}
