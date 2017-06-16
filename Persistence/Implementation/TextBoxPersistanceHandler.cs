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
        private ICommentPersistance commentFunctions;

        public TextBoxPersistanceHandler()
        {
            systemCollection = Repository.GetInstance;
            commentFunctions = new CommentPersistanceHandler();
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

        public TextBox GetTextBox(int idElement, Blackboard blackboardOwner)
        {
            TextBox textBox = new TextBox();
            textBox.id = idElement;
            textBox.blackboardOwner = blackboardOwner;
            foreach (Element elementFromColecction in blackboardOwner.elementsInBlackboard)
            {
                if (elementFromColecction.Equals(textBox))
                {
                    textBox = (TextBox)elementFromColecction;
                    return textBox;
                }
            }
            throw new Exception();
        }

        public void DeleteElement(Element element)
        {
            DeleteAllCommentOfTextBox(element);
            DeleteTextBoxFromBlackboard(element, element.blackboardOwner);
        }

        private void DeleteAllCommentOfTextBox(Element element)
        {
            foreach (Comment commentOfTextBox in element.commentCollection)
            {
                commentFunctions.DeleteComment(commentOfTextBox);
            }
        }

        private void DeleteTextBoxFromBlackboard(Element element, Blackboard blackboardOwner)
        {
            blackboardOwner.elementsInBlackboard.Remove(element);
        }
    }
}
