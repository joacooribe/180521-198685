using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;
using Exceptions;

namespace Test
{
    [TestClass]
    public class TeamLogicTest
    {
        private ITeamPersistance teamPersistence;
        private ITeamHandler teamHandler;
        private IAdministratorHandler administratorHandler;
        private Team team;
        private Administrator administratorCreator;
        private Colaborator colaboratorCreator;

        private readonly string nameOK = "Team 1";
        private readonly DateTime dateOK = DateTime.Now;
        private readonly string descriptionOK = "this is team 1";
        private readonly int maxUsersOK = 5;
        private ICollection<User> usersInTeam;

        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userPasswordOK = "securePassword123";
        private readonly string userMailOK = "user@gmail.com";
        private readonly string anotherUserMailOK = "user1@gmail.com";
        private readonly DateTime userBirthdayOk = new DateTime(1992, 9, 10);

        public TeamLogicTest()
        {
            teamPersistence = new TeamPersistenceHandler();
            teamHandler = new TeamHandler();
            administratorHandler = new AdministratorHandler();
        }

        [TestInitialize]
        public void TestSetUp()
        {
            ContextDB context = new ContextDB();
            context.EmptyTable();
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
        public void TeamOKCreatedByAdministrator()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
           
            usersInTeam = new List<User>();

            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);

            Assert.IsTrue(teamPersistence.ExistsTeam(teamHandler.GetTeamFromCollection(team.name)));
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamEmptyName()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            string invalidName = "";

            team = DataCreation.CreateTeam(invalidName, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNullName()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            string invalidName = null;

            team = DataCreation.CreateTeam(invalidName, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamEmptyDescription()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            string invalidDescription = "";

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, invalidDescription, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNullDescription()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            string invalidDescription = null;

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, invalidDescription, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamNoUsers()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamMaxUsersZero()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            int invalidMaxUsers = 0;

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, invalidMaxUsers, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamUsersOverMax()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);
            usersInTeam.Add(colaboratorCreator);

            int maxUsers = 1;

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsers , usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamInvalidDate()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            DateTime invalidCreationDate = new DateTime(2020, 1, 1);

            team = DataCreation.CreateTeam(nameOK, invalidCreationDate, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        public void TeamModificationOfMaxUsersOK()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            int newMax = 10;
            teamHandler.ModifyTeamMaxUsers(team.name,newMax);

            Assert.AreEqual(newMax,teamHandler.GetTeamFromCollection(team.name).maxUsers);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamInvalidModificationOfMaxUsers()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            int newMax = 0;
            teamHandler.ModifyTeamMaxUsers(team.name, newMax);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamInvalidModificationOfMaxUsersNegative()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            int newMax = -1;
            teamHandler.ModifyTeamMaxUsers(team.name, newMax);
        }

        [TestMethod]
        public void TeamModificationOfDescriptionOK()
        {
            teamPersistence.EmptyTeams();
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            string newDescription = "This is a new description";
            teamHandler.ModifyTeamDescription(team.name, newDescription);
            
            Assert.AreEqual(newDescription, teamHandler.GetTeamFromCollection(team.name).description);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamInvalidModificationOfDescriptionSize()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            string newDescription = "This is an invalid description size it passes the limit of 50 characters.";
            teamHandler.ModifyTeamDescription(team.name, newDescription);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamInvalidModificationOfDescriptionNull()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            string newDescription = null;
            teamHandler.ModifyTeamDescription(team.name, newDescription);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamUserCollectionNull()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = null;

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void AddTheSameTeam()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            teamHandler.AddTeam(team);
        }

        [TestMethod]
        public void TeamRemoveUserOk()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            Administrator administrator1 = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, anotherUserMailOK, userPasswordOK, userBirthdayOk);
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);
            usersInTeam.Add(administrator1);

            administratorHandler.AddAdministrator(administratorCreator);
            administratorHandler.AddAdministrator(administrator1);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            teamHandler.RemoveUser(team, administrator1);
            
            Assert.IsFalse(teamHandler.GetTeamFromCollection(team.name).usersInTeam.Contains(administrator1));
        }

        [TestMethod]
        [ExpectedException(typeof(TeamException))]
        public void TeamRemoveUserNull()
        {
            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);
            Administrator administrator1 = null;
            usersInTeam = new List<User>();
            usersInTeam.Add(administratorCreator);

            administratorHandler.AddAdministrator(administratorCreator);

            team = DataCreation.CreateTeam(nameOK, dateOK, administratorCreator, descriptionOK, maxUsersOK, usersInTeam);

            teamHandler.AddTeam(team);
            teamHandler.RemoveUser(team, administrator1);
        }

    }
}
