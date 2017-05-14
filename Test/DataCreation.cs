using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Test
{
    class DataCreation
    {
        public static Administrator CreateAdministrator(string name, string surname, string mail, string password, DateTime birthday)
        {
            Administrator administrator = new Administrator();
            administrator.name = name;
            administrator.surname = surname;
            administrator.mail = mail;
            administrator.password = password;
            administrator.birthday = birthday;
            return administrator;
        }

        public static Colaborator CreateColaborator(string name, string surname, string mail, string password, DateTime birthday)
        {
            Colaborator colaborator = new Colaborator();
            colaborator.name = name;
            colaborator.surname = surname;
            colaborator.mail = mail;
            colaborator.password = password;
            colaborator.birthday = birthday;
            return colaborator;
        }

        public static Team CreateTeam(string name, DateTime creationDate, Administrator creator, string description, int maxUsers, ICollection<User> usersInTeam)
        {
            Team team = new Team();
            team.name = name;
            team.creator = creator;
            team.creationDate = creationDate;
            team.description = description;
            team.maxUsers = maxUsers;
            team.usersInTeam = usersInTeam;
            return team;
        }

        public static Blackboard CreateBlackboard(string name, string description, int height, int width, User userOwner, Team teamOwner)
        {
            Blackboard blackboard = new Blackboard();
            blackboard.name = name;
            blackboard.description = description;
            blackboard.height = height;
            blackboard.width = width;
            blackboard.userCreator = userOwner;
            blackboard.teamOwner = teamOwner;
            blackboard.elementsInBlackboard = new List<Element>();
            return blackboard;
        }

        public static Image CreateImage(int id, User creator, Blackboard blackboardOwner, int width, int height, int originPoint, string url, string format)
        {
            Image image = new Image();
            image.id = id;
            image.creator = creator;
            image.blackboardOwner = blackboardOwner;
            image.width = width;
            image.height = height;
            image.originPoint = originPoint;
            image.url = url;
            image.format = format;
            return image;
        }
    }
}
