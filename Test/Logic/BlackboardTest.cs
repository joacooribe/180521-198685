using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test.Logic
{
    [TestClass]
    public class BlackboardTest
    {
        private Colaborator colaboratorCreator;
        private readonly string nameOK = "Joaquin";
        private readonly string surnameOK = "Oribe";
        private readonly string mailOK = "user@gmail.com";
        private readonly string passwordOK = "securePassword123";
        private readonly DateTime birthdayOk = new DateTime(1992, 9, 10);

        public BlackboardTest()
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
        public void BlackboardOk()
        {
            Team team = new Team();
            Blackboard blackboard = new Blackboard();

            string name = "Blackboard";
            int width = 23;
            int high = 20;
            string description = "Pizarron equipo 1";
            Team ownerTeam = team;
            colaboratorCreator = DataCreation.CreateColaborator(nameOK, surnameOK, mailOK, passwordOK, birthdayOk);

            blackboard.name = name;
            blackboard.width = width;
            blackboard.high = high;
            blackboard.description = description;
            blackboard.ownerTeam = ownerTeam;
            blackboard.ownerUser = colaboratorCreator;

            Assert.AreEqual(name, blackboard.name);
        }
    }
}
