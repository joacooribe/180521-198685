using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;
using Exceptions;

namespace Test.Logic
{

    [TestClass]
    public class TeamLogicTest
    {
        private TeamPersistenceHandler teamPersistence;
        private TeamHandler teamHandler;
        private Repository systemList;
        private Team team;
        private Administrator administratoCreator;
        private Colaborator colaboratorCreator;

        private readonly string nameOK = "Team 1";
        private readonly DateTime dateOK = DateTime.Now;
        private readonly string descriptionOK = "this is team 1";
        private readonly int maxUsersOK = 5;
        
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userPasswordOK = "securePassword123";
        private readonly string userMailOK = "user@gmail.com";
        private readonly DateTime userBirthdayOk = new DateTime(1992, 9, 10);
        public TeamLogicTest()
        {
            systemList = new Repository();
            teamPersistence = new TeamPersistenceHandler(systemList);
            teamHandler = new TeamHandler() { teamFunctions = teamPersistence };
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
        public void TeamOKCreatedByColaborator()
        {
            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(colaboratorCreator);
            teamHandler.AddTeam(team);

            Assert.AreEqual(1,systemList.teamCollection.Count);
        }

        [TestMethod]
        public void TeamOKCreatedByAdministrator()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);
            teamHandler.AddTeam(team);

            Assert.AreEqual(1, systemList.teamCollection.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamEmptyName()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = "";
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNullName()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = null;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamEmptyDescription()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = "";
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNullDescription()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = null;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNoUsers()
        {
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamMaxUsersZero()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = 0;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamUsersOverMax()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = 1;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);
            team.usersInTeam.Add(colaboratorCreator);
            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamInvalidDate()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = new DateTime(2020, 1, 1);
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);
            teamHandler.AddTeam(team);

        }
        [TestMethod]
        public void TeamModificationOfMaxUsersOK()
        {
            administratoCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.usersInTeam = new List<User>();
            team.usersInTeam.Add(administratoCreator);
            teamHandler.AddTeam(team);
            int newMax = 10;
            teamHandler.ModifyMaxUsers(team.name,newMax);
            Assert.AreEqual(newMax,team.maxUsers);

        }

    }
}
