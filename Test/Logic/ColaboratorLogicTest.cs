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
        private Repository systemList;
        private ColaboratorPersistenceHandler colaboratorPersistence;
        private ColaboratorHandler colaboratorHandler;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";


        public ColaboratorLogicTest()
        {
            systemList = new Repository();
            colaboratorPersistence = new ColaboratorPersistenceHandler(systemList);
            colaboratorHandler = new ColaboratorHandler() { colaboratorFunctions = colaboratorPersistence };
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
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;

            colaboratorHandler.AddColaborator(colaborator);
            Assert.AreEqual(colaborator, colaboratorHandler.colaboratorFunctions.GetColaboratorFromColecction(colaborator));

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorEmptyName()
        {
            colaborator = new Colaborator();
            colaborator.name = "";

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;

            colaboratorHandler.AddColaborator(colaborator);

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNullName()
        {
            colaborator = new Colaborator();

            colaborator.name = null;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;

            colaboratorHandler.AddColaborator(colaborator);

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithSpacesInTheEnd()
        {
            colaborator = new Colaborator();
            colaborator.name = "Joaco      ";

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithSpacesInTheBegining()
        {
            colaborator = new Colaborator();
            colaborator.name = "     Joaco";

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithOnlyEmptySpaces()
        {
            colaborator = new Colaborator();
            colaborator.name = "     ";

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithNumbers()
        {
            colaborator = new Colaborator();
            colaborator.name = "J04c0";

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithSpecialCharacters()
        {
            colaborator = new Colaborator();
            colaborator.name = "#Jo@co";

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNameWithMoreThanOneSpaceInTheMiddle()
        {
            colaborator = new Colaborator();
            colaborator.name = "Joaco   Sabe";

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorEmptySurname()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = "";

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;

            colaboratorHandler.AddColaborator(colaborator);

        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNullSurname()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = null;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;

            colaboratorHandler.AddColaborator(colaborator);

        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithSpacesInTheEnd()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = "Oribe     ";

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithSpacesInTheBegining()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = "           Oribe";

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithOnlyEmptySpaces()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = "     ";

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithNumbers()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = "0rib3";

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithSpecialCharacters()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = "#@?_";

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorSurnameWithMoreThanOneSpaceInTheMiddle()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = "Oribe   Bajac";

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordNull()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = null;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordEmpty()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = "";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordNoNumbers()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = "ThisIsPassword";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordNoLetters()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = "123456789";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorPasswordTooSmall()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = "pass1";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorEmptyMail()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = "";

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorNullMail()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = null;

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailWithNoAt()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = "joacooribegmail.com";

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailNoDot()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = "joaco@gmailcom";

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailNoAddres()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = "joaco@.com";

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }
        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorMailNoName()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = "@gmail.com";

            colaborator.password = passwordOK;

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void ColaboratorInvalidBirthDate()
        {
            colaborator = new Colaborator();
            colaborator.name = nameOK;

            colaborator.surname = surnameOK;

            colaborator.mail = mailOK;

            colaborator.password = passwordOK;

            colaborator.birthday = new DateTime(9999,1,1);

            colaboratorHandler.AddColaborator(colaborator);

        }


    }
}
