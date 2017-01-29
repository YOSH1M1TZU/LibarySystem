using System.Data.Entity;
using LibarySystem.Core.Objects;

namespace LibarySystem.DataModel {

    public class StudentContext : DbContext {

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }

    }

}