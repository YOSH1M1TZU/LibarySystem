using System;
using LibarySystem.Core.Objects;
using LibarySystem.DataModel;
using LibarySystem.DataModel.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibarySystem.Test.Operations {

    [TestClass]
    public class StudentOperationsTest {

        [TestMethod]
        public void AddAndDeleteStudentTest() {
            using (var context = new DbContext()) {
                var student = new Student("00000000000", "test", "test", "testclass");

                StudentOperations.AddStudent(student);

                var studentInDb = context.Students.Find(student.PESEL);
                if (studentInDb == null) throw new NullReferenceException("No student in Db");

                Assert.AreEqual(student.PESEL, studentInDb.PESEL);
                Assert.AreEqual(student.Name, studentInDb.Name);
                Assert.AreEqual(student.SecondName, studentInDb.SecondName);
                Assert.AreEqual(student.Surname, studentInDb.Surname);
                Assert.AreEqual(student.Class, studentInDb.Class);
                Assert.IsTrue(DeleteStudent(student.PESEL));
            }
        }

        private bool DeleteStudent(string pesel) {
            try {
                StudentOperations.DeleteStudentWithPesel(pesel);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

    }

}