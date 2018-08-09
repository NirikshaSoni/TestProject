namespace TestMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "SurName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "address", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Qualification", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "ContactNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "ContactNumber", c => c.String());
            AlterColumn("dbo.Employees", "Qualification", c => c.String());
            AlterColumn("dbo.Employees", "address", c => c.String());
            AlterColumn("dbo.Employees", "SurName", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
        }
    }
}
