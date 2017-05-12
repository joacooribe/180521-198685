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
    public class AdministratorLogicTest
    {
        private Administrator administrator;
        private Repository systemList;
        private AdministratorPersistenceHandler administratorPersistence;
        private AdministratorHandler administratorHandler;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        public AdministratorLogicTest()
        {
            systemList = new Repository();
            administratorPersistence = new AdministratorPersistenceHandler(systemList);
            administratorHandler = new AdministratorHandler() { administratorFunctions = administratorPersistence };
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
        public void AdminOKName()
        {
            administrator = new Administrator();
            string name = "Joaquin";
            administrator.name = name;
            Assert.AreEqual(name, administrator.name);

        }
        private Administrator CreateAdministrator()
        {
            Administrator administrator = new Administrator();
            administrator.name = nameOK;
            administrator.surname = surnameOK;
            administrator.mail = mailOK;
            administrator.password = passwordOK;
            administrator.birthday = DateTime.Now;
            return administrator;

        }
        [TestMethod]
        public void AdminisitratorOK()
        {
            administrator = CreateAdministrator();
            administratorPersistence.AddAdministrator(administrator);
            Assert.AreEqual(administrator, administratorHandler.administratorFunctions.GetUserFromColecction(administrator.mail));

        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorEmptyName()
        {
            administrator = new Administrator();
            administrator.name = "";

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;

            administratorHandler.AddAdministrator(administrator);

        }


        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNullName()
        {
            administrator = new Administrator();

            administrator.name = null;

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;

            administratorHandler.AddAdministrator(administrator);

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithSpacesInTheEnd()
        {
            administrator = new Administrator();
            administrator.name = "Joaco      ";

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithSpacesInTheBegining()
        {
            administrator = new Administrator();
            administrator.name = "     Joaco";

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithOnlyEmptySpaces()
        {
            administrator = new Administrator();
            administrator.name = "     ";

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithNumbers()
        {
            administrator = new Administrator();
            administrator.name = "J04c0";

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithSpecialCharacters()
        {
            administrator = new Administrator();
            administrator.name = "#Jo@co";

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNameWithMoreThanOneSpaceInTheMiddle()
        {
            administrator = new Administrator();
            administrator.name = "Joaco   Sabe";

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorEmptySurname()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = "";

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;

            administratorHandler.AddAdministrator(administrator);

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNullSurname()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = null;

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;

            administratorHandler.AddAdministrator(administrator);

        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithSpacesInTheEnd()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = "Oribe     ";

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithSpacesInTheBegining()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = "           Oribe";

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithOnlyEmptySpaces()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = "     ";

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithNumbers()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = "0rib3";

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithSpecialCharacters()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = "#@?_";

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorSurnameWithMoreThanOneSpaceInTheMiddle()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = "Oribe   Bajac";

            administrator.mail = mailOK;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordNull()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = null;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordEmpty()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = "";

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordNoNumbers()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = "ThisIsPassword";

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordNoLetters()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = "123456789";

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorPasswordTooSmall()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = mailOK;

            administrator.password = "pass1";

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorEmptyMail()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = "";

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorNullMail()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = null;

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailWithNoAt()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = "joacooribegmail.com";

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailNoDot()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = "joaco@gmailcom";

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailNoAddres()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = "joaco@.com";

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorMailNoName()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = "@gmail.com";

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void AdministratorInvalidBirthDate()
        {
            administrator = new Administrator();
            administrator.name = nameOK;
            administrator.surname = surnameOK;
            administrator.mail = mailOK;
            administrator.password = passwordOK;
            administrator.birthday = new DateTime(9999,1,1);
            administratorHandler.AddAdministrator(administrator);
        }

        [TestMethod]
        public void AdministratorModification()
        {
            administrator = CreateAdministrator();
            administratorHandler.AddAdministrator(administrator);
            string newPassword = "NewPassword123";
            administratorHandler.ModifyPassword(administrator.mail, newPassword);
            Assert.AreEqual(newPassword,administrator.password);

        }


    }
}
