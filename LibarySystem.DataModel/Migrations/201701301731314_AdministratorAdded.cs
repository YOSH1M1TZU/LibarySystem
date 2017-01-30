using System.Data.Entity.Migrations;

namespace LibarySystem.DataModel.Migrations {

    public partial class AdministratorAdded : DbMigration {

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
        }

        public override void Down() {
            DropTable("dbo.Administrators");
        }

    }

}