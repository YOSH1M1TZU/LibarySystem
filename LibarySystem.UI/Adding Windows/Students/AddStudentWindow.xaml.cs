using System;
using System.Windows;
using LibarySystem.Core.Objects;
using LibarySystem.DataModel.Operations;
using System.Windows.Input;

namespace LibarySystem.UI.Adding_Windows.Students {

    /// <summary>
    ///     Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window {

        public AddStudentWindow() {
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

            var student = new Student(TXTBPesel.Text, TXTBName.Text, TXTBSurname.Text, TXTBClass.Text,
                TXTBSecoundName.Text);

            try {
                StudentOperations.AddStudent(student);
                MessageBox.Show("Uczen zostal dodany poprawnie!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TXTBPesel.Text = string.Empty;
                TXTBName.Text = string.Empty;
                TXTBSurname.Text = string.Empty;
                TXTBClass.Text = string.Empty;
                TXTBSecoundName.Text = string.Empty;
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                throw exception;
            }
        }

        private void BTNExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}