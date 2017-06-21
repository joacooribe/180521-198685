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
        public Repository systemCollection;

        public TextBoxPersistanceHandler()
        {
            systemCollection = Repository.GetInstance;
        }

        public void AddTextBox(TextBox textBox)
        {
            AddTextBoxToTheBlackboard(textBox, textBox.blackboardOwner);
        }

        private void AddTextBoxToTheBlackboard(TextBox textBox, Blackboard blackboardOwner)
        {
            textBox.id = systemCollection.AsignNumberToElement();
            blackboardOwner.elementsInBlackboard.Add(textBox);
        }
    }
}
