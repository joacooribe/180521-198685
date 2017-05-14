﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Exceptions;
using Logic;

namespace Test
{
    [TestClass]
    public class ImageLogicTest
    {
        private Colaborator colaboratorCreator;
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
        private readonly string blackboardNameOk = "Blackboard";
        private readonly int blackboardWidthOk = 23;
        private readonly int blackboardHeightOk = 20;
        private readonly string blackboardDescriptionOk = "Blackboard Team 1";

        private Image image;
        private readonly int idOk = 1;
        private readonly int widthOk = 10;
        private readonly int heightOk = 12;
        private readonly int originPointOk = 0;
        private readonly string formatOk = ".jpg";
        private readonly string urlOk = "/image/hola.jpg";

        public ImageLogicTest()
        {

        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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
        public void ImageTestOk()
        {
            usersInTeam = new List<User>();

            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, colaboratorCreator, teamOwner);
            Image image = DataCreation.CreateImage(idOk, colaboratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);
            
            User creator = colaboratorCreator;
            Assert.AreEqual(idOk, image.id);
        }
    }
}
