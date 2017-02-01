using System.Data.Entity.Migrations;

namespace LibarySystem.DataModel.Migrations {

    public partial class BookKey : DbMigration {

        public override void Up() {
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "CatalogueNumber", c => c.String(false, 128));
            AddPrimaryKey("dbo.Books", "CatalogueNumber");
            DropColumn("dbo.Books", "Id");
        }

        public override void Down() {
            AddColumn("dbo.Books", "Id", c => c.Int(false, true));
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "CatalogueNumber", c => c.String());
            AddPrimaryKey("dbo.Books", "Id");
        }

    }

}