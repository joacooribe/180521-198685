using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class TextBoxHandler
    {
        public TextBoxPersistenceProvider textBoxFunctions { get; set; }

        public void AddElement(Element textBox)
        {
            ValidateTextBox(textBox);
            textBoxFunctions.AddElement(textBox);
        }

        public Element GetElementFromCollection(int idElement, Blackboard blackboardOwner)
        {
            Utility.UtilityElement.ValidateBlackboard(blackboardOwner);
            return textBoxFunctions.GetElementFromCollection(idElement, blackboardOwner);
        }

        private void ValidateTextBox(Element element)
        {
            TextBox textBox = (TextBox)element;
            Utility.UtilityElement.ValidateBlackboard(textBox.blackboardOwner);
            Utility.UtilityElement.ValidateUser(textBox.blackboardOwner, textBox.creator);
            Utility.UtilityElement.ValidateWidth(textBox.width, textBox.blackboardOwner);
            Utility.UtilityElement.ValidateHeight(textBox.height, textBox.blackboardOwner);
            Utility.UtilityElement.ValidateOriginPoint(textBox.originPoint);
            ValidateContent(textBox.content);
            ValidateFontSize(textBox.fontSize);
            ValidateFont(textBox.font);
        }

        private void ValidateFont(string font)
        {
            ValidateNullOrEmpty(font);
        }

        private void ValidateNullOrEmpty(string font)
        {
            if (String.IsNullOrEmpty(font))
            {
                throw new TextBoxException();
            }
        }

        private void ValidateFontSize(int fontSize)
        {
            ValidateZero(fontSize);
            ValidateNegativeNumber(fontSize);
        }

        private void ValidateNegativeNumber(int fontSize)
        {
            if(fontSize < 0)
            {
                throw new TextBoxException();
            }
        }

        private void ValidateZero(int fontSize)
        {
            if(fontSize == 0)
            {
                throw new TextBoxException();
            }
        }

        private void ValidateContent(string content)
        {
            ValidateNull(content);
        }

        private void ValidateNull(string content)
        {
            if(content == null)
            {
                throw new TextBoxException();
            }
        }
    }
}
