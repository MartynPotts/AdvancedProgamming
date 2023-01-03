using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AwayDayPlanner
{
    public partial class Context : DbContext
    {
        public Context() : base("name=conString")
        {
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<>)
            this.Configuration.ProxyCreationEnabled = false; 
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
