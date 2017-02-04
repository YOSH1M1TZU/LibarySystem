using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using LibarySystem.DataModel.Operations;
using LibarySystem.UI.Adding_Windows.Books;
using LibarySystem.UI.Adding_Windows.Students;

namespace LibarySystem.UI {

    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            StudentOperations.StudentAddedOrDeleted += async (e) => { await RefreshStudentsDataGride(); };
            BookOperations.BookAddedOrDeleted += async (e) => { await RefreshBooksDataGride(); };
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

    }

}