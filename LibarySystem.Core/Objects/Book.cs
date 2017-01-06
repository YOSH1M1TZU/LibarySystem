using System.Collections;
using LibarySystem.Core.Interfaces;

namespace LibarySystem.Core.Objects {

    public class Book : IBook {

        public Book(int id, string name, string author) {
            Id = id;
            Name = name;
            Author = author;
            IsLend = false;
        }

        
        // ReSharper disable once FunctionRecursiveOnAllPaths
        public IEnumerator GetEnumerator() {
            return GetEnumerator();
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsLend { get; set; }

        public override string ToString() {
            return $"Book {Name} Author: {Author} Lended? {IsLend}. This book has ID: {Id}";
        }

    }

}