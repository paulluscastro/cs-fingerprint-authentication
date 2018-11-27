using System;
using System.Collections.Generic;

namespace FingerprintAuthentication.Commons.Validation
{
    public class ValidationResult
    {
        public string Code { get; protected set; }
        public string Message { get; protected set; }
        public Exception InnerException { get; protected set; }
        public ValidationResult(string code, string message)
        {
            Code = code;
            Message = message;
        }
        public ValidationResult(string code, string message, Exception exception) : this(code, message) => InnerException = exception;
        public static Exception BuildException(List<ValidationResult> errors, string message)
        {
            Exception exception = new Exception();
            foreach (ValidationResult validationResult in errors)
                exception.Data.Add(validationResult.Code, validationResult.Message);
            return exception;
        }
        public override string ToString() => $"{Code} - {Message}";
    }
}
