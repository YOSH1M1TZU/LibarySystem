using System.Data.Entity.Migrations;

namespace LibarySystem.DataModel.Migrations {

    internal sealed class Configuration : DbMigrationsConfiguration<DbContext> {

        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

    }

}