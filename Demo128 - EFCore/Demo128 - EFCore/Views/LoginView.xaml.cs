using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Demo128___EFCore.ViewModels;

namespace Demo128___EFCore.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private readonly LoginViewModel viewModel;

        public LoginView(LoginViewModel viewModel, MainWindow mainWindow)
        {
            this.viewModel = viewModel;
            this.viewModel.OnSuccessLogin += (sender, args) =>
            {
                mainWindow.Show();
                this.Close();
            };
            this.DataContext = this.viewModel;
            InitializeComponent();
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            viewModel.Password = ((PasswordBox)sender).Password;
        }
    }
}
