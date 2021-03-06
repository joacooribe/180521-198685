﻿using System;
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
        private IAdministratorHandler administratorHandler;
        private Colaborator colaborator;
        private IColaboratorHandler colaboratorHandler;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        private readonly DateTime birthdayOk = new DateTime(1992, 9, 10);

        public SessionTest()
        {
            sessionHandler = new SessionHandler();

            administratorHandler = new AdministratorHandler();

            colaboratorHandler = new ColaboratorHandler();
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
        public void AdministratorLoginOk()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);

            Session actualSession = sessionHandler.LogInAdministrator(administrator.mail, administrator.password);

            Assert.AreEqual(administrator.mail, actualSession.user.mail);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorLoginWrongPassword()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);

            string invalidPassword = "invalid";

            sessionHandler.LogInAdministrator(administrator.mail, invalidPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorLoginWrongMail()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);

            string invalidMail = "invalidMail";

            sessionHandler.LogInAdministrator(invalidMail, administrator.mail);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorLoginUserNotExist()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);

            string notExistUser = "diego@gmail.com";

            sessionHandler.LogInAdministrator(notExistUser, administrator.mail);
        }

        [TestMethod]
        public void ColaboratorLoginOk()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);

            Session actualSession = sessionHandler.LogInColaborator(colaborator.mail, colaborator.password);

            Assert.AreEqual(colaborator.mail, actualSession.user.mail);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorLoginWrongPassword()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);

            string invalidPassword = "invalid";

            sessionHandler.LogInColaborator(colaborator.mail, invalidPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorLoginWrongMail()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);

            string invalidMail = "invalidMail";

            sessionHandler.LogInColaborator(invalidMail, colaborator.password);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorLoginUserNotExist()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);

            string notExistUser = "diego@gmail.com";

            sessionHandler.LogInColaborator(notExistUser, colaborator.mail);
        }
    }
}
