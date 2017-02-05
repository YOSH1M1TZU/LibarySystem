using System.Data.Entity.Migrations;

namespace LibarySystem.DataModel.Migrations {

    public partial class NewInitDb : DbMigration {

        public override void Up() {
            CreateTable(
                    "dbo.Administrators",
                    c => new {
                        Login = c.String(false, 128),
                        Name = c.String(),
                        Surname = c.String(),
                        Password = c.String()
                    })
                .PrimaryKey(t => t.Login);

            CreateTable(
                    "dbo.Books",
                    c => new {
                        CatalogueNumber = c.String(false, 128),
                        Name = c.String(),
                        Author = c.String()
                    })
                .PrimaryKey(t => t.CatalogueNumber);

            CreateTable(
                    "dbo.LendedBooks",
                    c => new {
                        Id = c.Int(false, true),
                        DateOfLend = c.DateTime(false),
                        DateOfReturn = c.DateTime(),
                        StudentPesel = c.String(maxLength: 128),
                        CatalogueNumber = c.String(maxLength: 128)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.CatalogueNumber)
                .ForeignKey("dbo.Students", t => t.StudentPesel)
                .Index(t => t.StudentPesel)
                .Index(t => t.CatalogueNumber);

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
            DropForeignKey("dbo.LendedBooks", "StudentPesel", "dbo.Students");
            DropForeignKey("dbo.LendedBooks", "CatalogueNumber", "dbo.Books");
            DropIndex("dbo.LendedBooks", new[] {"CatalogueNumber"});
            DropIndex("dbo.LendedBooks", new[] {"StudentPesel"});
            DropTable("dbo.Students");
            DropTable("dbo.LendedBooks");
            DropTable("dbo.Books");
            DropTable("dbo.Administrators");
        }

    }

}