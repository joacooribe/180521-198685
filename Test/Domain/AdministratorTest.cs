using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
namespace Test.Domain
{

    [TestClass]
    public class AdministratorTest
    {
        private Administrator administrator1;
        private Administrator administrator2;
        public AdministratorTest()
        {
  
        }

        private TestContext testContextInstance;
        
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        private readonly string mailOK = "user@gmail.com";
        private readonly string anotherMailOK = "pepito@gmail.com";
        private readonly string passwordOK = "securePassword123";
        private readonly DateTime birthdayOk = new DateTime(1992, 9, 10);

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
        public void AdministratorSameEmail()
        {
            administrator1 = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            administrator2 = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            Assert.IsTrue(administrator1.Equals(administrator2));
        }

        [TestMethod]
        public void AdministratorDifferentEmail()
        {
            administrator1 = DataCreation.CreateAdministrator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            administrator2 = DataCreation.CreateAdministrator(nameOK, surnameOK, anotherMailOK, passwordOK, birthdayOk);

            Assert.IsFalse(administrator1.Equals(administrator2));
        }
    }
}
