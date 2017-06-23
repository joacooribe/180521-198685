using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Persistence
{
    public class TextBoxPersistanceHandler : ITextBoxPersistance
    {
        public Repository SystemCollection;

        public TextBoxPersistanceHandler()
        {
            SystemCollection = Repository.GetInstance;
        }

        public void AddTextBox(TextBox textBox)
        {
            AddTextBoxToTheBlackboard(textBox, textBox.blackboardOwner);
        }

        private void AddTextBoxToTheBlackboard(TextBox textBox, Blackboard blackboardOwner)
        {
            textBox.id = SystemCollection.AsignNumberToElement();
            blackboardOwner.elementsInBlackboard.Add(textBox);
        }
    }
}
