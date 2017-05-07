using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test.Domain
{

    [TestClass]
    public class ColaboratorTest
    {
        private Colaborator colaborator1;
        private Colaborator colaborator2;

        public ColaboratorTest()
        {

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
        public void ColaboratorSameEmail()
        {
            colaborator1 = new Colaborator();
            colaborator1.name = "Diego";
            colaborator1.surname = "Balbi";
            colaborator1.mail = "diegobalbi1993@gmail.com";
            colaborator1.password = "12345";
            colaborator1.birthday = DateTime.Today;

            colaborator2 = new Colaborator();
            colaborator2.name = "Joaquin";
            colaborator2.surname = "Oribe";
            colaborator2.mail = "diegobalbi1993@gmail.com";
            colaborator2.password = "1234";
            colaborator2.birthday = DateTime.Today;

            Assert.IsTrue(colaborator1.Equals(colaborator2));
        }

        [TestMethod]
        public void ColaboratorDifferentEmail()
        {
            colaborator1 = new Colaborator();
            colaborator1.name = "Diego";
            colaborator1.surname = "Balbi";
            colaborator1.mail = "diegobalbi1993@gmail.com";
            colaborator1.password = "12345";
            colaborator1.birthday = DateTime.Today;

            colaborator2 = new Colaborator();
            colaborator2.name = "Joaquin";
            colaborator2.surname = "Oribe";
            colaborator2.mail = "joacooribe@gmail.com";
            colaborator2.password = "1234";
            colaborator2.birthday = DateTime.Today;

            Assert.IsFalse(colaborator1.Equals(colaborator2));
        }
    }
}
