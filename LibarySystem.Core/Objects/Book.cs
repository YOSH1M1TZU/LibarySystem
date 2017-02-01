using System;
using System.ComponentModel.DataAnnotations;

namespace LibarySystem.Core.Objects {

    public class Book {

        public Book() {
            IsLend = false;
        }

        public Book(string catalogueNumber, string name, string author) : this() {
            CatalogueNumber = catalogueNumber;
            Name = name;
            Author = author;
        }

        [Key]
        public string CatalogueNumber { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime? DateOfLend { get; set; }
        public DateTime? DateOfReturn { get; set; }
        public bool IsLend { get; set; }

    }

}