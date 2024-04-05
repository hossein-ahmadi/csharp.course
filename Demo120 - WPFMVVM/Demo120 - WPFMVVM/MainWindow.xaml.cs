using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Demo120___WPFMVVM.ViewModels;

namespace Demo120___WPFMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModels.PersonViewModel viewModel;
        public MainWindow()
        {
            viewModel = new PersonViewModel()
            {
                Firstname = "Hossein",
                Lastname = "Ahmadi"
            };
            this.DataContext = viewModel;
            InitializeComponent();
        }
    }
}