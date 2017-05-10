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
        public ICollection<Colaborator> colaboratorList { get; }
        public ICollection<Administrator> administratorList { get; }
        public ICollection<Team> teamList { get; }

        public Repository() {
            colaboratorList = new List<Colaborator>();
            administratorList = new List<Administrator>();
            teamList = new List<Team>();

        }
    }
}
