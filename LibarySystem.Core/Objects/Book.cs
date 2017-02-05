using System.ComponentModel.DataAnnotations;

namespace LibarySystem.Core.Objects {

    public class Book {

        public Book() {
            IsLended = false;
        }

        public Book(string catalogueNumber, string name, string author) {
            CatalogueNumber = catalogueNumber;
            Name = name;
            Author = author;
        }

        [Key]
        public string CatalogueNumber { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsLended { get; set; }

    }

}