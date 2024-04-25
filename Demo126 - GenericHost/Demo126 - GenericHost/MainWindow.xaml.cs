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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Demo126___GenericHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IConfiguration configuration;
        private readonly IHostEnvironment environment;
        private readonly ILogger<MainWindow> logger;

        public MainWindow(IConfiguration configuration, IHostEnvironment environment, ILogger<MainWindow> logger)
        {
            this.configuration = configuration;
            this.environment = environment;
            this.logger = logger;
            InitializeComponent();
        }

        private void ShowNameButton_OnClick(object sender, RoutedEventArgs e)
        {
            logger.LogInformation("Show name button clicked!");
            var env = environment.EnvironmentName;
            var name = configuration["Name"];
            if (env == "Production")
            {
                MessageBox.Show($"Hi {name}, welcome to my application!");
            }
            else if(env == "Development")
            {
                MessageBox.Show($"Hi {name}, welcome to my application! this is from test development");
            }
        }
    }
}