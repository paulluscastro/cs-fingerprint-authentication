using System;
using System.Collections.Generic;
using FingerprintAuthentication.Commons.Validation;

namespace FingerprintAuthentication.Commons.Model
{
    public abstract class AbstractBaseEntity : IEntity
    {
        public AbstractBaseEntity()
        {
        }

        public Guid Id { get; protected set; }

        public abstract List<ValidationResult> Validate();
    }
}
