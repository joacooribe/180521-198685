using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public interface ITextBoxPersistance : IElementPersistance
    {
        void AddTextBox(TextBox textBox);
        TextBox GetTextBox(int id, Blackboard blackboard);
    }
}
