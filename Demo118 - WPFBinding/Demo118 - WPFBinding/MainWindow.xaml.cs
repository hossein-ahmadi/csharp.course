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
using Demo118___WPFBinding.Models;

namespace Demo118___WPFBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person = new Person()
        {
            Firstname = "Hossein",
            Lastname = "Ahmadi",
            Email = "hossein@ahmadi.com"
        };

    public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void ShowNameButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{person.Firstname} {person.Lastname}");
        }
    }
}