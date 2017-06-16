using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Users")]
    public abstract class User
    {
        [Key]
        public int OIDUser { get; set; }
        public string name { get; set; } 
        public string surname { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public DateTime birthday { get; set; }
        public ICollection<Team> teams { get; set; }
    }
}
