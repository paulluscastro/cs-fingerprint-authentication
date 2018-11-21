using FingerprintAuthentication.Commons.Model;
using FingerprintAuthentication.Commons.Validation;
using FingerprintAuthentication.Domain.Enums;
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

        public override List<ValidationResult> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
