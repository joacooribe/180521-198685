using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Persistence;

namespace Test
{

    [TestClass]
    public class AdministratorTest
    {
        Administrator administrator;
        private SystemList systemList;
        private AdministratorPersistenceHandler administratorPersistence;
        public AdministratorTest()
        {
            systemList = new SystemList();
            administratorPersistence = new AdministratorPersistenceHandler(systemList);
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
    }
}
