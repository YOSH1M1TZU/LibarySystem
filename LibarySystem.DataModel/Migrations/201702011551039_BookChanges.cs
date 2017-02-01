using System.Data.Entity.Migrations;

namespace LibarySystem.DataModel.Migrations {

    public partial class BookChanges : DbMigration {

        public override void Up() {
            AlterColumn("dbo.Books", "DateOfLend", c => c.DateTime());
            AlterColumn("dbo.Books", "DateOfReturn", c => c.DateTime());
        }

        public override void Down() {
            AlterColumn("dbo.Books", "DateOfReturn", c => c.DateTime(false));
            AlterColumn("dbo.Books", "DateOfLend", c => c.DateTime(false));
        }

    }

}