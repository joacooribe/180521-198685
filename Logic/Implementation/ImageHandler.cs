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
    public class ImageHandler : IImageHandler
    {
        public IElementPersistance elementFunctions { get; set; }
        public IImagePersistance imageFunctions { get; set; }

        private List<string> validFormats;

        public ImageHandler()
        {
            elementFunctions = new ElementPersistenceHandler();
            imageFunctions = new ImagePersistanceHandler();
        }

        private void createListOfValidFormats()
        {
            validFormats = new List<string>();
            validFormats.Add(".jpeg");
            validFormats.Add(".png");
            validFormats.Add(".gif");
            validFormats.Add(".jpg");
        }

        public void AddElement(Element element)
        {
            Image image = (Image)element;
            ValidateImage(image);
            imageFunctions.AddImage(image);
        }

        private void ValidateImage(Image image)
        {
            Utility.UtilityElement.ValidateCommentCollection(image.commentCollection);
            Utility.UtilityElement.ValidateBlackboard(image.blackboardOwner);
            Utility.UtilityElement.ValidateUser(image.blackboardOwner, image.creator);
            Utility.UtilityElement.ValidateWidth(image.width, image.blackboardOwner);
            Utility.UtilityElement.ValidateHeight(image.height, image.blackboardOwner);
            Utility.UtilityElement.ValidateOriginPoint(image.originPoint);
            ValidateUrl(image.url);
            ValidateFormat(image.format);    
        }

        private void ValidateFormat(string format)
        {
            ValidateNullOrEmpty(format);
            ValidateAcceptedFormat(format);
        }

        private void ValidateAcceptedFormat(string format)
        {
            if (NotAcceptedFormat(format))
            {
                throw new ImageException(ExceptionMessage.imageNotAcceptedFormat);
            }
        }

        private bool NotAcceptedFormat(string format)
        {
            createListOfValidFormats();
            return !validFormats.Contains(format);
        }

        private void ValidateNullOrEmpty(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new ImageException(ExceptionMessage.imageFormatOrUrlNullOrEmpty);
            }
        }

        private void ValidateUrl(string url)
        {
            ValidateNullOrEmpty(url);
        }

        public Element GetElementFromCollection(int idElement, Blackboard blackboardOwner)
        {
            Utility.UtilityElement.ValidateBlackboard(blackboardOwner);
            return elementFunctions.GetElement(idElement, blackboardOwner);
        }

        public void DeleteElement(Element element)
        {
            //Image image = (Image)element;
            ValidateImage((Image)element);
            elementFunctions.DeleteElement(element);
        }
    }
}
