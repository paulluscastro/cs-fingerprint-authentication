using System;
using System.Collections.Generic;
using System.Reflection;

namespace FingerprintAuthentication.Domain.Enums
{
    public abstract class BaseEnumeration
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }

        protected BaseEnumeration() { }
        protected BaseEnumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;
        public static IEnumerable<T> GetAll<T>() where T : BaseEnumeration, new()
        {
            var type = typeof(T);
            var fields = type.GetFields(BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.DeclaredOnly);
            foreach (var info in fields)
                if (info.GetValue(new T()) is T locatedValue)
                    yield return locatedValue;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is BaseEnumeration otherValue))
                return false;
            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);
            return typeMatches && valueMatches;
        }
        public override int GetHashCode() => Id.GetHashCode();
        public int CompareTo(object other) => Id.CompareTo(((BaseEnumeration)other).Id);
        public static int AbsoluteDifference(BaseEnumeration firstValue, BaseEnumeration secondValue) => Math.Abs(firstValue.Id - secondValue.Id);
    }
}
