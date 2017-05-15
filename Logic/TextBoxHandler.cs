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
            throw new NotImplementedException();
        }

        private void ValidateContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
