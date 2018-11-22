using System;
using System.Collections.Generic;
using FingerprintAuthentication.Commons.Model;
using FingerprintAuthentication.Commons.Utils;
using FingerprintAuthentication.Commons.Validation;
using FingerprintAuthentication.Domain.ValidationEnums;

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
            Validator.Add(new ValidationRule<User>(x => !string.IsNullOrEmpty(x.Name), UserErrors.UserNameNotInformed.Name));
            Validator.Add(new ValidationRule<User>(x => x.Name != null && x.Name.Length > 3, UserErrors.UserNameMinimumLength.Name));
            Validator.Add(new ValidationRule<User>(x => !string.IsNullOrEmpty(x.Login), UserErrors.UserLoginNotInformed.Name));
            Validator.Add(new ValidationRule<User>(x => x.Login != null && x.Login.Length == 5 && StringUtils.NumbersOnly(x.Login).Length == 5, UserErrors.UserLoginInvalid.Name));
            Validator.Add(new ValidationRule<User>(x => !string.IsNullOrEmpty(x.Password), UserErrors.UserPasswordNotInformed.Name));
            Validator.Add(new ValidationRule<User>(x => x.Name != null && x.Name.ToUpper() != "MASTER" ? true : x.Login != null && x.Login == "00000", UserErrors.UserNameCannotBeMaster.Name));
            Validator.Add(new ValidationRule<User>(x => x.Login != null && x.Login != "00000" ? true : x.Name != null && x.Name.ToUpper() == "MASTER", UserErrors.UserLoginCannotBe000.Name));
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
        public override List<ValidationResult> Validate() => Validator.Execute(this);
    }
}
