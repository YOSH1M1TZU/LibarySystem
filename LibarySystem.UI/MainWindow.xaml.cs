using System;
using System.Text;
using System.Windows;
using LibarySystem.Core.Objects;
using LibarySystem.SQLDataReader;

namespace LibarySystem.UI {

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void BTNAdd_Click(object sender, RoutedEventArgs e) {
            var sqlWorker = new SqlWorker();
            if (TXTBPesel.Text.Length < 11) {
                MessageBox.Show("Podaj poprawny PESEL!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TXTBName.Text == String.Empty) {
                MessageBox.Show("Podaj Imie!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TXTBSurname.Text == String.Empty) {
                MessageBox.Show("Podaj Nazwisko!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (TXTBClass.Text == String.Empty) {
                MessageBox.Show("Podaj klase do jakiej chodzi uczen!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            try {
                var studentToAdd = new Student(TXTBPesel.Text, TXTBName.Text, TXTBSurname.Text, TXTBClass.Text);

                sqlWorker.AddStudent(studentToAdd);
                MessageBox.Show("Uczen zostal poprawnie dodany!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

        }

    }

}