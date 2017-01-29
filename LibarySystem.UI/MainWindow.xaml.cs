using System;
using System.Windows;
using LibarySystem.Core.Objects;
using LibarySystem.DataModel;

namespace LibarySystem.UI {

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void BTNAdd_Click(object sender, RoutedEventArgs e) {
            if (TXTBPesel.Text.Length < 11) {
                MessageBox.Show("Podaj poprawny PESEL!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TXTBName.Text == string.Empty) {
                MessageBox.Show("Podaj Imie!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TXTBSurname.Text == string.Empty) {
                MessageBox.Show("Podaj Nazwisko!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TXTBClass.Text == string.Empty) {
                MessageBox.Show("Podaj klase do jakiej chodzi uczen!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            var student = new Student(TXTBPesel.Text, TXTBName.Text, TXTBSurname.Text, TXTBClass.Text);

            try {
                StudentOperations.AddStudent(student);
                MessageBox.Show("Uczen zostal dodany poprawnie!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                throw exception;
            }
        }

        private void BTNDelete_Click(object sender, RoutedEventArgs e) {
            if (TXTBPesel.Text.Length < 11) {
                MessageBox.Show("Podaj poprawny PESEL!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try {
                StudentOperations.DeleteStudentWithPesel(TXTBPesel.Text);
                MessageBox.Show("Uczen zostal poprawnie usuniety!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (NullReferenceException exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                throw new Exception();
            }
        }

    }

}