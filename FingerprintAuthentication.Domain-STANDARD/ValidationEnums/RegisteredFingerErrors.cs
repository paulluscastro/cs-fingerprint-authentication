using System.Linq;
using FingerprintAuthentication.Domain.Enums;

namespace FingerprintAuthentication.Domain.ValidationEnums
{
    public class RegisteredFingerErrors : BaseEnumeration
    {
        public static RegisteredFingerErrors RegisteredFingerFingerNotInformed = new RegisteredFingerErrors(1, "REFI001");
        public static RegisteredFingerErrors RegisteredFingerSideNotInformed = new RegisteredFingerErrors(2, "REFI002");
        public static RegisteredFingerErrors RegisteredFingerFingerDataNotInformed = new RegisteredFingerErrors(3, "REFI003");

        public RegisteredFingerErrors(int code, string name) : base(code, name) { }
        public static RegisteredFingerErrors[] List() => new RegisteredFingerErrors[] {
            RegisteredFingerFingerNotInformed,
            RegisteredFingerSideNotInformed,
            RegisteredFingerFingerDataNotInformed
        };
        public static RegisteredFingerErrors From(int value) => List().Where(uf => uf.Id == value).FirstOrDefault();
        public static implicit operator int(RegisteredFingerErrors l) => l.Id;
        public static implicit operator RegisteredFingerErrors(int l) => List().Where(x => x.Id == l).FirstOrDefault();
        public static explicit operator string(RegisteredFingerErrors l) => l.Name;
    }
}
