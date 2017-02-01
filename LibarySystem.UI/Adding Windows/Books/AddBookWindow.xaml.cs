using System;
using System.Windows;
using LibarySystem.Core.Objects;
using LibarySystem.DataModel.Operations;

namespace LibarySystem.UI.Adding_Windows.Books {

    /// <summary>
    ///     Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window {

        public AddBookWindow() {
            InitializeComponent();
        }

        private void BTNAddBook_Click(object sender, RoutedEventArgs e) {
            if (TXTBookId.Text == string.Empty) {
                MessageBox.Show("Podaj poprawne ID ksiazki (liczba)!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
            if (TXTBookAuthor.Text == string.Empty) {
                MessageBox.Show("Podaj autora ksiazki!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
            if (TXTBookName.Text == string.Empty) {
                MessageBox.Show("Podaj tytul ksiazki!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            try {
                var book = new Book(TXTBookId.Text, TXTBookName.Text, TXTBookAuthor.Text);
                BookOperations.AddBook(book);
                MessageBox.Show("Ksiazka zostala dodana pomyslnie!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TXTBookId.Text = string.Empty;
                TXTBookAuthor.Text = string.Empty;
                TXTBookName.Text = string.Empty;
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

    }

}