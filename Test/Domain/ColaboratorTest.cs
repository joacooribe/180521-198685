using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class ColaboratorTest
    {
        private Colaborator colaborator1;
        private Colaborator colaborator2;
        
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        private readonly string mailOK = "user@gmail.com";
        private readonly string anotherMailOK = "pepito@gmail.com";
        private readonly string passwordOK = "securePassword123";
        private readonly DateTime birthdayOk = new DateTime(1992, 9, 10);

        public ColaboratorTest()
        {

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
        public void ColaboratorSameEmail()
        {
            colaborator1 = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaborator2 = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            Assert.IsTrue(colaborator1.Equals(colaborator2));
        }

        [TestMethod]
        public void ColaboratorDifferentEmail()
        {
            colaborator1 = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaborator2 = DataCreation.CreateColaborator(nameOK, surnameOK, anotherMailOK, passwordOK, birthdayOk);

            Assert.IsFalse(colaborator1.Equals(colaborator2));
        }

        [TestMethod]
        public void ColaboratorNull()
        {
            colaborator1 = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            colaborator2 = null;

            Assert.IsFalse(colaborator1.Equals(colaborator2));
        }
    }
}
