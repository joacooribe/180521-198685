﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;

namespace Test
{
    [TestClass]
    public class ImageTest
    {
        private Administrator administratorCreator;
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userMailOK = "user@gmail.com";
        private readonly string userPasswordOK = "securePassword123";
        private readonly DateTime userBirthdayOk = new DateTime(1992, 9, 10);

        private Team teamOwner;
        private ICollection<User> usersInTeam;
        private readonly string teamNameOK = "Team 1";
        private readonly DateTime teamDateOK = DateTime.Now;
        private readonly string teamDescriptionOK = "this is Team 1";
        private readonly int teamMaxUsersOK = 5;

        private Blackboard blackboardOwner;
        private Blackboard anotherBlackboardOwner;
        private readonly string blackboardNameOk = "Blackboard";
        private readonly string anotherBlackboardNameOk = "Another Blackboard";
        private readonly int blackboardWidthOk = 23;
        private readonly int blackboardHeightOk = 20;
        private readonly string blackboardDescriptionOk = "Blackboard Team 1";

        private Image image;
        private Image anotherImage;
        private readonly int widthOk = 10;
        private readonly int heightOk = 12;
        private readonly int originPointOk = 0;
        private readonly string formatOk = ".jpg";
        private readonly string urlOk = "/image/hola.jpg";

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ImageSameIdAndSameBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            anotherImage = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);
            anotherImage.id = image.id;

            Assert.IsTrue(image.Equals(anotherImage));
        }

        [TestMethod]
        public void ImageDifferentIdAndSameBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);
            image.id = 0;

            anotherImage = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);
            anotherImage.id = 1;

            Assert.IsFalse(image.Equals(anotherImage));
        }

        [TestMethod]
        public void ImageSameIdAndDifferentBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);
            anotherBlackboardOwner = DataCreation.CreateBlackboard(anotherBlackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            anotherImage = DataCreation.CreateImage(administratorCreator, anotherBlackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);
            anotherImage.id = image.id;

            Assert.IsFalse(image.Equals(anotherImage));
        }

        [TestMethod]
        public void ImageDifferentIdAndDifferentBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);
            anotherBlackboardOwner = DataCreation.CreateBlackboard(anotherBlackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);
            image.id = 0;

            anotherImage = DataCreation.CreateImage(administratorCreator, anotherBlackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);
            anotherImage.id = 1;

            Assert.IsFalse(image.Equals(anotherImage));
        }

        [TestMethod]
        public void ImageNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);
            anotherBlackboardOwner = DataCreation.CreateBlackboard(anotherBlackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            anotherImage = null;

            Assert.IsFalse(image.Equals(anotherImage));
        }
    }
}
