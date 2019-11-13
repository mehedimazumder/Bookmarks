namespace Bookmarks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinkTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Title = c.String(maxLength: 255),
                        Description = c.String(maxLength: 2048),
                        Url = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Links");
        }
    }
}
