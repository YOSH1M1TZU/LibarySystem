using System;
using System.Windows;
using LibarySystem.DataModel.Operations;

namespace LibarySystem.UI.Adding_Windows.Books {

    /// <summary>
    ///     Interaction logic for DeleteBookWindow.xaml
    /// </summary>
    public partial class DeleteBookWindow : Window {

        public DeleteBookWindow() {
            InitializeComponent();
        }

        private void BTNDeleteBook_Click(object sender, RoutedEventArgs e) {
            if (TXTBookCatalogueNumber.Text == string.Empty) {
                MessageBox.Show("Podaj numer katalogowy ksiazki ktora chcesz usunac!", "Libary System",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            try {
                BookOperations.DeleteBook(TXTBookCatalogueNumber.Text);
                MessageBox.Show("Ksiazka zostala usunieta pomyslnie!", "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                TXTBookCatalogueNumber.Text = string.Empty;
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

    }

}