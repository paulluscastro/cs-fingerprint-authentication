using System;
using System.Linq;
using System.Collections.Generic;
using FingerprintAuthentication.Commons.Model;
using FingerprintAuthentication.Commons.Utils;
using FingerprintAuthentication.Commons.Validation;
using FingerprintAuthentication.Domain.Enums;
using FingerprintAuthentication.Domain.ValidationEnums;
using FingerprintAuthentication.Commons.Resources;

namespace FingerprintAuthentication.Domain.Model
{
    public class User : AbstractBaseEntity
    {
        public string Name { get; protected set; }
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public List<RegisteredFinger> Fingers { get; protected set; } = new List<RegisteredFinger>();
        private Validator<User> Validator { get; set; } = new Validator<User>();

        protected User()
        {
            Validator.Add(new ValidationRule<User>(f => !string.IsNullOrEmpty(f.Name), UserErrors.UserNameNotInformed.Name));
            Validator.Add(new ValidationRule<User>(u => u.Name != null && u.Name.Length > 3, UserErrors.UserNameMinimumLength.Name));
            Validator.Add(new ValidationRule<User>(u => !string.IsNullOrEmpty(u.Login), UserErrors.UserLoginNotInformed.Name));
            Validator.Add(new ValidationRule<User>(u => u.Login != null && u.Login.Length == 5 && StringUtils.NumbersOnly(u.Login).Length == 5, UserErrors.UserLoginInvalid.Name));
            Validator.Add(new ValidationRule<User>(u => !string.IsNullOrEmpty(u.Password), UserErrors.UserPasswordNotInformed.Name));
            Validator.Add(new ValidationRule<User>(u => u.Name != null && u.Name.ToUpper() != "MASTER" ? true : u.Login != null && u.Login == "00000", UserErrors.UserNameCannotBeMaster.Name));
            Validator.Add(new ValidationRule<User>(u => u.Login != null && u.Login != "00000" ? true : u.Name != null && u.Name.ToUpper() == "MASTER", UserErrors.UserLoginCannotBe000.Name));
            // Validator.Add(new ValidationRule<User>(u => u.Name != null && u.Name.ToUpper() == "MASTER" ? true : u.Fingers.Count > 0, UserErrors.UserMustRegisterFingers.Name));
        }
        public User(string name, string login) : this()
        {
            Name = name;
            Login = login;
        }
        public User SetPassword(string newPassword)
        {
            Password = CryptoUtils.HashMD5(newPassword, Login);
            return this;
        }
        private RegisteredFinger FindFinger(Finger finger, Side side) => Fingers.Where(f => f.Finger == finger && f.Side == side).FirstOrDefault();

        public RegisteredFinger AddFinger(Finger finger, Side side, string data)
        {
            RegisteredFinger registeredFinger = new RegisteredFinger(this, finger, side, data);
            List<ValidationResult> result = registeredFinger.Validate();
            if (result.Count > 0) throw ValidationResult.BuildException(result, Messages.ResourceManager.GetString(UserErrors.UserErrorDuringFingerRegistration.Name));
            if (FindFinger(finger, side) != null) throw new Exception(Messages.ResourceManager.GetString(UserErrors.UserFingerAlreadyRegistered.Name));
            Fingers.Add(registeredFinger);
            return registeredFinger;
        }
        public void RemoveFinger(Finger finger, Side side)
        {
            RegisteredFinger registeredFinger = FindFinger(finger, side);
            if (registeredFinger == null) return;
            RemoveFinger(registeredFinger);
        }
        public void RemoveFinger(RegisteredFinger registeredFinger) => Fingers.Remove(registeredFinger);
        public override List<ValidationResult> Validate() => Validator.Execute(this);
    }
}
