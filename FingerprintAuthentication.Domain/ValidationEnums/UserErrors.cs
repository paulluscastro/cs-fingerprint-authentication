using System.Linq;
using FingerprintAuthentication.Domain.Enums;

namespace FingerprintAuthentication.Domain.ValidationEnums
{
    public class UserErrors : BaseEnumeration
    {
        public static UserErrors UserNameNotInformed = new UserErrors(1, "USER001");
        public static UserErrors UserNameMinimumLength = new UserErrors(2, "USER002");
        public static UserErrors UserLoginNotInformed = new UserErrors(3, "USER003");
        public static UserErrors UserLoginInvalid = new UserErrors(4, "USER004");
        public static UserErrors UserPasswordNotInformed = new UserErrors(5, "USER005");
        public static UserErrors UserNameCannotBeMaster = new UserErrors(6, "USER006");
        public static UserErrors UserLoginCannotBe000 = new UserErrors(7, "USER007");

        public UserErrors(int code, string name) : base(code, name) { }
        public static UserErrors[] List() => new UserErrors[] { UserNameNotInformed, UserNameMinimumLength, UserLoginNotInformed, UserLoginInvalid, UserPasswordNotInformed };
        public static UserErrors From(int value) => List().Where(uf => uf.Id == value).FirstOrDefault();
        public static implicit operator int(UserErrors l) => l.Id;
        public static implicit operator UserErrors(int l) => List().Where(x => x.Id == l).FirstOrDefault();
        public static explicit operator string(UserErrors l) => l.Name;
    }
}
