using System;

namespace FingerprintAuthentication.Commons.Model
{
    public interface IEntity
    {
        Guid Id { get; }
        DateTime Creation { get; }
        DateTime LastUpdate { get; }
    }
}
