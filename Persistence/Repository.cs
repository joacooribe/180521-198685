using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Repository
    {
        public Session session { get; set; }
        public ICollection<Colaborator> colaboratorCollection { get; }
        public ICollection<Administrator> administratorCollection { get; }
        public ICollection<Team> teamCollection { get; }
        public ICollection<Blackboard> blackboardCollection { get; }

        public Repository() {
            session = new Session();
            colaboratorCollection = new List<Colaborator>();
            administratorCollection = new List<Administrator>();
            teamCollection = new List<Team>();
            blackboardCollection = new List<Blackboard>();
        }
    }
}
