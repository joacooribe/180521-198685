using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;
using Persistence;

namespace Logic
{
    public class TextBoxHandler : ITextBoxHandler
    {
        public IElementPersistance ElementFunctions { get; set; }
        public ITextBoxPersistance TextBoxFunctions { get; set; }

        public TextBoxHandler()
        {
            ElementFunctions = new ElementPersistenceHandler();
            TextBoxFunctions = new TextBoxPersistanceHandler();
        }

        public void AddElement(Element element)
        {
            TextBox textBox = (TextBox)element;
            ValidateTextBox(textBox);
            TextBoxFunctions.AddTextBox(textBox);
        }

        private void ValidateTextBox(TextBox textBox)
        {
            Utility.UtilityElement.ValidateCommentCollection(textBox.commentCollection);
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
                throw new TextBoxException(ExceptionMessage.textBoxFontNullOrEmpty);
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
                throw new TextBoxException(ExceptionMessage.textBoxNegativeFontSize);
            }
        }

        private void ValidateZero(int fontSize)
        {
            if(fontSize == 0)
            {
                throw new TextBoxException(ExceptionMessage.textBoxFontSizeZero);
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
                throw new TextBoxException(ExceptionMessage.textBoxContentNull);
            }
        }

        public Element GetElementFromCollection(int idElement, Blackboard blackboardOwner)
        {
            Utility.UtilityElement.ValidateBlackboard(blackboardOwner);
            return ElementFunctions.GetElement(idElement, blackboardOwner);
        }

        public void DeleteElement(Element element)
        {
            ValidateTextBox((TextBox)element);
            ElementFunctions.DeleteElement(element);
        }
    }
}
