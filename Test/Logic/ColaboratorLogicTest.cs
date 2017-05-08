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
    public class ColaboratorLogicTest
    {
        private Colaborator colaborator;
        private SystemList systemList;
        private ColaboratorPersistenceHandler colaboratorPersistence;
        private ColaboratorHandler colaboratorHandler;

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
            string name = "Joaquin";
            colaborator.name = name;

            Assert.AreEqual(name, colaborator.name);

        }
        [TestMethod]
        public void ColaboratorOKSurname()
        {
            colaborator = new Colaborator();
            string surname = "Oribe";
            colaborator.surname = surname;

            Assert.AreEqual(surname, colaborator.surname);

        }
        [TestMethod]
        public void ColaboratorOK()
        {
            colaborator = new Colaborator();
            colaborator.name = "Joaquin";

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

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

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;

            colaboratorHandler.AddColaborator(colaborator);

        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
        public void ColaboratorNullName()
        {
            colaborator = new Colaborator();

            colaborator.name = null;

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;

            colaboratorHandler.AddColaborator(colaborator);

        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
        public void ColaboratorNameWithSpacesInTheEnd()
        {
            colaborator = new Colaborator();
            colaborator.name = "Joaco      ";

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
        public void ColaboratorNameWithSpacesInTheBegining()
        {
            colaborator = new Colaborator();
            colaborator.name = "     Joaco";

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
        public void ColaboratorNameWithOnlyEmptySpaces()
        {
            colaborator = new Colaborator();
            colaborator.name = "     ";

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
        public void ColaboratorNameWithNumbers()
        {
            colaborator = new Colaborator();
            colaborator.name = "J04c0";

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
        public void ColaboratorNameWithSpecialCharacters()
        {
            colaborator = new Colaborator();
            colaborator.name = "#Jo@co";

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }

        [TestMethod]
        [ExpectedException(typeof(ColaboratorException))]
        public void ColaboratorNameWithMoreThanOneSpaceInTheMiddle()
        {
            colaborator = new Colaborator();
            colaborator.name = "Joaco   Sabe";

            colaborator.surname = "Oribe";

            colaborator.mail = "joacooribe@gmail.com";

            colaborator.password = "1234";

            colaborator.birthday = DateTime.Now;
            colaboratorHandler.AddColaborator(colaborator);
        }


    }
}
