using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibarySystem.Core.Interfaces;

namespace LibarySystem.Core.Objects {

    public class Student : IStudent {

        public Student() {
            LendedBooks = new List<Book>();
        }

        public Student(string pesel, string name, string surname, string studentClass, string secondName = null)
            : this() {
            PESEL = pesel;
            Name = name;
            Surname = surname;
            Class = studentClass;
            SecondName = secondName;
        }

        public List<Book> LendedBooks { get; set; }

        public IEnumerator GetEnumerator() {
            return GetEnumerator();
        }

        [Key]
        public string PESEL { get; set; }

        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Class { get; set; }

        public override string ToString() {
            return "Name: " + Name + " " + SecondName + ". Class: " + Class + " PESEL: " + PESEL;
        }

    }

}