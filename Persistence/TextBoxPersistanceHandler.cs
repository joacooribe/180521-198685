using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class TextBoxPersistanceHandler : TextBoxPersistenceProvider
    {
        public Repository systemCollection;

        public TextBoxPersistanceHandler(Repository collection)
        {
            systemCollection = collection;
        }

        public void AddElement(Element element)
        {
            element.blackboardOwner.elementsInBlackboard.Add(element);
        }

        public Element GetElementFromCollection(int idElement, Blackboard blackboardOwner)
        {
            Element textBox = new TextBox();
            return textBox;
        }
    }
}
