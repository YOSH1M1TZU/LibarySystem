using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibarySystem.Core.Objects {

    public class Student {

        public Student() {
            LendedBooks = new List<LendedBook>();
        }

        public Student(string pesel, string name, string surname, string studentClass, string secondName = null)
            : this() {
            PESEL = pesel;
            Name = name;
            Surname = surname;
            Class = studentClass;
            SecondName = secondName;
        }

        [Key]
        public string PESEL { get; set; }

        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Class { get; set; }
        public virtual List<LendedBook> LendedBooks { get; set; }

    }

}