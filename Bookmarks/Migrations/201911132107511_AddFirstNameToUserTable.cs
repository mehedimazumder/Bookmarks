﻿namespace Bookmarks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFirstNameToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
