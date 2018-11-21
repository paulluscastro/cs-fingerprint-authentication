using System.Linq;
using FingerprintAuthentication.Domain.Enums;

namespace FingerprintAuthentication.Domain.ValidationEnums
{
    public class UserErrors : BaseEnumeration
    {
        public static UserErrors User001 = new UserErrors(1, "USER001");
        public static UserErrors User002 = new UserErrors(2, "USER002");
        public static UserErrors User003 = new UserErrors(3, "USER003");
        public static UserErrors User004 = new UserErrors(4, "USER004");
        public static UserErrors User005 = new UserErrors(4, "USER005");

        public UserErrors(int code, string name) : base(code, name) { }
        public static UserErrors[] List() => new UserErrors[] { User001, User002, User003, User004, User005 };
        public static UserErrors From(int value) => List().Where(uf => uf.Id == value).FirstOrDefault();
        public static implicit operator int(UserErrors l) => l.Id;
        public static implicit operator UserErrors(int l) => List().Where(x => x.Id == l).FirstOrDefault();
        public static explicit operator string(UserErrors l) => l.Name;
    }
}
