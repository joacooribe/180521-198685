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

    }
}
