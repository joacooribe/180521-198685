﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Exceptions;
using Logic;
using Persistence;

namespace Test
{
    [TestClass]
    public class ImageLogicTest
    {
        private Colaborator colaboratorCreator;
        private Administrator administratorCreator;
        private readonly string userNameOK = "Joaquin";
        private readonly string userSurnameOK = "Oribe";
        private readonly string userMailOK = "user@gmail.com";
        private readonly string anotherUserMailOk = "admin@gmail.com";
        private readonly string userPasswordOK = "securePassword123";
        private readonly DateTime userBirthdayOk = new DateTime(1992, 9, 10);

        private Team teamOwner;
        private ICollection<User> usersInTeam;
        private readonly string teamNameOK = "Team 1";
        private readonly DateTime teamDateOK = DateTime.Now;
        private readonly string teamDescriptionOK = "this is Team 1";
        private readonly int teamMaxUsersOK = 5;

        private Blackboard blackboardOwner;
        private readonly string blackboardNameOk = "Blackboard";
        private readonly int blackboardWidthOk = 23;
        private readonly int blackboardHeightOk = 20;
        private readonly string blackboardDescriptionOk = "Blackboard Team 1";

        private Image image;
        private readonly int widthOk = 10;
        private readonly int heightOk = 12;
        private readonly int originPointOk = 0;
        private readonly string formatOk = ".jpg";
        private readonly string urlOk = "/image/hola.jpg";

        private IImagePersistance imagePersistence;
        private IImageHandler imageHandler;

        public ImageLogicTest()
        {
            imagePersistence = new ImagePersistanceHandler();

            imageHandler = new ImageHandler();
        }

        [TestInitialize]
        public void TestSetUp()
        {
            ContextDB context = new ContextDB();

            context.EmptyTable();
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
        public void ImageOkCreatedByAdministrator()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);

            Assert.AreEqual(image,imageHandler.GetElementFromCollection(image.id,image.blackboardOwner));
        }

        [TestMethod]
        public void ImageOkCreatedByColaborator()
        {
            usersInTeam = new List<User>();

            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(colaboratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, colaboratorCreator, teamOwner);

            image = DataCreation.CreateImage(colaboratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);

            Assert.AreEqual(image, imageHandler.GetElementFromCollection(image.id, image.blackboardOwner));
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageWidthZero()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidWidth = 0;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, invalidWidth, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageWidthNegative()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidWidth = -1;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, invalidWidth, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageWidthGreaterThanBlackboardWidth()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidWidth = 100;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, invalidWidth, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageHeightZero()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidHeight = 0;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, invalidHeight, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageHeightNegative()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidHeight = -1;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, invalidHeight, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageHeightGreaterThanBlackboardHeight()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidHeight = 100;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, invalidHeight, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ImageException))]
        public void ImageFormatNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidFormat = null;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, invalidFormat);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ImageException))]
        public void ImageFormatEmpty()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidFormat = "";

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, invalidFormat);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ImageException))]
        public void ImageFormatNotAccepted()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidFormat = ".mp4";

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, invalidFormat);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ImageException))]
        public void ImageUrlNUll()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, anotherUserMailOk, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidUrl = null;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, invalidUrl, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ImageException))]
        public void ImageUrlEmpty()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, anotherUserMailOk, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            string invalidUrl = "";

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, invalidUrl, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageOriginPointNegative()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, anotherUserMailOk, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            int invalidOriginPoint = -1;

            image = DataCreation.CreateImage(administratorCreator, blackboardOwner, widthOk, heightOk, invalidOriginPoint, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageUserCreatorNotBelongingToTheTeam()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, anotherUserMailOk, userPasswordOK, userBirthdayOk);

            colaboratorCreator = DataCreation.CreateColaborator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(colaboratorCreator, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageBlackboardNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, anotherUserMailOk, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            image = DataCreation.CreateImage(administratorCreator, null, widthOk, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageUserOwnerNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, anotherUserMailOk, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(null, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            imageHandler.AddElement(image);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementException))]
        public void ImageCommentCollectionNull()
        {
            usersInTeam = new List<User>();

            administratorCreator = DataCreation.CreateAdministrator(userNameOK, userSurnameOK, userMailOK, userPasswordOK, userBirthdayOk);

            usersInTeam.Add(administratorCreator);

            teamOwner = DataCreation.CreateTeam(teamNameOK, teamDateOK, administratorCreator, teamDescriptionOK, teamMaxUsersOK, usersInTeam);

            blackboardOwner = DataCreation.CreateBlackboard(blackboardNameOk, blackboardDescriptionOk, blackboardHeightOk, blackboardWidthOk, administratorCreator, teamOwner);

            image = DataCreation.CreateImage(null, blackboardOwner, widthOk, heightOk, originPointOk, urlOk, formatOk);

            image.commentCollection = null;

            imageHandler.AddElement(image);
        }
    }
}
