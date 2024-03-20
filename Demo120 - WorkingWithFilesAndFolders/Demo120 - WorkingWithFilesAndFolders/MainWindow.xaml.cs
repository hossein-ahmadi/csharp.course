using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using Demo120___WorkingWithFilesAndFolders.Models;

namespace Demo120___WorkingWithFilesAndFolders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Models.ExplorerItemBase> items = new ObservableCollection<ExplorerItemBase>();

        public MainWindow()
        {
            InitializeComponent();

            foreach (var drive in Services.ExplorerServices.GetDrives())
            {
                items.Add(drive);
            }
            ItemsListView.ItemsSource = items;
        }
    }
}