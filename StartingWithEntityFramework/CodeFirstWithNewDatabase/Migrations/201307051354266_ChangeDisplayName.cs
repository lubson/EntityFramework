namespace CodeFirstWithNewDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDisplayName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "DisplayName", newName: "dispplay_name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Users", name: "dispplay_name", newName: "DisplayName");
        }
    }
}
