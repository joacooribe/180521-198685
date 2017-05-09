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
        Administrator administrator;
        private SystemList systemList;
        private AdministratorPersistenceHandler administratorPersistence;
        private AdministratorHandler administratorHandler;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        public AdministratorLogicTest()
        {
            systemList = new SystemList();
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

        [TestMethod]
        public void AdminisitratorOK()
        {
            administrator = new Administrator();

            administrator.name = "Joaquin";

            administrator.surname = "Oribe";

            administrator.mail = "joacooribe@gmail.com";

            administrator.password = "1234";

            administrator.birthday = DateTime.Now;

            administratorPersistence.AddAdministrator(administrator);
            Assert.AreEqual(1, systemList.administratorList.Count);

        }
        [TestMethod]
        [ExpectedException(typeof(AdministratorException))]
        public void AdministratorEmptyName()
        {
            administrator = new Administrator();
            administrator.name = "";

            administrator.surname = "Oribe";

            administrator.mail = "joacooribe@gmail.com";

            administrator.password = "1234";

            administrator.birthday = DateTime.Now;

            administratorHandler.AddAdministrator(administrator);

        }


        [TestMethod]
        [ExpectedException(typeof(AdministratorException))]
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNameWithSpacesInTheEnd()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNameWithSpacesInTheBegining()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNameWithOnlyEmptySpaces()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNameWithNumbers()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNameWithSpecialCharacters()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNameWithMoreThanOneSpaceInTheMiddle()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorEmptySurname()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNullSurname()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorSurnameWithSpacesInTheEnd()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorSurnameWithSpacesInTheBegining()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorSurnameWithOnlyEmptySpaces()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorSurnameWithNumbers()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorSurnameWithSpecialCharacters()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorSurnameWithMoreThanOneSpaceInTheMiddle()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorPasswordNull()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorPasswordEmpty()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorPasswordNoNumbers()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorPasswordNoLetters()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorPasswordTooSmall()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorEmptyMail()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorNullMail()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorMailWithNoAt()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorMailNoDot()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorMailNoAddres()
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
        [ExpectedException(typeof(AdministratorException))]
        public void administratorMailNoName()
        {
            administrator = new Administrator();
            administrator.name = nameOK;

            administrator.surname = surnameOK;

            administrator.mail = "@gmail.com";

            administrator.password = passwordOK;

            administrator.birthday = DateTime.Now;
            administratorHandler.AddAdministrator(administrator);
        }


    }
}
