namespace ContactManager.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactAddImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Image");
        }
    }
}
