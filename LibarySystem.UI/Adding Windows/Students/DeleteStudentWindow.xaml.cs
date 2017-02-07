using System;
using System.Windows;
using LibarySystem.DataModel.Operations;
using System.Windows.Input;

namespace LibarySystem.UI.Adding_Windows.Students {

    /// <summary>
    ///     Interaction logic for DeleteStudent.xaml
    /// </summary>
    public partial class DeleteStudentWindow : Window {

        public DeleteStudentWindow() {
            InitializeComponent();
        }

        private void BTNDelete_Click(object sender, RoutedEventArgs e) {
            if (MessageBox.Show("Czy napewno chcesz usunąć studenta o peselu " + TXTBPesel.Text + "?", "Usuń", MessageBoxButton.YesNo, MessageBoxImage.Question).HasFlag(MessageBoxResult.Yes))
            {
                if (TXTBPesel.Text.Length < 11)
                {
                    MessageBox.Show("Podaj poprawny PESEL!", "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                try
                {
                    StudentOperations.DeleteStudentWithPesel(TXTBPesel.Text);
                    MessageBox.Show("Uczen zostal poprawnie usuniety!", "Libary System", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    TXTBPesel.Text = string.Empty;
                }
                catch (NullReferenceException exception)
                {
                    MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Libary System", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw new Exception();
                }
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