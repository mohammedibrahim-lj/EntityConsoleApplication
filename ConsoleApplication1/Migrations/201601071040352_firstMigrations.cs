namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentTables", "StuName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentTables", "StuName", c => c.String());
        }
    }
}
