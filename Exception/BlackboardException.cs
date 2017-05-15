using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    public class BlackboardException : Exception
    {
        public BlackboardException(string message) : base(message)
        {
        }
    }
}
