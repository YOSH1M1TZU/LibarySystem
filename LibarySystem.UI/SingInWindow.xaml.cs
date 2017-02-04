using System;
using System.Runtime.ExceptionServices;
using System.Windows;
using LibarySystem.DataModel.Operations;

namespace LibarySystem.UI {

    /// <summary>
    ///     Interaction logic for SingInWindow.xaml
    /// </summary>
    public partial class SingInWindow : Window {

        public SingInWindow() {
            InitializeComponent();
        }

        private async void BTNSingIn_Click(object sender, RoutedEventArgs e) {
            if (TXTLogin.Text == string.Empty) {
                MessageBox.Show("Podaj login!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (TXTPassword.Password == string.Empty) {
                MessageBox.Show("Podaj hasło!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try {
                BTNSingIn.IsEnabled = false;
                if (await AdministratorOperations.LogInAsync(TXTLogin.Text, TXTPassword.Password)) {
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            catch (Exception exception) {
                var capturedException = ExceptionDispatchInfo.Capture(exception);
                BTNSingIn.IsEnabled = true;
                MessageBox.Show(capturedException.SourceException.Message, "Libary System", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

    }

}