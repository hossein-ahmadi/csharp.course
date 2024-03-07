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

namespace Demo117___WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TunnelingEvent_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!(RaiseTunnelingCheckbox.IsChecked ?? false))
            {
                return;
            }
            OutputTextBox.AppendText(sender.ToString() + " clicked! (Tunneling events)" + Environment.NewLine);
        }

        private void BubblingEvent_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!(RaiseBubblingCheckbox.IsChecked ?? false))
            {
                return;
            }
            OutputTextBox.AppendText(sender.ToString() + " clicked! (Bubbling events)" + Environment.NewLine);
            if (sender.Equals(MyLabel))
            {
                e.Handled = true;
            }
        }
    }
}