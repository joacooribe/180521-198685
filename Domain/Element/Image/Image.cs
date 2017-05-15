using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Image : Element
    {
        public string format { get; set; }
        public string url { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                Image image = (Image)obj;
                if (this.id.Equals(image.id) && this.blackboardOwner.Equals(image.blackboardOwner))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
