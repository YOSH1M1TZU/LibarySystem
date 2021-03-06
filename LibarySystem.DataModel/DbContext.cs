﻿using System.Data.Entity;
using LibarySystem.Core.Objects;

namespace LibarySystem.DataModel {

    public class DbContext : System.Data.Entity.DbContext {

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<LendedBook> LendedBooks { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

    }

}