using FingerprintAuthentication.Commons.Resources;
using FingerprintAuthentication.Commons.Validation;
using FingerprintAuthentication.Domain.Model;
using FingerprintAuthentication.Domain.ValidationEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FingerprintAuthentication.Tests.Domain.Model
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Master_User_Should_Be_Correct()
        {
            User user = new User("MASTER", "00000").SetPassword("12345");
            Assert.AreEqual(user.Validate().Count, 0);
        }
        [TestMethod]
        public void Normal_User_Should_Be_Correct()
        {
            User user = new User("Paullus", "00001").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger());
            Assert.AreEqual(user.Validate().Count, 0);
        }
        [TestMethod]
        public void Normal_User_Cannot_Have_Login_00000()
        {
            User user = new User("Paullus", "00000").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger());
            Assert.AreEqual(user.Validate().Count, 0);
        }
        [TestMethod]
        public void Normal_User_Cannot_Have_Name_Master()
        {
            User user = new User("Paullus", "00000").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger());
            Assert.AreEqual(user.Validate().Count, 0);
        }
        [TestMethod]
        public void User_Name_Should_Have_Been_Informed()
        {
            User user = new User(null, "00000").SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(Messages.USER001, result[0].Message);
            Assert.AreEqual(UserErrors.User001.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Name_Should_Be_Longer_Than_3_Characters()
        {
            User user = new User("Pa", "00000").SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER002, result[0].Message);
            Assert.AreEqual(UserErrors.User002.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Login_Should_Have_Been_Informed()
        {
            User user = new User("MASTER", null).SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(Messages.USER003, result[0].Message);
            Assert.AreEqual(UserErrors.User003.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Login_Should_Be_Longer_Than_3_Characters()
        {
            User user = new User("MASTER", "01").SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER004, result[0].Message);
            Assert.AreEqual(UserErrors.User004.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Password_Should_Have_Been_Informed()
        {
            User user = new User("MASTER", "00000");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER005, result[0].Message);
            Assert.AreEqual(UserErrors.User005.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Must_Have_Registered_Fingers()
        {
            User user = new User("Paullus", "00001");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER005, result[0].Message);
            Assert.AreEqual(UserErrors.User005.Name, result[0].Code);
        }
    }
}
