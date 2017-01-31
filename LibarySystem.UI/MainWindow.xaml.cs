using System.Windows;
using LibarySystem.UI.Adding_Windows;

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

    }

}