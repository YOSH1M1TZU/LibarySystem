using System.ComponentModel.DataAnnotations;

namespace LibarySystem.Core.Objects {

    public class Book {

        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsLend { get; set; }
        public string StudentPesel { get; set; }

        public override string ToString() {
            return $"Book {Name} Author: {Author} Lended? {IsLend}. This book has ID: {Id}";
        }

    }

}