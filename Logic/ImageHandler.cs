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

        private void ValidateImage(Element element)
        {
            Image image = (Image)element;
            ValidateBlackboard(image.blackboardOwner);
            ValidateUser(image.blackboardOwner, image.creator);
            ValidateWidth(image.width, image.blackboardOwner);
            ValidateHeight(image.height, image.blackboardOwner);
            ValidateOriginPoint(image.originPoint);
            ValidateUrl(image.url);
            ValidateFormat(image.format);    
        }

        private void ValidateBlackboard(Blackboard blackboardOwner)
        {
            if(blackboardOwner == null)
            {
                throw new ImageException();
            }
        }

        private void ValidateUser(Blackboard blackboardOwner, User creator)
        {
            ValidateNullUser(creator);
            ValidateBelongingToTheTeam(blackboardOwner.teamOwner, creator);
        }

        private void ValidateBelongingToTheTeam(Team teamOwner, User creator)
        {
            if (DoesNotBelongToTheUserList(teamOwner.usersInTeam,creator))
            {
                throw new ImageException();
            }
        }

        private bool DoesNotBelongToTheUserList(ICollection<User> usersInTeam, User creator)
        {
            return !usersInTeam.Contains(creator);
        }

        private void ValidateNullUser(User creator)
        {
            if(creator == null)
            {
                throw new ImageException();
            }
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
                throw new ImageException();
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
                throw new ImageException();
            }
        }

        private void ValidateUrl(string url)
        {
            ValidateNullOrEmpty(url);
        }

        private void ValidateOriginPoint(int originPoint)
        {
            ValidateNegativeNumber(originPoint);
        }

        private void ValidateNegativeNumber(int number)
        {
            if(number < 0)
            {
                throw new ImageException();
            }
        }

        private void ValidateZero(int number)
        {
            if (number == 0)
            {
                throw new ImageException();
            }
        }

        private void ValidateHeight(int height, Blackboard blackboardOwner)
        {
            ValidateZero(height);
            ValidateNegativeNumber(height);
            ValidateGreaterThanBlackboard(height, blackboardOwner.height);
        }

        private void ValidateGreaterThanBlackboard(int imageSize, int blackboardSize)
        {
            if(imageSize > blackboardSize)
            {
                throw new ImageException();
            }
        }

        private void ValidateWidth(int width, Blackboard blackboardOwner)
        {
            ValidateZero(width);
            ValidateNegativeNumber(width);
            ValidateGreaterThanBlackboard(width, blackboardOwner.width);
        }
    }
}
