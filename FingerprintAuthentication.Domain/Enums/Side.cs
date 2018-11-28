using System.Linq;

namespace FingerprintAuthentication.Domain.Enums
{
    public class Side : BaseEnumeration
    {
        public static Side Left = new Side(1, "Left");
        public static Side Right = new Side(2, "Right");
        protected Side() : base() { }
        private Side(int id, string name) : base(id, name) { }
        public static Side[] List() => new Side[] { Left, Right };
        public static Side From(int value) => List().Where(uf => uf.Id == value).FirstOrDefault();
        public static implicit operator int(Side l) => l.Id;
        public static implicit operator Side(int l) => List().Where(x => x.Id == l).FirstOrDefault();
        public static explicit operator string(Side l) => l.Name;
    }
}
