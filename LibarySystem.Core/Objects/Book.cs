using System.Collections;
using System.ComponentModel.DataAnnotations;
using LibarySystem.Core.Interfaces;

namespace LibarySystem.Core.Objects {

    public class Book : IBook {

        public Book() {
            IsLend = false;
        }

        public Book(int id, string name, string author) : this() {
            Id = id;
            Name = name;
            Author = author;
        }


        // ReSharper disable once FunctionRecursiveOnAllPaths
        public IEnumerator GetEnumerator() {
            return GetEnumerator();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsLend { get; set; }

        public override string ToString() {
            return $"Book {Name} Author: {Author} Lended? {IsLend}. This book has ID: {Id}";
        }

    }

}