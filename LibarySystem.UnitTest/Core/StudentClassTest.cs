using System;
using LibarySystem.Core.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibarySystem.UnitTest.Core {

    [TestClass]
    public class StudentClassTestClass {

        [TestMethod]
        public void StudentConstructor() {
            var newStudent = new Student("81021005331", "Mattias", "Lincooln");
            var expectedPESEL = "81021005331";
            var expectedName = "Mattias";
            var expectedSurname = "Lincooln";

            Assert.AreEqual(expectedPESEL, newStudent.PESEL);
            Assert.AreEqual(expectedName, newStudent.Name);
            Assert.AreEqual(expectedSurname, newStudent.Surname);

            newStudent.Class = "2Bi";
            var expectedClass = "2Bi";

            Assert.AreEqual(expectedClass, newStudent.Class);

            newStudent.SecondName = "Lucian";
            var expectedSecoundName = "Lucian";

            Assert.AreEqual(expectedSecoundName, newStudent.SecondName);

            newStudent.DateOfBirth = new DateTime(1981, 02, 10);
            var expectedDateOfBirth = new DateTime(1981, 02, 10);

            Assert.AreEqual(expectedDateOfBirth, newStudent.DateOfBirth);
        }

        [TestMethod]
        public void StudentIEnumerableTest() {
            Student[] studentsArray = {
                new Student("81021005331", "Mattias", "Lincooln"),
                new Student("91023150244", "John", "Smitch"),
                new Student("04113014551", "Lisa", "Ramplay"),
                new Student("09031351566", "Jane", "Mary")
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