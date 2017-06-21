using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int OIDComment { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime resolvedDate { get; set; }
        public User userCreator { get; set; }
        public User userSolver { get; set; }
        public bool commentResolved { get; set; }
        public string description { get; set; }
        public Element elementOwner { get; set; }
    }
}
