using System;
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

        private void BTNSingIn_Click(object sender, RoutedEventArgs e) {
            if (TXTLogin.Text == string.Empty) {
                MessageBox.Show("Podaj login!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (TXTPassword.Password == string.Empty) {
                MessageBox.Show("Podaj hasło!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try {
                if (AdministratorOperations.LoggingIn(TXTLogin.Text, TXTPassword.Password)) {
                    //If password and login correct
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }

}