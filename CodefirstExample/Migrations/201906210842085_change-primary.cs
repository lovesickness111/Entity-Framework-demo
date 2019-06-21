namespace CodefirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeprimary : DbMigration
    {
        public override void Up()
        {

        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "StudentID", c => c.Int(nullable: false, identity: false));
            DropColumn("dbo.Students", "ID");
            AddPrimaryKey("dbo.Students", "StudentID");
        }
    }
}
