using System.Linq;

namespace FingerprintAuthentication.Domain.Enums
{
    public class Finger : BaseEnumeration
    {
        public static Finger Thumb = new Finger(1, "Thumb");
        public static Finger Index = new Finger(2, "Index");
        public static Finger Middle = new Finger(3, "Middle");
        public static Finger Ring = new Finger(4, "Ring");
        public static Finger Pinky = new Finger(5, "Pinky");
        protected Finger() : base() { }
        private Finger(int id, string name) : base(id, name) { }
        public static Finger[] List() => new Finger[] { Thumb, Index, Middle, Ring, Pinky };
        public static Finger From(int value) => List().Where(uf => uf.Id == value).FirstOrDefault();
        public static implicit operator int(Finger l) => l.Id;
        public static implicit operator Finger(int l) => List().Where(x => x.Id == l).FirstOrDefault();
        public static explicit operator string(Finger l) => l.Name;
    }
}
