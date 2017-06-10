using System;
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
        private ICollection<User> usersInTeam;
        private readonly string teamNameOK = "Team 1";
        private readonly DateTime teamDateOK = DateTime.Now;
        private readonly string teamDescriptionOK = "this is Team 1";
        private readonly int teamMaxUsersOK = 5;

        private Blackboard blackboard;
        private readonly string blackboardNameOk = "Blackboard";
        private readonly int widthOk = 23;
        private readonly int heightOk = 20;
        private readonly string blackboardDescriptionOk = "Blackboard Team 1";

        private IBlackboardPersistance blackboardPersistence;
        private IBlackboardHandler blackboardHandler;

        public BlackboardLogicTest()
        {
            blackboardPersistence = new BlackboardPersistenceHandler();
            blackboardHandler = new BlackboardHandler();
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

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, colaboratorCreator, teamOwner);

            blackboardPersistence.AddBlackboard(blackboard);

            Assert.AreEqual(blackboardNameOk, blackboard.name);
        }

        [TestMethod]
        public void BlackboardOkCreatedByAdministrator()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

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

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidName = "";

            blackboard = DataCreation.CreateBlackboard(invalidName, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNullName()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidName = null;

            blackboard = DataCreation.CreateBlackboard(invalidName, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNameToLong()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidName = "This name is not valid because it is too long";

            blackboard = DataCreation.CreateBlackboard(invalidName, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardEmptyDescription()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidDescription = "";

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, invalidDescription, heightOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNUllDescription()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidDescription = null;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, invalidDescription, heightOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardDescriptionToLong()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            string invalidDescription = "This is not a valid description because it is to long, you can write max 50 letters";

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, invalidDescription, heightOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardWithoutUser()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, null, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNegativeheight()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidheight = -1;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, invalidheight, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardZeroheight()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidheight = 0;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, invalidheight, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardNegativeWidth()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidWidth = -1;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, invalidWidth, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardZeroWidth()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            int invalidWidth = 0;

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, invalidWidth, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void BlackboardWithoutTeam()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator,  teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, null);

            blackboardHandler.AddBlackboard(blackboard);
        }

        [TestMethod]
        [ExpectedException(typeof(BlackboardException))]
        public void AddTheSameBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboardHandler.AddBlackboard(blackboard);
            blackboardHandler.AddBlackboard(blackboard);
        }
    }
}
