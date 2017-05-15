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
            //ValidateBlackboard(image.blackboardOwner);
            //ValidateUser(image.blackboardOwner, image.creator);
            //ValidateWidth(image.width, image.blackboardOwner);
            //ValidateHeight(image.height, image.blackboardOwner);
            //ValidateOriginPoint(image.originPoint);
            //ValidateContent(textBox.content);
            //ValidateFontSize(textBox.fontSize);
            //ValidateFont(textBox.font);
        }

    }
}
