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
            AddElementToTheBlackboard(element, element.blackboardOwner);
        }

        private void AddElementToTheBlackboard(Element element, Blackboard blackboardOwner)
        {
            element.id = systemCollection.AsignNumberToElement();
            blackboardOwner.elementsInBlackboard.Add(element);
        }

        public Element GetElementFromCollection(int idElement, Blackboard blackboardOwner)
        {
            Element textBox = new TextBox();
            textBox.id = idElement;
            textBox.blackboardOwner = blackboardOwner;
            foreach (Element elementFromColecction in blackboardOwner.elementsInBlackboard)
            {
                if (elementFromColecction.Equals(textBox))
                {
                    textBox = elementFromColecction;
                    return textBox;
                }
            }
            throw new Exception();
        }
    }
}
