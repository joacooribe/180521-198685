using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Persistence;
using Exceptions;

namespace Test
{
    [TestClass]
    public class ColaboratorTest
    {
        private Colaborator colaborator;
        private SystemList systemList;
        private ColaboratorPersistenceHandler colaboratorPersistence;

        public ColaboratorTest()
        {
            systemList = new SystemList();
            colaboratorPersistence = new ColaboratorPersistenceHandler(systemList);
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

            Assert.AreEqual(name,colaborator.name ); 

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

            colaboratorPersistence.AddColaborator(colaborator);
            Assert.AreEqual(1,systemList.colaboratorList.Count);

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

            Utility.ValidateColaborator(colaborator);

        }
    }
}
