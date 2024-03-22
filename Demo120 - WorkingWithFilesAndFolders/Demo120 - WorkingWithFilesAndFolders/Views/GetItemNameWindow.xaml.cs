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

namespace Demo120___WorkingWithFilesAndFolders.Views
{
    /// <summary>
    /// Interaction logic for GetItemNameWindow.xaml
    /// </summary>
    public partial class GetItemNameWindow : Window
    {
        public GetItemNameWindow()
        {
            InitializeComponent();
        }

        private void OkButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text?.Trim()))
            {
                MessageBox.Show("You must enter a name!");
                return;
            }
            this.DialogResult = true;
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
