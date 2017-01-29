using System;
using LibarySystem.Core.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibarySystem.UnitTest.Core {

    [TestClass]
    public class StudentClassTestClass {

        [TestMethod]
        public void StudentConstructor() {
            var newStudent = new Student("81021005331", "Mattias", "Lincooln", "2Bi", "Lucian");
            var expectedPESEL = "81021005331";
            var expectedName = "Mattias";
            var expectedSurname = "Lincooln";
            var expectedClass = "2Bi";
            var expectedSecoundName = "Lucian";

            Assert.AreEqual(expectedPESEL, newStudent.PESEL);
            Assert.AreEqual(expectedName, newStudent.Name);
            Assert.AreEqual(expectedSurname, newStudent.Surname);
            Assert.AreEqual(expectedClass, newStudent.Class);
            Assert.AreEqual(expectedSecoundName, newStudent.SecondName);
        }

        [TestMethod]
        public void StudentIEnumerableTest() {
            Student[] studentsArray = {
                new Student("81021005331", "Mattias", "Lincooln", "2Bi", "Lucian"),
                new Student("91023150244", "John", "Smitch", "3Li", "Steve"),
                new Student("04113014551", "Lisa", "Ramplay", "1Ai"),
                new Student("09031351566", "Jane", "Mary", "1Mi")
            };

            Assert.IsTrue(StudentForEachTest(studentsArray));
        }

        private bool StudentForEachTest(Student[] studentsArray) {
            try {
                foreach (var student in studentsArray) Console.WriteLine(student);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

    }

}