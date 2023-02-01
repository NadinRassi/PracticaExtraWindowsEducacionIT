namespace WindowsEducacionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evaluacions", "IDEstudiante", c => c.Int(nullable: false));
            CreateIndex("dbo.Evaluacions", "IDEstudiante");
            AddForeignKey("dbo.Evaluacions", "IDEstudiante", "dbo.Estudiantes", "IDEstudiante", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evaluacions", "IDEstudiante", "dbo.Estudiantes");
            DropIndex("dbo.Evaluacions", new[] { "IDEstudiante" });
            DropColumn("dbo.Evaluacions", "IDEstudiante");
        }
    }
}
