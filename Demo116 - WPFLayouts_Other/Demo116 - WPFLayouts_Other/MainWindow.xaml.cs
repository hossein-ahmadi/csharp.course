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

namespace Demo116___WPFLayouts_Other
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

        private void UniformGridButton_OnClick(object sender, RoutedEventArgs e)
        {
            UniformGridWindow gridWindow = new UniformGridWindow();

            gridWindow.Show();
        }

        private void CanvasButton_OnClick(object sender, RoutedEventArgs e)
        {
            CanvasWindow canvasWindow = new CanvasWindow();

            canvasWindow.Show();
        }

        private void GridSplitterButton_OnClick(object sender, RoutedEventArgs e)
        {
            GridSplitterWindow splitterWindow = new GridSplitterWindow();

            splitterWindow.Show();
        }
    }
}