namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studenttable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.students", "confirmpassword", c => c.String());
            AlterColumn("dbo.students", "username", c => c.String(nullable: false));
            AlterColumn("dbo.students", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.students", "password", c => c.String());
            AlterColumn("dbo.students", "username", c => c.String());
            DropColumn("dbo.students", "confirmpassword");
        }
    }
}
