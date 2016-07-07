using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using StatefulValuesMicroservice.Data;

namespace StatefulValuesMicroservice.Migrations
{
    [DbContext(typeof(StoredValuesContext))]
    partial class StoredValuesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("StatefulValuesMicroservice.Entity.StoredValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("StoredValues");
                });
        }
    }
}
