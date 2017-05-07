using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SystemList
    {
        public List<Colaborator> ColaboratorList { get; }

        public SystemList() {
            ColaboratorList = new List<Colaborator>();
        }
    }
}
