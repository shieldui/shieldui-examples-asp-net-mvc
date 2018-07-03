namespace GridDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEmailUnique : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.User", new[] { "Email" });
            CreateIndex("dbo.User", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.User", new[] { "Email" });
            CreateIndex("dbo.User", "Email");
        }
    }
}
