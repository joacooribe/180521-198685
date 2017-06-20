﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Persistence;
using Exceptions;
using Logic;



namespace Test
{
    [TestClass]
    public class AdministratorLogicTest
    {
        private Administrator administrator;
        private IAdministratorHandler administratorHandler;
        private IUserHandler userHandler;
        private IUserPersistance userPersistance;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        private readonly DateTime birthdayOk = new DateTime(1992, 9, 10);

        public AdministratorLogicTest()
        {
            administratorHandler = new AdministratorHandler();
            userHandler = new UserHandler();
            userPersistance = new UserPersistanceHandler();
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
        public void AdminOKName()
        {
            administrator = new Administrator();
            string name = "Joaquin";
            administrator.name = name;
            Assert.AreEqual(name, administrator.name);
        }

        [TestMethod]
        public void AdminisitratorOK()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);
            Assert.IsTrue(userPersistance.ExistsUser(userHandler.GetUserFromColecction(administrator.mail)));
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorEmptyName()
        {
            string invalidName = "";

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
        }


        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNullName()
        {
            string invalidName = null;

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithSpacesInTheEnd()
        {
            string invalidName = "Joaco     ";

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithSpacesInTheBegining()
        {
            string invalidName = "     Joaco";

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);
            
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithOnlyEmptySpaces()
        {
            string invalidName = "     ";

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithNumbers()
        {
            string invalidName = "J04c0";

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithSpecialCharacters()
        {
            string invalidName = "#Jo@co";

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithMoreThanOneSpaceInTheMiddle()
        {
            string invalidName = "Joaco   Sabe";

            administrator = DataCreation.CreateAdministrator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorEmptySurname()
        {
            string invalidSurname = "";

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNullSurname()
        {
            string invalidSurname = null;

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithSpacesInTheEnd()
        {
            string invalidSurname = "Oribe     ";

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithSpacesInTheBegining()
        {
            string invalidSurname = "           Oribe";

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithOnlyEmptySpaces()
        {
            string invalidSurname = "     ";

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithNumbers()
        {
            string invalidSurname = "0rib3";

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithSpecialCharacters()
        {
            string invalidSurname = "#@?_";

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithMoreThanOneSpaceInTheMiddle()
        {
            string invalidSurname = "Oribe   Bajac";

            administrator = DataCreation.CreateAdministrator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordNull()
        {
            string invalidPassword = null;

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordEmpty()
        {
            string invalidPassword = "";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordNoNumbers()
        {
            string invalidPassword = "ThisIsPassword";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordNoLetters()
        {
            string invalidPassword = "123456789";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordTooSmall()
        {
            string invalidPassword = "pass1";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorEmptyMail()
        {
            string invalidMail = "";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNullMail()
        {
            string invalidMail = null;

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailWithNoAt()
        {
            string invalidMail = "joacooribegmail.com";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailNoDot()
        {
            string invalidMail = "joaco@gmailcom";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailNoAddres()
        {
            string invalidMail = "joaco@.com";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailNoName()
        {
            string invalidMail = "@gmail.com";

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorInvalidBirthDate()
        {
            DateTime invalidBirthday = new DateTime(9999,1,1);

            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, invalidBirthday);

            administratorHandler.AddAdministrator(administrator);
            
        }

        [TestMethod]
        public void AdministratorModification()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);
            string newPassword = "NewPassword123";
            userHandler.ModifyPassword(administrator.mail, newPassword);
            Assert.AreEqual(newPassword,userHandler.GetUserFromColecction(administrator.mail).password);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorInvalidModification()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);
            string newPassword = "";
            userHandler.ModifyPassword(administrator.mail, newPassword);
        }

        [ExpectedException(typeof(UserException))]
        [TestMethod]
        public void AddTheSameAdministrator()
        {
            administrator = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            administratorHandler.AddAdministrator(administrator);
            administratorHandler.AddAdministrator(administrator);
            
        }
    }
}
