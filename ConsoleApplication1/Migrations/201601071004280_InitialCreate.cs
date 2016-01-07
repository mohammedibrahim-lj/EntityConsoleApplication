namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentTables",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StuName = c.String(),
                        StuClass = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentTables");
        }
    }
}
