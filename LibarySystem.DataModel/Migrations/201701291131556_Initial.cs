using System.Data.Entity.Migrations;

namespace LibarySystem.DataModel.Migrations {

    public partial class Initial : DbMigration {

        public override void Up() {
            CreateTable(
                    "dbo.Books",
                    c => new {
                        Id = c.Int(false, true),
                        Name = c.String(),
                        Author = c.String(),
                        IsLend = c.Boolean(false),
                        Student_PESEL = c.String(maxLength: 128)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_PESEL)
                .Index(t => t.Student_PESEL);

            CreateTable(
                    "dbo.Students",
                    c => new {
                        PESEL = c.String(false, 128),
                        Name = c.String(),
                        SecondName = c.String(),
                        Surname = c.String(),
                        Class = c.String()
                    })
                .PrimaryKey(t => t.PESEL);
        }

        public override void Down() {
            DropForeignKey("dbo.Books", "Student_PESEL", "dbo.Students");
            DropIndex("dbo.Books", new[] {"Student_PESEL"});
            DropTable("dbo.Students");
            DropTable("dbo.Books");
        }

    }

}