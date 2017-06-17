using System;
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
    public class ColaboratorLogicTest
    {
        private Colaborator colaborator;
        private IColaboratorPersistance colaboratorPersistence;
        private IColaboratorHandler colaboratorHandler;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        private readonly DateTime birthdayOk = new DateTime(1992, 9, 10);

        public ColaboratorLogicTest()
        {
            colaboratorPersistence = new ColaboratorPersistenceHandler();
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
        public void ColaboratorOKName()
        {
            colaborator = new Colaborator();
            string name = nameOK;
            colaborator.name = name;

            Assert.AreEqual(name, colaborator.name);

        }
        [TestMethod]
        public void ColaboratorOKSurname()
        {
            colaborator = new Colaborator();
            string surname = surnameOK;
            colaborator.surname = surname;

            Assert.AreEqual(surname, colaborator.surname);

        }
        [TestMethod]
        public void ColaboratorOK()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);

            Assert.AreEqual(colaborator, colaboratorHandler.GetUserFromColecction(colaborator.mail));
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorEmptyName()
        {
            string invalidName = "";

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNullName()
        {
            string invalidName = null;

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithSpacesInTheEnd()
        {
            string invalidName = "Joaco      ";

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithSpacesInTheBegining()
        {
            string invalidName = "     Joaco";

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithOnlyEmptySpaces()
        {
            string invalidName = "     ";

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithNumbers()
        {
            string invalidName = "J04c0";

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithSpecialCharacters()
        {
            string invalidName = "#Jo@co";

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithMoreThanOneSpaceInTheMiddle()
        {
            string invalidName = "Joaco   Sabe";

            colaborator = DataCreation.CreateColaborator(invalidName, surnameOK, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorEmptySurname()
        {
            string invalidSurname = "";

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNullSurname()
        {
            string invalidSurname = null;

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithSpacesInTheEnd()
        {
            string invalidSurname = "Oribe     ";

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithSpacesInTheBegining()
        {
            string invalidSurname = "           Oribe";

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithOnlyEmptySpaces()
        {
            string invalidSurname = "     ";

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithNumbers()
        {
            string invalidSurname = "0rib3";

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithSpecialCharacters()
        {
            string invalidSurname = "#@?_";

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithMoreThanOneSpaceInTheMiddle()
        {
            string invalidSurname = "Oribe   Bajac";

            colaborator = DataCreation.CreateColaborator(nameOK, invalidSurname, mailOK, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordNull()
        {
            string invalidPassword = null;

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordEmpty()
        {
            string invalidPassword = "";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordNoNumbers()
        {
            string invalidPassword = "ThisIsPassword";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordNoLetters()
        {
            string invalidPassword = "123456789";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordTooSmall()
        {
            string invalidPassword = "pass1";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, invalidPassword, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorEmptyMail()
        {
            string invalidMail = "";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNullMail()
        {
            string invalidMail = null;

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailWithNoAt()
        {
            string invalidMail = "joacooribegmail.com";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailNoDot()
        {
            string invalidMail = "joaco@gmailcom";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailNoAddres()
        {
            string invalidMail = "joaco@.com";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailNoName()
        {
            string invalidMail = "@gmail.com";

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, invalidMail, passwordOK, birthdayOk);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorInvalidBirthDate()
        {
            DateTime invalidBirthday = new DateTime(9999,1,1);

            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, invalidBirthday);

            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        public void ColaboratorModification()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            colaboratorHandler.AddColaborator(colaborator);
            string newPassword = "NewPassword123";
            colaboratorHandler.ModifyPassword(colaborator.mail, newPassword);
            Assert.AreEqual(newPassword, colaborator.password);
            colaboratorPersistence.EmptyColaborators();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorInvalidModification()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            colaboratorHandler.AddColaborator(colaborator);
            string newPassword = "";
            colaboratorHandler.ModifyPassword(colaborator.mail, newPassword);
            colaboratorPersistence.EmptyColaborators();
        }

        [ExpectedException(typeof(UserException))]
        [TestMethod]
        public void AddTheSameColaborator()
        {
            colaborator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);
            colaboratorHandler.AddColaborator(colaborator);
            colaboratorHandler.AddColaborator(colaborator);
            colaboratorPersistence.EmptyColaborators();
        }
    }
}
