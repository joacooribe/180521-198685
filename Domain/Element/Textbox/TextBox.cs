using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("TextBoxes")]
    public class TextBox : Element
    {
        [Key]
        public int OIDTextBox { get; set; }
        public string content { get; set; }
        public int fontSize { get; set; }
        public string font { get; set; }

        public override bool Equals(object obj)
        {
            bool equal = false;
            if (obj != null && obj.GetType().Equals(this.GetType()))
            {
                TextBox textBox = (TextBox)obj;
                if (this.id.Equals(textBox.id) && this.blackboardOwner.Equals(textBox.blackboardOwner))
                {
                    equal = true;
                }
            }
            return equal;
        }
    }
}
