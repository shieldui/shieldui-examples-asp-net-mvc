using GridDatabaseSample.Models.DAL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GridDatabaseSample.DAL
{
    public class GridDatabaseSampleContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }   
}