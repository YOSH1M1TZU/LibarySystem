using System.Collections;
using LibarySystem.Core.Interfaces;

namespace LibarySystem.Core.Objects {

    public class Student : IStudent {

        public Student(string pesel, string name, string surname, string studentClass, string secondName = "") {
            PESEL = pesel;
            Name = name;
            Surname = surname;
            Class = studentClass;
            SecondName = secondName;
        }

        public IEnumerator GetEnumerator() {
            return GetEnumerator();
        }

        public string PESEL { get; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Class { get; set; }

        public override string ToString() {
            return "Name: " + Name + " " + SecondName + ". Class: " + Class + " PESEL: " + PESEL;
        }

    }

}