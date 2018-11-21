using System;

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
    }
}
