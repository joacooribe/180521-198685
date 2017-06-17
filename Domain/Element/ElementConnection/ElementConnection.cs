using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public enum Direction { Bidirectional , Directional, None}
    [Table("Images")]
    public class ElementConnection : Element
    {
        [Key]
        public int OIDElementConnection { get; set; }
        public ICollection<Element> Connetions { get; set; }
        public Direction TypeOfConnection { get; set; }
    }
}
