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
            user.Fingers.Add(new RegisteredFinger());
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
        public void User_Name_Should_Have_Been_Informed()
        {
            User user = new User(null, "98536").SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(Messages.USER001, result[0].Message);
            Assert.AreEqual(UserErrors.UserNameNotInformed.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Name_Should_Be_Longer_Than_3_Characters()
        {
            User user = new User("Pa", "78521").SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER002, result[0].Message);
            Assert.AreEqual(UserErrors.UserNameMinimumLength.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Login_Should_Have_Been_Informed()
        {
            User user = new User("TESTE", null).SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(Messages.USER003, result[0].Message);
            Assert.AreEqual(UserErrors.UserLoginNotInformed.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Login_Should_Be_Longer_Than_3_Characters()
        {
            User user = new User("TESTE", "01").SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER004, result[0].Message);
            Assert.AreEqual(UserErrors.UserLoginInvalid.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Password_Should_Have_Been_Informed()
        {
            User user = new User("TESTE", "25679");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER005, result[0].Message);
            Assert.AreEqual(UserErrors.UserPasswordNotInformed.Name, result[0].Code);
        }
        [TestMethod]
        public void User_Must_Have_Registered_Fingers()
        {
            User user = new User("Paullus", "00001");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER005, result[0].Message);
            Assert.AreEqual(UserErrors.UserPasswordNotInformed.Name, result[0].Code);
        }
        [TestMethod]
        public void Normal_User_Cannot_Have_Name_Master()
        {
            User user = new User("MASTER", "14258").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger());
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER006, result[0].Message);
            Assert.AreEqual(UserErrors.UserNameCannotBeMaster.Name, result[0].Code);
            Assert.AreEqual(result.Count, 1);
        }
        [TestMethod]
        public void Normal_User_Cannot_Have_Login_00000()
        {
            User user = new User("Paullus", "00000").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger());
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Messages.USER007, result[0].Message);
            Assert.AreEqual(UserErrors.UserLoginCannotBe000.Name, result[0].Code);
            Assert.AreEqual(result.Count, 1);
        }
    }
}
