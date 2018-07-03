namespace GridDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 256),
                        Name = c.String(maxLength: 256),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email)
                .Index(t => t.Name)
                .Index(t => t.Age);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.User", new[] { "Age" });
            DropIndex("dbo.User", new[] { "Name" });
            DropIndex("dbo.User", new[] { "Email" });
            DropTable("dbo.User");
        }
    }
}
