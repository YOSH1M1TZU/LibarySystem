using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using LibarySystem.Core.Objects;
using LibarySystem.DataModel.Operations;
using LibarySystem.UI.Adding_Windows.Books;
using LibarySystem.UI.Adding_Windows.Students;

namespace LibarySystem.UI {

    public partial class MainWindow : Window {

        private Book selectedBook;

        private Student selectedStudent;

        private LendedBook selectedLendedBook;

        public MainWindow() {
            InitializeComponent();
            StudentOperations.StudentAddedOrDeleted += async e => { await RefreshStudentsDataGride(); };
            BookOperations.BookAddedOrDeleted += async e => { await RefreshBooksDataGride(); };
            LendedBookOperations.ReturnedOrLendedBook += async e => {
                await RefreshLendDataGride();
                await RefreshBooksDataGride();
            };
        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e) {
            var addStudentWindow = new AddStudentWindow();
            addStudentWindow.Show();
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e) {
            var deleteStudentWindow = new DeleteStudentWindow();
            deleteStudentWindow.Show();
        }

        private void BtnAddBook_Click(object sender, RoutedEventArgs e) {
            var addBookWindow = new AddBookWindow();
            addBookWindow.Show();
        }

        private void BtnDeleteBook_Click(object sender, RoutedEventArgs e) {
            var delteBookWindow = new DeleteBookWindow();
            delteBookWindow.Show();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e) {
            await RefreshDatasGrides();
        }

        private async Task RefreshDatasGrides() {
            await RefreshStudentsDataGride();
            await RefreshBooksDataGride();
        }

        private async Task RefreshStudentsDataGride() {
            var studentViewSource =
                (CollectionViewSource) FindResource("studentViewSource");
            studentViewSource.Source = await StudentOperations.StudentsToListAsync();
        }

        private async Task RefreshBooksDataGride() {
            var bookViewSource =
                (CollectionViewSource) FindResource("bookViewSource");
            bookViewSource.Source = await BookOperations.BooksToListAsync();
        }

        private async void studentDataGrid_SelectionChanged(object sender,
            SelectionChangedEventArgs e) {
            if (studentDataGrid.CurrentCell.Item == DependencyProperty.UnsetValue) return;

            try {
                selectedStudent = (Student) studentDataGrid.CurrentCell.Item;
                TXTSelectedStudent.Text = selectedStudent.PESEL;
                await RefreshLendDataGride();
            }
            catch (InvalidCastException) {
                selectedBook = null;
            }
            catch (Exception) {
                throw new NotImplementedException();
            }
        }

        private void bookDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (bookDataGrid.CurrentCell.Item == DependencyProperty.UnsetValue) return;
            try {
                selectedBook = (Book) bookDataGrid.CurrentCell.Item;
                TXTSelectedBook.Text = selectedBook.CatalogueNumber;
            }
            catch (InvalidCastException) {
                selectedBook = null;
            }
            catch (Exception) {
                throw new NotImplementedException();
            }
        }

        private void BTNAddBookToStudent_Click(object sender, RoutedEventArgs e) {
            if (DPDateOfReturn.SelectedDate != null && selectedStudent != null && selectedBook != null)
                LendedBookOperations.LendBook(selectedStudent, selectedBook, DPDateOfReturn.SelectedDate.Value);
        }

        private async Task RefreshLendDataGride() {
            var lendedBookViewSource =
                (CollectionViewSource) FindResource("lendedBookViewSource");
            lendedBookViewSource.Source = await LendedBookOperations.LendedBooksToListAsync(selectedStudent);
        }

        private void lendedBookDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (lendedBookDataGrid.CurrentCell.Item == DependencyProperty.UnsetValue) return;
            try {
                selectedLendedBook = (LendedBook) lendedBookDataGrid.CurrentCell.Item;
            }
            catch (InvalidCastException) {
                selectedLendedBook = null;
            }
            catch (Exception) {
                throw new NotImplementedException();
            }
        }

        private void BTNReturnBook_Click(object sender, RoutedEventArgs e) {
            if (selectedStudent != null && selectedLendedBook != null)
                LendedBookOperations.ReturnBook(selectedStudent, selectedLendedBook);
        }

    }

}