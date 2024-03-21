using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Demo120___WorkingWithFilesAndFolders.Models;
using Demo120___WorkingWithFilesAndFolders.Services;

namespace Demo120___WorkingWithFilesAndFolders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Models.ExplorerItemBase> items = new ObservableCollection<ExplorerItemBase>();

        public string? CurrentPath { get; set; } = null;

        public MainWindow()
        {
            InitializeComponent();
            LoadCurrentPath();
            ItemsListView.ItemsSource = items;
        }

        private void LoadCurrentPath()
        {
            items.Clear();
            if (!string.IsNullOrEmpty(CurrentPath))
            {
                items.Add(new Models.ExplorerBackItem()
                {
                    Name = ".."
                });
            }
            if (string.IsNullOrEmpty(CurrentPath))
            {
                foreach (var drive in Services.ExplorerServices.GetDrives())
                {
                    items.Add(drive);
                }
            }
            else
            {
                var folders = ExplorerServices.GetFolders(CurrentPath).OrderBy(d => d.Name);
                foreach (var folder in folders)
                {
                    items.Add(folder);
                }

                var files = ExplorerServices.GetFiles(CurrentPath).OrderBy(f => f.Name);
                foreach (var file in files)
                {
                    items.Add(file);
                }
            }
        }

        private void ItemsListView_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItem = ItemsListView.SelectedItem as ExplorerItemBase;

            if (selectedItem != null)
            {
                if (selectedItem is ExplorerBackItem && CurrentPath.Equals(Path.GetPathRoot(CurrentPath),
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    CurrentPath = null;
                }
                else
                {
                    if (string.IsNullOrEmpty(CurrentPath))
                    {
                        CurrentPath = selectedItem.Name;
                    }
                    else
                    {
                        CurrentPath = Path.GetFullPath(Path.Combine(CurrentPath, selectedItem.Name));
                    }
                }
                LoadCurrentPath();
            }
        }
    }
}