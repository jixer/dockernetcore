using Microsoft.EntityFrameworkCore;
using ValuesMicroservice.Entity;

namespace ValuesMicroservice.Data
{
    public class StoredValuesContext : DbContext
    {
        public StoredValuesContext() : base()
        { }

        public StoredValuesContext(DbContextOptions<StoredValuesContext> options) : base(options)
        { }

        public DbSet<StoredValue> StoredValues { get; set; }
    }
}
