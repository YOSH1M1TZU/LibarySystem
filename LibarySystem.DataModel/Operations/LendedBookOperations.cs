using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using LibarySystem.Core.Delegates;
using LibarySystem.Core.Objects;

namespace LibarySystem.DataModel.Operations {

    public static class LendedBookOperations {

        public static event ChangedEventHandler ReturnedOrLendedBook;

        public static void LendBook(Student student, Book book, DateTime dateOfReturn) {
            using (var context = new DbContext()) {
                var findStudent = context.Students.Find(student.PESEL);
                var findBook = context.Books.Find(book.CatalogueNumber);
                var lendedBook = new LendedBook {
                    Student = findStudent,
                    StudentPesel = findStudent.PESEL,
                    Book = findBook,
                    CatalogueNumber = findBook.CatalogueNumber,
                    DateOfLend = DateTime.Today,
                    DateOfReturn = dateOfReturn
                };

                findStudent.LendedBooks.Add(lendedBook);
                findBook.IsLended = true;
                context.SaveChanges();
            }
            ReturnedOrLendedBook?.Invoke(EventArgs.Empty);
        }

        public static void ReturnBook(Student student, LendedBook lendedBook) {
            using (var context = new DbContext()) {
                var findLendedBook = context.LendedBooks.Find(lendedBook.Id);
                var findBook = context.Books.Find(findLendedBook.CatalogueNumber);

                findBook.IsLended = false;
                context.LendedBooks.Remove(findLendedBook);
                context.SaveChanges();
            }
            ReturnedOrLendedBook?.Invoke(EventArgs.Empty);
        }

        public static async Task<List<LendedBook>> LendedBooksToListAsync(Student student) {
            var result = await Task.Run(() => {
                using (var context = new DbContext()) {
                    var findStudent = context.Students.Find(student.PESEL);
                    return findStudent.LendedBooks;
                }
            });
            return result;
        }

    }

}