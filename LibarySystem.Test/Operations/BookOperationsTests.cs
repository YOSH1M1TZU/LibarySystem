using System;
using LibarySystem.Core.Objects;
using LibarySystem.DataModel;
using LibarySystem.DataModel.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibarySystem.Test.Operations {

    [TestClass]
    public class BookOperationsTests {
        [TestMethod]
        public void AddAndDeleteBookTest() {

            using (var context = new DbContext()) {
                var book = new Book("test", "test", "test");
                BookOperations.AddBook(book);

                var bookInDb = context.Books.Find(book.CatalogueNumber);

                if (bookInDb == null) throw new NullReferenceException();

                Assert.AreEqual(book.CatalogueNumber, bookInDb.CatalogueNumber);
                Assert.AreEqual(book.Name, bookInDb.Name);
                Assert.AreEqual(book.Author, bookInDb.Author);
                Assert.IsTrue(DeleteBook(book.CatalogueNumber));
            }
        }

        private bool DeleteBook(string catalogueNumber) {
            try {
                BookOperations.DeleteBook(catalogueNumber);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

    }

}