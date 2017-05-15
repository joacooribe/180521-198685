using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using Domain;

namespace Utility
{
    public class UtilityElement
    {
        public static void ValidateBlackboard(Blackboard blackboardOwner)
        {
            if (blackboardOwner == null)
            {
                throw new ElementException(ExceptionMessage.elementBlackboardNull);
            }
        }

        public static void ValidateUser(Blackboard blackboardOwner, User creator)
        {
            ValidateNullUser(creator);
            ValidateBelongingToTheTeam(blackboardOwner.teamOwner, creator);
        }

        private static void ValidateBelongingToTheTeam(Team teamOwner, User creator)
        {
            if (DoesNotBelongToTheUserList(teamOwner.usersInTeam, creator))
            {
                throw new ElementException(ExceptionMessage.elementUserDoesNotBelongToTheTeam);
            }
        }

        private static bool DoesNotBelongToTheUserList(ICollection<User> usersInTeam, User creator)
        {
            return !usersInTeam.Contains(creator);
        }

        private static void ValidateNullUser(User creator)
        {
            if (creator == null)
            {
                throw new ElementException(ExceptionMessage.elementUserNull);
            }
        }

        public static void ValidateOriginPoint(int originPoint)
        {
            ValidateNegativeNumber(originPoint);
        }

        private static void ValidateNegativeNumber(int number)
        {
            if (number < 0)
            {
                throw new ElementException(ExceptionMessage.elementNegativeNumber);
            }
        }

        public static void ValidateHeight(int height, Blackboard blackboardOwner)
        {
            ValidateZero(height);
            ValidateNegativeNumber(height);
            ValidateGreaterThanBlackboard(height, blackboardOwner.height);
        }

        private static void ValidateZero(int number)
        {
            if (number == 0)
            {
                throw new ElementException(ExceptionMessage.elementHeightOrWidthZero);
            }
        }

        private static void ValidateGreaterThanBlackboard(int elementSize, int blackboardSize)
        {
            if (elementSize > blackboardSize)
            {
                throw new ElementException(ExceptionMessage.elementGreaterThanBlackboard);
            }
        }

        public static void ValidateWidth(int width, Blackboard blackboardOwner)
        {
            ValidateZero(width);
            ValidateNegativeNumber(width);
            ValidateGreaterThanBlackboard(width, blackboardOwner.width);
        }
    }
}
