namespace WindowsEducacionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carreras", newName: "Carrera");
            RenameTable(name: "dbo.Plans", newName: "Plan");
            RenameTable(name: "dbo.Planillas", newName: "Planilla");
            RenameTable(name: "dbo.Cursoes", newName: "Cursos");
            RenameTable(name: "dbo.Detalles", newName: "Detalle");
            RenameTable(name: "dbo.Estadoes", newName: "Estado");
            RenameTable(name: "dbo.Materias", newName: "Materia");
            RenameTable(name: "dbo.Profesors", newName: "Profesor");
            RenameTable(name: "dbo.Localidads", newName: "Localidad");
            RenameTable(name: "dbo.Estudiantes", newName: "Estudiante");
            RenameTable(name: "dbo.Evaluacions", newName: "Evaluacion");
            RenameTable(name: "dbo.Tipoes", newName: "Tipo");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tipo", newName: "Tipoes");
            RenameTable(name: "dbo.Evaluacion", newName: "Evaluacions");
            RenameTable(name: "dbo.Estudiante", newName: "Estudiantes");
            RenameTable(name: "dbo.Localidad", newName: "Localidads");
            RenameTable(name: "dbo.Profesor", newName: "Profesors");
            RenameTable(name: "dbo.Materia", newName: "Materias");
            RenameTable(name: "dbo.Estado", newName: "Estadoes");
            RenameTable(name: "dbo.Detalle", newName: "Detalles");
            RenameTable(name: "dbo.Cursos", newName: "Cursoes");
            RenameTable(name: "dbo.Planilla", newName: "Planillas");
            RenameTable(name: "dbo.Plan", newName: "Plans");
            RenameTable(name: "dbo.Carrera", newName: "Carreras");
        }
    }
}
