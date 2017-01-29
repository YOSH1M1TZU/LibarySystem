using System;
using LibarySystem.Core.Objects;

namespace LibarySystem.DataModel {

    public static class StudentOperations {

        public static void AddStudent(Student student) {
            using (var context = new StudentContext()) {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public static void DeleteStudentWithPesel(string pesel) {
            using (var context = new StudentContext()) {
                var student = context.Students.Find(pesel);
                if (student == null) throw new NullReferenceException("Nie znaleziono studenta w bazie danych...");
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

    }

}