using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;


namespace Test
{

    [TestClass]
    public class TextBoxTest
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

        private TextBox textBox;
        private TextBox anotherTextBox;
        private readonly int widthOk = 10;
        private readonly int heightOk = 12;
        private readonly int originPointOk = 0;
        private readonly string contentOk = "This is an example";
        private readonly string fontOk = "Times New Roman";
        private readonly int fontSizeOk = 14;

        private Repository systemList;
        private TextBoxPersistanceHandler textBoxPersistence;
        private TextBoxHandler textBoxHandler;

        public TextBoxTest()
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
        public void TextBoxSameIdAndSameBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            textBoxHandler.AddElement(textBox);

            anotherTextBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            anotherTextBox.id = textBox.id;

            Assert.IsTrue(textBox.Equals(anotherTextBox));        
        }

        [TestMethod]
        public void TextBoxDifferentIdAndSameBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            textBoxHandler.AddElement(textBox);

            anotherTextBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            textBoxHandler.AddElement(anotherTextBox);

            Assert.IsFalse(textBox.Equals(anotherTextBox));
        }

        [TestMethod]
        public void TextBoxSameIdAndDifferentBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);
            anotherBlackboardOwner = DataCreation.CreateBlackboard(anotherBlackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            textBoxHandler.AddElement(textBox);

            anotherTextBox = DataCreation.CreateTextBox(administratorCreator, anotherBlackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            anotherTextBox.id = textBox.id;

            Assert.IsFalse(textBox.Equals(anotherTextBox));
        }


        [TestMethod]
        public void TextBoxDifferentIdAndDifferentBlackboard()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);
            anotherBlackboardOwner = DataCreation.CreateBlackboard(anotherBlackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            textBox = DataCreation.CreateTextBox(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            textBoxHandler.AddElement(textBox);

            anotherTextBox = DataCreation.CreateTextBox(administratorCreator, anotherBlackboardOwner, widthOk, heightOk, originPointOk, contentOk, fontOk, fontSizeOk);
            textBoxHandler.AddElement(anotherTextBox);

            Assert.IsFalse(textBox.Equals(anotherTextBox));
        }
    }
}
