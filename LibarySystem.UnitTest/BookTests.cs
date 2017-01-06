using System;
using LibarySystem.Core.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LibarySystem.UnitTest {

    [TestClass]
    public class BookTestClass {

        [TestMethod]
        public void BookConstructor() {
            var book = new Book(1, "Pan Tadeusz", "Adam Mickiewicz", 1834);

            var expectedID = 1;
            var expectedName = "Pan Tadeusz";
            var expectedAuthor = "Adam Mickiewicz";
            var expectedReleaseDate = 1834;

            Assert.AreEqual(expectedID, book.ID);
            Assert.AreEqual(expectedName, book.Name);
            Assert.AreEqual(expectedAuthor, book.Author);
            Assert.AreEqual(expectedReleaseDate, book.ReleaseDate);
        }

        [TestMethod]
        public void BookIEnumerableTest() {
            Book[] bookArray = new Book[] {
                new Book(1, "Pan Tadeusz", "Adam Mickiewicz", 1834),
                new Book(13, "Dwór cierni i róż. Tom 2. Dwór mgieł i furii", "Maas J. Sarah", 2017),
                new Book(124, "Zielone koktajle. 365 przepisów", "Adam Mickiewicz", 2016),
                new Book(51, "Dziady cz.III", "Adam Mickiewicz", 1832),
            };

            Assert.IsTrue(BookForEachTest(bookArray));
        }

        private bool BookForEachTest(Book[] bookArray) {
            try {
                foreach (var book in bookArray) {
                    Console.WriteLine(book);
                }
            }
            catch (Exception e) {
                return false;
            }
            return true;  
        }

    }

}