using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SystemList
    {
        public List<Colaborator> colaboratorList { get; }
        public List<Administrator> administratorList { get; }

        public SystemList() {
            colaboratorList = new List<Colaborator>();
            administratorList = new List<Administrator>();
        }
    }
}
