using FingerprintAuthentication.Commons.Model;
using FingerprintAuthentication.Commons.Validation;
using FingerprintAuthentication.Domain.Enums;
using FingerprintAuthentication.Domain.ValidationEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FingerprintAuthentication.Domain.Model
{
    public class RegisteredFinger : AbstractBaseEntity
    {
        public Finger Finger { get; protected set; }
        public Side Side { get; protected set; }
        public string EncodedText { get; protected set; }
        public User User { get; set; }
        private Validator<RegisteredFinger> Validator { get; set; } = new Validator<RegisteredFinger>();

        protected RegisteredFinger()
        {
            Validator.Add(new ValidationRule<RegisteredFinger>(r => r.Finger != null, RegisteredFingerErrors.RegisteredFingerFingerNotInformed.Name));
            Validator.Add(new ValidationRule<RegisteredFinger>(r => r.Side != null, RegisteredFingerErrors.RegisteredFingerSideNotInformed.Name));
            Validator.Add(new ValidationRule<RegisteredFinger>(r => !string.IsNullOrEmpty(r.EncodedText), RegisteredFingerErrors.RegisteredFingerFingerDataNotInformed.Name));
        }

        public RegisteredFinger(Finger finger, Side side, string encodedText) : base()
        {
            Finger = finger;
            Side = side;
            EncodedText = encodedText;
        }

        public override List<ValidationResult> Validate() => Validator.Execute(this);
    }
}
