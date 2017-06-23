using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Teams")]
   public class Team
    {
        [Key]
        public int OIDTeam { get; set; }
        public string name { get; set; }
        public virtual Administrator creator { get; set; }
        public DateTime creationDate { get; set; }
        public string description { get; set; }
        public int maxUsers { get; set; }
        public virtual ICollection<User> usersInTeam { get; set; }

        public override bool Equals(object obj)
        {
            bool equal = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Team team = (Team)obj;
                equal = team.name.Equals(this.name);
            }
            return equal;
        }
    }
}
