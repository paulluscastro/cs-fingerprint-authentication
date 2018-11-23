using FingerprintAuthentication.Domain.Model;
using FingerprintAuthentication.Infrastructure.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace FingerprintAuthentication.Infrastructure.Context
{
    public class FingerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<RegisteredFinger> RegisteredFingers { get; set; }

        public FingerContext()
        {
            System.Diagnostics.Debug.WriteLine("Criado o data context: " + GetHashCode());
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Configurations
                .Add(new UserMap());
        }
    }
}
