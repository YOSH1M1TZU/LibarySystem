using System.ComponentModel.DataAnnotations;

namespace LibarySystem.Core.Objects {

    public class Book {

        public Book() {
            IsLend = false;
        }

        public Book(int id, string name, string author) : this() {
            Id = id;
            Name = name;
            Author = author;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsLend { get; set; }

    }

}