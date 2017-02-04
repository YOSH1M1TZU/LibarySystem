using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibarySystem.Core.Delegates;
using LibarySystem.Core.Objects;

namespace LibarySystem.DataModel.Operations {

    public static class BookOperations {

        public static event ChangedEventHandler BookAddedOrDeleted;

        public static void AddBook(Book book) {
            using (var context = new DbContext()) {
                context.Books.Add(book);
                context.SaveChanges();
                BookAddedOrDeleted(EventArgs.Empty);
            }
        }

        public static void DeleteBook(string catalogueNumber) {
            using (var context = new DbContext()) {
                var book = context.Books.Find(catalogueNumber);
                if (book == null) throw new NullReferenceException("Nie znaleziono ksiazki w bazie danych");
                context.Books.Remove(book);
                context.SaveChanges();
                BookAddedOrDeleted(EventArgs.Empty);
            }
        }

        public static async Task<List<Book>> BooksToListAsync() {
            var result = await Task.Run(() => {
                using (var context = new DbContext()) {
                    var listOfBooks = new List<Book>();
                    listOfBooks = context.Books.Where(s => s.CatalogueNumber != null).ToList();
                    return listOfBooks;
                }
            });
            return result;
        }

    }

}