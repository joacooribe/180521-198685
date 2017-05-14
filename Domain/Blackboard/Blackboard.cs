using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Blackboard
    {
        public User userCreator { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        public Team teamOwner { get; set; }
        public int width { get; set; }
        public ICollection<Element> elementsInBlackboard { get; set; }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Blackboard blackboard = (Blackboard)obj;
                equals = blackboard.name.Equals(this.name) && blackboard.teamOwner.Equals(this.teamOwner);
            }
            return equals;
        }
    }
}