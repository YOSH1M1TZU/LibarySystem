using System;
using System.Windows;
using LibarySystem.DataModel.Operations;

namespace LibarySystem.UI.Adding_Windows.Students {

    /// <summary>
    ///     Interaction logic for DeleteStudent.xaml
    /// </summary>
    public partial class DeleteStudentWindow : Window {

        public DeleteStudentWindow() {
            InitializeComponent();
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
                TXTBPesel.Text = string.Empty;
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