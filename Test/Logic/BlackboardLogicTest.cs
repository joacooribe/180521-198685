using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

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
        private readonly string teamNameOK = "Team 1";
        private readonly DateTime teamDateOK = DateTime.Now;
        private readonly string teamDescriptionOK = "this is Team 1";
        private readonly int teamMaxUsersOK = 5;

        private Blackboard blackboard;
        private readonly string blackboardName = "Blackboard";
        private readonly int width = 23;
        private readonly int high = 20;
        private readonly string blackboardDescription = "Blackboard Team 1";

        public BlackboardLogicTest()
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
        public void BlackboardOkCreatedByColaborator()
        {
            List<User> usersInTeam = new List<User>();

            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardName, blackboardDescription, high, width, colaboratorCreator, teamOwner);

            Assert.AreEqual(blackboardName, blackboard.name);
        }

        [TestMethod]
        public void BlackboardOkCreatedByAdministrator()
        {
            List<User> usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardName, blackboardDescription, high, width, administratorCreator, teamOwner);

            Assert.AreEqual(blackboardName, blackboard.name);
        }

        [TestMethod]
        public void BlackboardEmptyName()
        {

        }

        [TestMethod]
        public void BlackboardNullName()
        {

        }

        [TestMethod]
        public void BlackboardNameToLong()
        {

        }

        [TestMethod]
        public void BlackboardEmptyDescription()
        {

        }

        [TestMethod]
        public void BlackboardNUllDescription()
        {

        }

        [TestMethod]
        public void BlackboardDescriptionToLong()
        {

        }

        [TestMethod]
        public void BlackboardWithoutUser()
        {

        }

        [TestMethod]
        public void BlackboardNullHigh()
        {

        }

        [TestMethod]
        public void BlackboardNegativeHigh()
        {

        }

        [TestMethod]
        public void BlackboardCeroHigh()
        {

        }

        [TestMethod]
        public void BlackboardNullWidth()
        {

        }

        [TestMethod]
        public void BlackboardNegativeWidth()
        {

        }

        [TestMethod]
        public void BlackboardCeroWidth()
        {

        }

        [TestMethod]
        public void BlackboardWithoutTeam()
        {

        }
    }
}
