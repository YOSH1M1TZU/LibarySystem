using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibarySystem.Core.Objects {

    public class Student {

        public Student() {
            LendedBooks = new List<Book>();
        }
        
        [Key] public string Pesel { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Class { get; set; }
        public List<Book> LendedBooks { get; set; }

    }

}