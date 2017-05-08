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
           administrator1 = new Administrator();
            administrator1.name = "Diego";
            administrator1.surname = "Balbi";
            administrator1.mail = "diegobalbi1993@gmail.com";
            administrator1.password = "12345";
            administrator1.birthday = DateTime.Today;

            administrator2 = new Administrator();
            administrator2.name = "Joaquin";
            administrator2.surname = "Oribe";
            administrator2.mail = "diegobalbi1993@gmail.com";
            administrator2.password = "1234";
            administrator2.birthday = DateTime.Today;

            Assert.IsTrue(administrator1.Equals(administrator2));
        }

        [TestMethod]
        public void ColaboratorDifferentEmail()
        {
            administrator1 = new Administrator();
            administrator1.name = "Diego";
            administrator1.surname = "Balbi";
            administrator1.mail = "diegobalbi1993@gmail.com";
            administrator1.password = "12345";
            administrator1.birthday = DateTime.Today;

            administrator2 = new Administrator();
            administrator2.name = "Joaquin";
            administrator2.surname = "Oribe";
            administrator2.mail = "joacooribe@gmail.com";
            administrator2.password = "1234";
            administrator2.birthday = DateTime.Today;

            Assert.IsFalse(administrator1.Equals(administrator2));
        }
    }
}
