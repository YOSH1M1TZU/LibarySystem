using System.Data.Entity.Migrations;

namespace LibarySystem.DataModel.Migrations {

    public partial class BookIsLended : DbMigration {

        public override void Up() {
            AddColumn("dbo.Books", "IsLended", c => c.Boolean(false));
        }

        public override void Down() {
            DropColumn("dbo.Books", "IsLended");
        }

    }

}