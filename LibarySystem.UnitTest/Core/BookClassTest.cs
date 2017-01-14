//using System;
//using LibarySystem.Core.Objects;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace LibarySystem.UnitTest.Core {

//    [TestClass]
//    public class BookClassTestClass {

//        [TestMethod]
//        public void BookConstructor() {
//            var book = new Book(1, "Pan Tadeusz", "Adam Mickiewicz");

//            var expectedID = 1;
//            var expectedName = "Pan Tadeusz";
//            var expectedAuthor = "Adam Mickiewicz";

//            Assert.AreEqual(expectedID, book.Id);
//            Assert.AreEqual(expectedName, book.Name);
//            Assert.AreEqual(expectedAuthor, book.Author);
//        }

//        [TestMethod]
//        public void BookIEnumerableTest() {
//            Book[] bookArray = {
//                new Book(1, "Pan Tadeusz", "Adam Mickiewicz"),
//                new Book(13, "Dwór cierni i róż. Tom 2. Dwór mgieł i furii", "Maas J. Sarah"),
//                new Book(124, "Zielone koktajle. 365 przepisów", "Adam Mickiewicz"),
//                new Book(51, "Dziady cz.III", "Adam Mickiewicz")
//            };

//            Assert.IsTrue(BookForEachTest(bookArray));
//        }

//        private bool BookForEachTest(Book[] bookArray) {
//            try {
//                foreach (var book in bookArray) Console.WriteLine(book);
//            }
//            catch (Exception e) {
//                Console.WriteLine(e.Message);
//                return false;
//            }
//            return true;
//        }

//    }

//}