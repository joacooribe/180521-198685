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
        public ICollection<Colaborator> colaboratorCollection { get; }
        public ICollection<Administrator> administratorCollection { get; }
        public ICollection<Team> teamCollection { get; }

        public Repository() {
            colaboratorCollection = new List<Colaborator>();
            administratorCollection = new List<Administrator>();
            teamCollection = new List<Team>();

        }
    }
}
