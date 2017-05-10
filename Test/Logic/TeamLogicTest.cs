﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Logic;
using Persistence;

namespace Test.Logic
{

    [TestClass]
    public class TeamLogicTest
    {
        private TeamPersistenceHandler teamPersistence;
        private TeamHandler teamHandler;
        private Repository systemList;
        private Team team;
        public TeamLogicTest()
        {
            systemList = new Repository();
            teamPersistence = new TeamPersistenceHandler(systemList);
            teamHandler = new TeamHandler() { teamFunctions = teamPersistence };
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
        public void TeamOK()
        {
            team = new Team();
            team.name = "Team 1";
            team.creationDate = DateTime.Now;
            team.description = "This is a team";
            team.maxUsers = 5;
            //FALTA AGREGAR USUARIO
            teamHandler.AddTeam(team);
        }
    }
}
