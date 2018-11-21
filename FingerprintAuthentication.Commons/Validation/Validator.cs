using FingerprintAuthentication.Commons.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FingerprintAuthentication.Commons.Validation
{
    public class Validator<T> where T : IEntity
    {
        private List<ValidationRule<T>> Rules { get; set; } = new List<ValidationRule<T>>();
        public void Add(ValidationRule<T> rule) => Rules.Add(rule);
        public List<ValidationResult> Execute(T entity)
        {
            List<ValidationResult> result = new List<ValidationResult>();
            foreach (ValidationRule<T> rule in Rules)
            {
                ValidationResult r = rule.Execute(entity);
                if (r != null)
                    result.Add(r);
            }
            return result;
        }
    }
}
