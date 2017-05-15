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
    public class CommentLogicTest
    {

        private Colaborator colaboratorCreator;
        private Administrator administratorCreator;
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userMailOK = "user@gmail.com";
        private readonly string anotherUserMailOK = "anotherUser@gmail.com";
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

        private Comment comment;
        private DateTime creationDateOk = new DateTime(2017, 3, 3);
        private DateTime resolvedDate;
        private User userCreator;
        private User userSolver;
        private readonly bool commentResolved;
        private readonly string commentDescriptionOk = "This is the description of the comment";

        public CommentLogicTest()
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
        public void commentOkCreatedByColaborator()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, anotherUserMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, colaboratorCreator, teamOwner);

            comment = DataCreation.CreateComment(commentDescriptionOk, creationDateOk, colaboratorCreator);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void commentOkCreatedByAdministrator()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            comment = DataCreation.CreateComment(commentDescriptionOk, creationDateOk, administratorCreator);

            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void commentInvaliCreationDate()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void commentInvaliResolvedDate()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void commentDescriptionNull()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void commentDescriptionEmpty()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void commentDescriptionInvalidSize()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void commentUserCreatorNull()
        {

        }

    }
}
