using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Persistence;
using Logic;
using Exceptions;

namespace Test
{

    [TestClass]
    public class SessionTest
    {
        private ISessionHandler sessionHandler;
        private Administrator administrator;
        private IAdministratorPersistance administratorPersistence;
        private IAdministratorHandler administratorHandler;
        private Colaborator colaborator;
        private IColaboratorPersistance colaboratorPersistence;
        private IColaboratorHandler colaboratorHandler;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        private readonly DateTime birthdayOk = new DateTime(1992, 9, 10);

        public SessionTest()
        {
            sessionHandler = new SessionHandler();
            administratorPersistence = new AdministratorPersistenceHandler();
            administratorHandler = new AdministratorHandler();
            colaboratorPersistence = new ColaboratorPersistenceHandler();
            colaboratorHandler = new ColaboratorHandler();
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
        public void AdministratorLoginOk()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);

            Session actualSession = sessionHandler.LogInAdministrator(administrator.mail, administrator.password);
            Assert.AreEqual(administrator, actualSession.user);
            administratorPersistence.EmptyAdministrators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorLoginWrongPassword()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);

            string invalidPassword = "invalid";

            sessionHandler.LogInAdministrator(administrator.mail, invalidPassword);
            administratorPersistence.EmptyAdministrators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorLoginWrongMail()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);

            string invalidMail = "invalidMail";

            sessionHandler.LogInAdministrator(invalidMail, administrator.mail);
            administratorPersistence.EmptyAdministrators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorLoginUserNotExist()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);

            string notExistUser = "diego@gmail.com";

            sessionHandler.LogInAdministrator(notExistUser, administrator.mail);
            administratorPersistence.EmptyAdministrators();
        }

        [TestMethod]
        public void ColaboratorLoginOk()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            colaboratorHandler.AddColaborator(colaborator);

            Session actualSession = sessionHandler.LogInColaborator(colaborator.mail, colaborator.password);
            Assert.AreEqual(colaborator, actualSession.user);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorLoginWrongPassword()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            colaboratorHandler.AddColaborator(colaborator);

            string invalidPassword = "invalid";

            sessionHandler.LogInColaborator(colaborator.mail, invalidPassword);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorLoginWrongMail()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            colaboratorHandler.AddColaborator(colaborator);

            string invalidMail = "invalidMail";

            sessionHandler.LogInColaborator(invalidMail, colaborator.password);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorLoginUserNotExist()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            colaboratorHandler.AddColaborator(colaborator);

            string notExistUser = "diego@gmail.com";

            sessionHandler.LogInColaborator(notExistUser, colaborator.mail);
            colaboratorPersistence.EmptyColaborators();
        }
    }
}
