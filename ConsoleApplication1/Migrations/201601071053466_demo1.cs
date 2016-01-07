namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentTables", "StuName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentTables", "StuName", c => c.String(nullable: false));
        }
    }
}
