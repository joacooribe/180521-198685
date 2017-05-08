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
        private SystemList systemList;
        private ColaboratorPersistenceHandler colaboratorPersistence;
        private ColaboratorHandler colaboratorHandler;

        private readonly string passwordOK = "securePassword123";
        private readonly string mailOK = "user@gmail.com";
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";


        public ColaboratorLogicTest()
        {
            systemList = new SystemList();
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
            Assert.AreEqual(colaborator, colaboratorHandler.colaboratorFunctions.GetColaboratorFromList(colaborator));

        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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
        [ExpectedException(typeof(ColaboratorException))]
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


    }
}
