﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Exceptions;
using Logic;
using Persistence;

namespace Test
{
    [TestClass]
    public class BlackboardLogicTest
    {
        private Colaborator colaboratorCreator;
        private Administrator administratorCreator;
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userMailOK = "user@gmail.com";
        private readonly string userPasswordOK = "securePassword123";
        private readonly DateTime userBirthdayOk = new DateTime(1992, 9, 10);

        private Team teamOwner;
        private List<User> usersInTeam;
        private readonly string teamNameOK = "Team 1";
        private readonly DateTime teamDateOK = DateTime.Now;
        private readonly string teamDescriptionOK = "this is Team 1";
        private readonly int teamMaxUsersOK = 5;

        private Blackboard blackboard;
        private readonly string blackboardNameOk = "Blackboard";
        private readonly int widthOk = 23;
        private readonly int highOk = 20;
        private readonly string blackboardDescriptionOk = "Blackboard Team 1";

        private Repository systemList;
        private BlackboardPersistenceHandler blackboardPersistence;
        private BlackboardHandler blackboardHandler;

        public BlackboardLogicTest()
        {
            systemList = new Repository();
            blackboardPersistence = new BlackboardPersistenceHandler(systemList);
            blackboardHandler = new BlackboardHandler() { blackboardFunctions = blackboardPersistence };
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
        public void BlackboardOkCreatedByColaborator()
        {
            usersInTeam = new List<User>();

            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, highOk, widthOk, colaboratorCreator, teamOwner);

            blackboardPersistence.AddBlackboard(blackboard);

            Assert.AreEqual(blackboardNameOk, blackboard.name);
        }

        [TestMethod]
        public void BlackboardOkCreatedByAdministrator()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, highOk, widthOk, administratorCreator, teamOwner);

            blackboardPersistence.AddBlackboard(blackboard);

            Assert.AreEqual(blackboardNameOk, blackboard.name);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardEmptyName()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidName = "";

            blackboard = DataCreation.CreateBlackboard(invalidName, blackboardDescriptionOk, highOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNullName()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidName = null;

            blackboard = DataCreation.CreateBlackboard(invalidName, blackboardDescriptionOk, highOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNameToLong()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidName = "This name is not valid because it is too long";

            blackboard = DataCreation.CreateBlackboard(invalidName, blackboardDescriptionOk, highOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardEmptyDescription()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidDescription = "";

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, invalidDescription, highOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNUllDescription()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidDescription = null;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, invalidDescription, highOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardDescriptionToLong()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidDescription = "This is not a valid description because it is to long, you can write max 50 letters";

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, invalidDescription, highOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardWithoutUser()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, highOk, widthOk, null, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNegativeHigh()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidHigh = -1;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, invalidHigh, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardCeroHigh()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidHigh = 0;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, invalidHigh, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNegativeWidth()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidWidth = -1;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, highOk, invalidWidth, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardCeroWidth()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidWidth = 0;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, highOk, invalidWidth, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardWithoutTeam()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, highOk, widthOk, administratorCreator, null);

            blackboardHandler.AddBlackboard(blackboard);
        }
    }
}