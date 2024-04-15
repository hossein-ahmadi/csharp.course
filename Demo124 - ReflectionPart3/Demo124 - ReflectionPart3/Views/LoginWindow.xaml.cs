using System.Windows;
using System.Windows.Controls;
using Demo124___ReflectionPart3.ViewModels;

namespace Demo124___ReflectionPart3.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LoginViewModel viewModel;

        public LoginWindow(ViewModels.LoginViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.DataContext = this.viewModel;
            InitializeComponent();
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            viewModel.Password = ((PasswordBox)sender).Password;
        }
    }
}