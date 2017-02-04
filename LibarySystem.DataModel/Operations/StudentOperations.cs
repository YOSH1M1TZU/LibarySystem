using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibarySystem.Core.Delegates;
using LibarySystem.Core.Objects;

namespace LibarySystem.DataModel.Operations {

    public static class StudentOperations {

        public static event ChangedEventHandler StudentAddedOrDeleted;

        public static void AddStudent(Student student) {
            using (var context = new DbContext()) {
                context.Students.Add(student);
                context.SaveChanges();
                StudentAddedOrDeleted(EventArgs.Empty);
            }
        }

        public static void DeleteStudentWithPesel(string pesel) {
            using (var context = new DbContext()) {
                var student = context.Students.Find(pesel);
                if (student == null) throw new NullReferenceException("Nie znaleziono studenta w bazie danych...");
                context.Students.Remove(student);
                context.SaveChanges();
                StudentAddedOrDeleted(EventArgs.Empty);
            }
        }

        public static void ModifyStudentWithPesel(string pesel, Student student) {
            using (var context = new DbContext()) {
                var _student = context.Students.Find(pesel);
                _student = student;
                context.SaveChanges();
            }
        }

        public static async Task<List<Student>> StudentsToListAsync() {
            var result = await Task.Run(() => {
                using (var context = new DbContext()) {
                    var listOfStudents = context.Students.Where(s => s.PESEL != null).ToList();
                    return listOfStudents;
                }
            });
            return result;
        }

    }

}