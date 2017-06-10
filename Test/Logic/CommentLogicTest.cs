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
        private readonly string commentDescriptionOk = "This is the description of the comment";

        private Image image;
        private TextBox textBox;
        private readonly int imageWidthOk = 10;
        private readonly int imageHeightOk = 12;
        private readonly int originPointOk = 0;
        private readonly string formatOk = ".jpg";
        private readonly string urlOk = "/image/hola.jpg";
        private readonly string contentOk = "This is an example";
        private readonly string fontOk = "Times New Roman";
        private readonly int fontSizeOk = 14;

        private ICommentPersistance commentPersistence;
        private ICommentHandler commentHandler;

        public CommentLogicTest()
        {
            commentPersistence = new CommentPersistanceHandler();
            commentHandler = new CommentHandler();
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
        public void CommentOkCreatedByColaboratorForImage()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, anotherUserMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, colaboratorCreator, teamOwner);

            image = DataCreation.CreateImage(administratorCreator, blackboard, imageWidthOk, imageHeightOk, originPointOk, urlOk, formatOk);

            comment = DataCreation.CreateComment(commentDescriptionOk, creationDateOk, colaboratorCreator, image);

            commentHandler.AddComment(comment);

            Assert.AreEqual(commentDescriptionOk,comment.description);
        }

        [TestMethod]
        public void CommentOkCreatedByAdministratorForTextBox()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboard, imageWidthOk, imageHeightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            comment = DataCreation.CreateComment(commentDescriptionOk, creationDateOk, administratorCreator, textBox);

            commentHandler.AddComment(comment);

            Assert.AreEqual(commentDescriptionOk, comment.description);
        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void CommentInvaliCreationDate()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboard, imageWidthOk, imageHeightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            DateTime invalidDate = new DateTime(2018, 10, 5);

            comment = DataCreation.CreateComment(commentDescriptionOk, invalidDate, administratorCreator, textBox);

            commentHandler.AddComment(comment);
        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void CommentDescriptionEmpty()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboard, imageWidthOk, imageHeightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            string invalidDescription = "";

            comment = DataCreation.CreateComment(invalidDescription, creationDateOk, administratorCreator, textBox);

            commentHandler.AddComment(comment);
        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void CommentDescriptionNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboard, imageWidthOk, imageHeightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            string invalidDescription = null;

            comment = DataCreation.CreateComment(invalidDescription, creationDateOk, administratorCreator, textBox);

            commentHandler.AddComment(comment);
        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void CommentDescriptionInvalidSize()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboard, imageWidthOk, imageHeightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            string invalidDescription = "This is an invalid size of description because it is to long, only accept 50 characters";

            comment = DataCreation.CreateComment(invalidDescription, creationDateOk, administratorCreator, textBox);

            commentHandler.AddComment(comment);
        }

        [TestMethod]
        [ExpectedException(typeof(CommentException))]
        public void CommentUserCreatorNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboard = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, heightOk, widthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboard, imageWidthOk, imageHeightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            comment = DataCreation.CreateComment(commentDescriptionOk, creationDateOk, null, textBox);

            commentHandler.AddComment(comment);
        }
    }
}
