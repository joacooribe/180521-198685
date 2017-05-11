using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Team
    {
        public string name { get; set; }
        public DateTime creationDate { get; set; }
        public string description { get; set; }
        public int maxUsers { get; set; }
        public List<User> usersInTeam { get; set; }

    }
}
