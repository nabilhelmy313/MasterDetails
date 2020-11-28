namespace Entry
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Db : DbContext
    {
        public Db()
            : base("name=Db")
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Branch)
                .HasForeignKey(e => e.Branch_Id);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Branches)
                .WithOptional(e => e.City)
                .HasForeignKey(e => e.City_Id);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Cities)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.Country_Id);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.Department_Id);
        }
    }
}
