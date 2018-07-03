namespace GridDatabaseSample.Migrations
{
    using GridDatabaseSample.Models.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GridDatabaseSample.DAL.GridDatabaseSampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GridDatabaseSample.DAL.GridDatabaseSampleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(q => q.Email, new User()
            {
                Email = "john@example.com",
                Name = "John Smith",
                Age = 35
            });
            context.Users.AddOrUpdate(q => q.Email, new User()
            {
                Email = "jane@example.com",
                Name = "Jane Doe",
                Age = 28
            });
            context.Users.AddOrUpdate(q => q.Email, new User()
            {
                Email = "mike@example.com",
                Name = "Mike Wazowski",
                Age = 24
            });
            context.SaveChanges();
        }
    }
}
