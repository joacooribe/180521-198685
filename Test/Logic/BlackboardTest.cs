using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test.Logic
{
    /// <summary>
    /// Summary description for BlackboardTest
    /// </summary>
    [TestClass]
    public class BlackboardTest
    {
        public BlackboardTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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

            blackboard.name = name;
            blackboard.width = width;
            blackboard.high = high;
            blackboard.description = description;
            blackboard.ownerTeam = ownerTeam;
            //blackboard.ownerUser

            Assert.AreEqual(name, blackboard.name);
        }
    }
}
