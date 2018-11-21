using System;
using FingerprintAuthentication.Commons.Model;
using FingerprintAuthentication.Commons.Resources;

namespace FingerprintAuthentication.Commons.Validation
{
    public class ValidationRule<T> where T : IEntity
    {
        public Predicate<T> Rule { get; protected set; }
        public string Code { get; protected set; }

        public ValidationRule(Predicate<T> predicate, string code)
        {
            Rule = predicate;
            Code = code;
        }
        public ValidationResult Execute(T entity) => Rule.Invoke(entity) ? null : new ValidationResult(Code, Messages.ResourceManager.GetString(Code));
    }
}
