﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Test
{
    class DataCreation
    {
        internal static Administrator CreateAdministrator(string name, string surname, string mail, string password, DateTime birthday)
        {
            Administrator administrator = new Administrator();
            administrator.name = name;
            administrator.surname = surname;
            administrator.mail = mail;
            administrator.password = password;
            administrator.birthday = birthday;
            administrator.active = true;
            administrator.teams = new List<Team>();
            return administrator;
        }

        internal static Colaborator CreateColaborator(string name, string surname, string mail, string password, DateTime birthday)
        {
            Colaborator colaborator = new Colaborator();
            colaborator.name = name;
            colaborator.surname = surname;
            colaborator.mail = mail;
            colaborator.password = password;
            colaborator.birthday = birthday;
            colaborator.active = true;
            colaborator.teams = new List<Team>();
            return colaborator;
        }

        internal static Team CreateTeam(string name, DateTime creationDate, Administrator creator, string description, int maxUsers, ICollection<User> usersInTeam)
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

        internal static Blackboard CreateBlackboard(string name, string description, int height, int width, User userOwner, Team teamOwner)
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

        internal static Image CreateImage(User creator, Blackboard blackboardOwner, int width, int height, int originPoint, string url, string format)
        {
            Image image = new Image();
            image.creator = creator;
            image.blackboardOwner = blackboardOwner;
            image.width = width;
            image.height = height;
            image.originPoint = originPoint;
            image.url = url;
            image.format = format;
            image.commentCollection = new List<Comment>();
            return image;
        }

        internal static TextBox CreateTextBox(User creator, Blackboard blackboardOwner, int width, int height, int originPoint, string content, string font, int fontSize)
        {
            TextBox textBox = new TextBox();
            textBox.creator = creator;
            textBox.blackboardOwner = blackboardOwner;
            textBox.width = width;
            textBox.height = height;
            textBox.originPoint = originPoint;
            textBox.content = content;
            textBox.fontSize = fontSize;
            textBox.font = font;
            textBox.commentCollection = new List<Comment>();
            return textBox;
        }

        internal static Comment CreateComment(string descriptionOk, DateTime creationDateOk, User userCreator, Element element)
        {
            Comment comment = new Comment();
            comment.creationDate = creationDateOk;
            comment.userCreator = userCreator;
            comment.description = descriptionOk;
            comment.elementOwner = element;
            return comment;
        }
    }
}
