using System.Linq;
using System.Collections.Generic;

using FingerprintAuthentication.Commons.Resources;
using FingerprintAuthentication.Commons.Validation;
using FingerprintAuthentication.Domain.Enums;
using FingerprintAuthentication.Domain.Model;
using FingerprintAuthentication.Domain.ValidationEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FingerprintAuthentication.Tests.Domain.Model
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Master_User_Should_Be_Correct()
        {
            User user = new User("MASTER", "00000").SetPassword("12345");
            List<ValidationResult> result = user.Validate();
            Assert.AreEqual(0, result.Count);
        }
        [TestMethod]
        public void Normal_User_Should_Be_Correct()
        {
            User user = new User("Paullus", "00001").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            Assert.AreEqual(0, user.Validate().Count);
        }
        [TestMethod]
        public void User_Name_Should_Have_Been_Informed()
        {
            User user = new User(null, "98536").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserNameNotInformed.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER001, result.Message);
            Assert.AreEqual(UserErrors.UserNameNotInformed.Name, result.Code);
        }
        [TestMethod]
        public void User_Name_Should_Be_Longer_Than_3_Characters()
        {
            User user = new User("Pa", "78521").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserNameMinimumLength.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER002, result.Message);
            Assert.AreEqual(UserErrors.UserNameMinimumLength.Name, result.Code);
        }
        [TestMethod]
        public void User_Login_Should_Have_Been_Informed()
        {
            User user = new User("TESTE", null).SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserLoginNotInformed.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER003, result.Message);
            Assert.AreEqual(UserErrors.UserLoginNotInformed.Name, result.Code);
        }
        [TestMethod]
        public void User_Login_Should_Be_Longer_Than_3_Characters()
        {
            User user = new User("TESTE", "01").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserLoginInvalid.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER004, result.Message);
            Assert.AreEqual(UserErrors.UserLoginInvalid.Name, result.Code);
        }
        [TestMethod]
        public void User_Password_Should_Have_Been_Informed()
        {
            User user = new User("TESTE", "25679");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserPasswordNotInformed.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER005, result.Message);
            Assert.AreEqual(UserErrors.UserPasswordNotInformed.Name, result.Code);
        }
        [TestMethod]
        public void User_Must_Have_Registered_Fingers()
        {
            User user = new User("Paullus", "00001");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserPasswordNotInformed.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER005, result.Message);
            Assert.AreEqual(UserErrors.UserPasswordNotInformed.Name, result.Code);
        }
        [TestMethod]
        public void Normal_User_Cannot_Have_Name_Master()
        {
            User user = new User("MASTER", "14258").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserNameCannotBeMaster.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER006, result.Message);
            Assert.AreEqual(UserErrors.UserNameCannotBeMaster.Name, result.Code);
        }
        [TestMethod]
        public void Normal_User_Cannot_Have_Login_00000()
        {
            User user = new User("Paullus", "00000").SetPassword("12345");
            user.Fingers.Add(new RegisteredFinger(Finger.Index, Side.Right, "dados do dedo"));
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserLoginCannotBe000.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER007, result.Message);
            Assert.AreEqual(UserErrors.UserLoginCannotBe000.Name, result.Code);
        }
        [TestMethod]
        public void Normal_User_Must_Have_At_Least_One_Registered_Finger()
        {
            User user = new User("Paullus", "15872").SetPassword("12345");
            ValidationResult result = user.Validate().Where(v => v.Code == UserErrors.UserMustRegisterFingers.Name).FirstOrDefault();
            Assert.AreEqual(Messages.USER008, result.Message);
            Assert.AreEqual(UserErrors.UserMustRegisterFingers.Name, result.Code);
        }
    }
}
