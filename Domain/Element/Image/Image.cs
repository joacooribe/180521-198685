using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Images")]
    public class Image : Element
    {
        [Key]
        public int OIDImage { get; set; }
        public string format { get; set; }
        public string url { get; set; }

        public override bool Equals(object obj)
        {
            bool equal = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Image image = (Image)obj;
                if (this.id.Equals(image.id) && this.blackboardOwner.Equals(image.blackboardOwner))
                {
                    equal = true;
                }

            }
            return equal;
        }
    }
}
