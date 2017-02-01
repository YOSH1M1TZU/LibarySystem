using System;
using LibarySystem.Core.Objects;

namespace LibarySystem.DataModel.Operations {

    public static class BookOperations {

        public static void AddBook(Book book) {
            using (var context = new DbContext()) {
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public static void DeleteBook(string catalogueNumber) {
            using (var context = new DbContext()) {
                var book = context.Books.Find(catalogueNumber);
                if (book == null) throw new NullReferenceException("Nie znaleziono ksiazki w bazie danych");
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

    }

}