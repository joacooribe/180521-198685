using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{

    [TestClass]
    public class TeamTest
    {
        private Team team;
        private Team anotherTeam;
        private readonly string nameOK = "Team 1";
        private readonly string anotherNameOK = "Team 2";
        private readonly DateTime dateOK = DateTime.Now;
        private readonly string descriptionOK = "this is team 1";
        private readonly int maxUsersOK = 5;
        private ICollection<User> usersInTeam;

        private Administrator administratorCreator;
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userPasswordOK = "securePassword123";
        private readonly string userMailOK = "user@gmail.com";
        private readonly DateTime userBirthdayOk = new DateTime(1992, 9, 10);

        public TeamTest()
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
        public void TeamSameName()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();

            usersInTeam.Add(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            anotherTeam = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            Assert.IsTrue(team.Equals(anotherTeam));
        }

        [TestMethod]
        public void TeamDifferentName()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();

            usersInTeam.Add(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            anotherTeam = DataCreation.CreateTeam(anotherNameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            Assert.IsFalse(team.Equals(anotherTeam));
        }

        [TestMethod]
        public void TeamNull()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();

            usersInTeam.Add(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            anotherTeam = null;

            Assert.IsFalse(team.Equals(anotherTeam));
        }
    }
}
