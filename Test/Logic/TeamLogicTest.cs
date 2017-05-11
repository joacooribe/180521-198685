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

        private readonly string nameOK = "Team 1";
        private readonly DateTime dateOK = DateTime.Now;
        private readonly string descriptionOK = "this is team 1";
        private readonly int maxUsersOK = 5;
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
        private Colaborator CreateColaborator()
        {
           Colaborator creator = new Colaborator();
            creator.name = "Joaquin";
            creator.surname = "Oribe";
            creator.mail = "Hola@gmail.com";
            creator.password = "a1234556";
            creator.birthday = DateTime.Now;
            return creator;
        }
        private Administrator CreateAdministrator()
        {
            Administrator creator = new Administrator();
            creator.name = "Joaquin";
            creator.surname = "Oribe";
            creator.mail = "Hola@gmail.com";
            creator.password = "a1234556";
            creator.birthday = DateTime.Now;
            return creator;

        }
        [TestMethod]
        public void TeamOKCreatedByColaborator()
        {
            Colaborator creator = CreateColaborator();
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.userList = new List<User>();
            team.userList.Add(creator);
            teamHandler.AddTeam(team);

            Assert.AreEqual(1,systemList.teamList.Count);
        }

        [TestMethod]
        public void TeamOKCreatedByAdministrator()
        {
            Administrator creator = CreateAdministrator();
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.userList = new List<User>();
            team.userList.Add(creator);
            teamHandler.AddTeam(team);

            Assert.AreEqual(1, systemList.teamList.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamEmptyName()
        {
            Administrator creator = CreateAdministrator();
            team = new Team();
            team.name = "";
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.userList = new List<User>();
            team.userList.Add(creator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNullName()
        {
            Administrator creator = CreateAdministrator();
            team = new Team();
            team.name = null;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.userList = new List<User>();
            team.userList.Add(creator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamEmptyDescription()
        {
            Administrator creator = CreateAdministrator();
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = "";
            team.maxUsers = maxUsersOK;
            team.userList = new List<User>();
            team.userList.Add(creator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNullDescription()
        {
            Administrator creator = CreateAdministrator();
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = null;
            team.maxUsers = maxUsersOK;
            team.userList = new List<User>();
            team.userList.Add(creator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNoUsers()
        {
            Administrator creator = CreateAdministrator();
            team = new Team();
            team.name = null;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = maxUsersOK;
            team.userList = new List<User>();

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamMaxUsersZero()
        {
            Administrator creator = CreateAdministrator();
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = 0;
            team.userList = new List<User>();
            team.userList.Add(creator);

            teamHandler.AddTeam(team);
        }
        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamUsersOverMax()
        {
            Administrator creator = CreateAdministrator();
            Colaborator colaborator = CreateColaborator();
            team = new Team();
            team.name = nameOK;
            team.creationDate = dateOK;
            team.description = descriptionOK;
            team.maxUsers = 1;
            team.userList = new List<User>();
            team.userList.Add(creator);
            team.userList.Add(colaborator);
            teamHandler.AddTeam(team);
        }


    }
}
