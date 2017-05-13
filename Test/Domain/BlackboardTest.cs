using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class BlackboardTest
    {

        private Administrator administratorCreator;
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userMailOK = "user@gmail.com";
        private readonly string userPasswordOK = "securePassword123";
        private readonly DateTime userBirthdayOk = new DateTime(1992, 9, 10);

        private Team teamOwner;
        private Team anotherTeamOwner;
        private ICollection<User> usersInTeam;
        private readonly string teamNameOK = "Team 1";
        private readonly string anotherTeamNameOK = "Team 2";
        private readonly DateTime teamDateOK = DateTime.Now;
        private readonly string teamDescriptionOK = "this is the Team";
        private readonly int teamMaxUsersOK = 5;

        private Blackboard blackboard1;
        private Blackboard blackboard2;

        private readonly string blackboardNameOk = "Blackboard 1";
        private readonly string anotherBlackboardNameOk = "Blackboard 2";
        private readonly int widthOk = 23;
        private readonly int heightOk = 20;
        private readonly string blackboardDescriptionOk = "Blackboard Team 1";

        public BlackboardTest()
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
        public void BlackbordSameNameAndTeam()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard1 = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboard2 = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            Assert.IsTrue(blackboard1.Equals(blackboard2));
        }

        [TestMethod]
        public void BlackbordSameNameAndDifferentTeam()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            anotherTeamOwner = DataCreation.CreateTeam(anotherTeamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard1 = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboard2 = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, anotherTeamOwner);

            Assert.IsFalse(blackboard1.Equals(blackboard2));
        }

        [TestMethod]
        public void BlackbordDifferentNameAndSameTeam()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard1 = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboard2 = DataCreation.CreateBlackboard(anotherBlackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            Assert.IsFalse(blackboard1.Equals(blackboard2));
        }

        [TestMethod]
        public void BlackbordDifferentNameAndDifferentTeam()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            anotherTeamOwner = DataCreation.CreateTeam(anotherTeamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard1 = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            blackboard2 = DataCreation.CreateBlackboard(anotherBlackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, anotherTeamOwner);

            Assert.IsFalse(blackboard1.Equals(blackboard2));
        }
    }
}
