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
    public class TextBoxLogicTest
    {
        private Colaborator colaboratorCreator;
        private Administrator administratorCreator;
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userMailOK = "user@gmail.com";
        private readonly string anotherUserMailOk = "admin@gmail.com";
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

        private TextBox textBox;
        private readonly int widthOk = 10;
        private readonly int heightOk = 12;
        private readonly int originPointOk = 0;
        private readonly string contentOk = "This is an example";
        private readonly string fontOk = "Times New Roman";
        private readonly int fontSizeOk = 14;

        private Repository systemList;
        private TextBoxPersistanceHandler textBoxPersistence;
        private TextBoxHandler textBoxHandler;

        public TextBoxLogicTest()
        {
            systemList = new Repository();
            textBoxPersistence = new TextBoxPersistanceHandler(systemList);
            textBoxHandler = new TextBoxHandler() { textBoxFunctions = textBoxPersistence };
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
        public void TextBoxOkCreatedByAdministrator()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);
            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);

            Assert.AreEqual(textBox,textBoxHandler.GetElementFromCollection(textBox.id,textBox.blackboardOwner));
        }

        [TestMethod]
        public void TextBoxOkCreatedByColaborator()
        {
            usersInTeam = new List<User>();

            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, anotherUserMailOk, userPasswordOK, userBirthdayOk);
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, colaboratorCreator, teamOwner);
            textBox = DataCreation.CreateTextBox(colaboratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);

            Assert.AreEqual(textBox, textBoxHandler.GetElementFromCollection(textBox.id, textBox.blackboardOwner));
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxWidthZero()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidWidth = 0;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, invalidWidth, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxWidthNegative()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidWidth = -1;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, invalidWidth, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxWidthGreaterThanBlackboardWidth()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidWidth = 100;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, invalidWidth, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxHeightZero()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidHeight= 0;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, invalidHeight, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxHeightNegative()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidHeight = -1;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, invalidHeight, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxHeightGreaterThanBlackboardHeight()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidHeight = 100;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, invalidHeight, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxOriginPointNegative()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidOriginPoint = -1;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, invalidOriginPoint, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxUserCreatorNotBelongingToTheTeam()
        {
            usersInTeam = new List<User>();

            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(colaboratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxBlackboardNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            textBox = DataCreation.CreateTextBox(administratorCreator, null, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void TextBoxUserOwnerNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(null, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(TextBoxException))]
        public void TextBoxContentNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidContent = null;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, invalidContent, fontOk, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(TextBoxException))]
        public void TextBoxFontSizeZero()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidFontSize = 0;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, invalidFontSize);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(TextBoxException))]
        public void TextBoxFontSizeNegativeNumber()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidFontSize = -1;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, invalidFontSize);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(TextBoxException))]
        public void TextBoxFontNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidFont = null;

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, invalidFont, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }

        [TestMethod]
        [ExpectedException(typeof(TextBoxException))]
        public void TextBoxFontEmpty()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidFont = "";

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, invalidFont, fontSizeOk);

            textBoxHandler.AddElement(textBox);
        }
    }
}
