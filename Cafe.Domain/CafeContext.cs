using Cafe.Domain.Model;
using System.Data.Entity;

namespace Cafe.Domain
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base("CafeDb")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Sort> Sorts { get; set; }
        public DbSet<OrderedSort> OrderedSorts { get; set; }
    }
}
