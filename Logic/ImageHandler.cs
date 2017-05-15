using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Exceptions;

namespace Logic
{
    public class ImageHandler
    {
        public ImagePersistenceProvider imageFunctions { get; set; }
        private List<string> validFormats;

        private void createListOfValidFormats()
        {
            validFormats = new List<string>();
            validFormats.Add(".jpeg");
            validFormats.Add(".png");
            validFormats.Add(".gif");
            validFormats.Add(".jpg");
        }

        public void AddElement(Element image)
        {
            ValidateImage(image);
            imageFunctions.AddElement(image);
        }

        public Element GetElementFromCollection(int idElement, Blackboard blackboardOwner)
        {
            Utility.UtilityElement.ValidateBlackboard(blackboardOwner);
            return imageFunctions.GetElementFromCollection(idElement, blackboardOwner);
        }

        private void ValidateImage(Element element)
        {
            Image image = (Image)element;
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
    }
}
