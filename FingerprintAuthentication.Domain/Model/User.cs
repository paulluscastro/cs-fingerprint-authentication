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
            Validator.Add(new ValidationRule<User>(x => !string.IsNullOrEmpty(x.Name), UserErrors.User001.Name));
            Validator.Add(new ValidationRule<User>(x => x.Name != null && x.Name.Length > 3, UserErrors.User002.Name));
            Validator.Add(new ValidationRule<User>(x => !string.IsNullOrEmpty(x.Login), UserErrors.User003.Name));
            Validator.Add(new ValidationRule<User>(x => x.Login != null && x.Login.Length > 3, UserErrors.User004.Name));
            Validator.Add(new ValidationRule<User>(x => !string.IsNullOrEmpty(x.Password), UserErrors.User005.Name));
        }
        public User(string name, string login) : this()
        {
            Name = name;
            Login = login;
        }
        public User SetPassword(string newPassword)
        {
            Password = Crypto.HashMD5(newPassword, Login);
            return this;
        }
        public override List<ValidationResult> Validate() => Validator.Execute(this);
    }
}
