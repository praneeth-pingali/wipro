using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagement.Tests
{
    [TestClass]
    public class LibraryTests
    {
        private Library _library;
        private Book _book;
        private Borrower _borrower;

        [TestInitialize]
        public void Setup()
        {
            _library = new Library();
            _book = new Book("Test Book", "Test Author", "123456");
            _borrower = new Borrower("Test Borrower", "CARD123");
            _library.AddBook(_book);
            _library.RegisterBorrower(_borrower);
        }

        [TestMethod]
        public void Test_AddBook()
        {
            Assert.AreEqual(1, _library.Books.Count);
            Assert.AreEqual("Test Book", _library.Books[0].Title);
        }

        [TestMethod]
        public void Test_RegisterBorrower()
        {
            Assert.AreEqual(1, _library.Borrowers.Count);
            Assert.AreEqual("Test Borrower", _library.Borrowers[0].Name);
        }

        [TestMethod]
        public void Test_BorrowBook()
        {
            _library.BorrowBook("123456", "CARD123");
            Assert.IsTrue(_book.IsBorrowed);
            Assert.AreEqual(1, _borrower.BorrowedBooks.Count);
        }

        [TestMethod]
        public void Test_ReturnBook()
        {
            _library.BorrowBook("123456", "CARD123");
            _library.ReturnBook("123456", "CARD123");
            Assert.IsFalse(_book.IsBorrowed);
            Assert.AreEqual(0, _borrower.BorrowedBooks.Count);
        }
    }
}
