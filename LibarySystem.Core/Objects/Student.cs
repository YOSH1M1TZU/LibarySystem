using System;
using System.Collections;
using LibarySystem.Core.Interfaces;

namespace LibarySystem.Core.Objects {

    public class Student : IStudent {

        public Student(string pesel, string name, string surname) {
            PESEL = pesel;
            Name = name;
            Surname = surname;
        }

        public IEnumerator GetEnumerator() {
            return GetEnumerator();
        }

        public string PESEL { get; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Class { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString() {
            return "Name: " + Name + " " + SecondName + ". Date of birth: " + DateOfBirth.ToShortDateString() +
                   ". Class: " + Class + " PESEL: " + PESEL;
        }

    }

}