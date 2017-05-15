using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TextBox : Element
    {
        public string content { get; set; }
        public int fontSize { get; set; }
        public string font { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                TextBox textBox = (TextBox)obj;
                if (this.id.Equals(textBox.id) && this.blackboardOwner.Equals(textBox.blackboardOwner))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
