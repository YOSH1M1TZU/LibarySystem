using System.Windows;
using LibarySystem.UI.Adding_Windows.Books;
using LibarySystem.UI.Adding_Windows.Students;

namespace LibarySystem.UI {

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
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

    }

}