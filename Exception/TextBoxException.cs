using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    public class TextBoxException : Exception
    {
        public TextBoxException(string message) : base(message)
        {
        }
    }
}
