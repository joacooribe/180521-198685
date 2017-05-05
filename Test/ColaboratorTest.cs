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
        private Colaborator colaborator;
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
            string name = "Joaquin";
           
            string surname = "Oribe";

            string mail = "joacooribe@gmail.com";

            string password = "1234";

            DateTime birthday = DateTime.Now;


            bool result = false;
            colaborator = Utility.CreateColaborator(name,surname,mail,password,birthday);

            result = name == colaborator.name && surname == colaborator.surname &&
                     mail == colaborator.mail && password == colaborator.password &&
                     birthday == colaborator.birthday;
            Assert.AreEqual(result,true);

        }

        [TestMethod]
        public void ColaboratorEmptyName()
        {
            colaborator = new Colaborator();
            string name = "";

            string surname = "Oribe";

            string mail = "joacooribe@gmail.com";

            string password = "1234";

            DateTime birthday = DateTime.Now;


            bool result = false;
            colaborator = Utility.CreateColaborator(name, surname, mail, password, birthday);

            result = name == colaborator.name && surname == colaborator.surname &&
                     mail == colaborator.mail && password == colaborator.password &&
                     birthday == colaborator.birthday;
            Assert.AreEqual(result, false);

        }
    }
}
