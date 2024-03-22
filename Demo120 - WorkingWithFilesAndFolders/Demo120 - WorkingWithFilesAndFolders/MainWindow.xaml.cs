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
                else if (selectedItem is ExplorerFileItem fileItem)
                {
                    var extension = Path.GetExtension(fileItem.Name)?.Trim().ToLower();

                    if (extension == ".txt")
                    {
                        var editorWindow = new Views.TextEditorWindow();
                        editorWindow.FilePath = Path.Combine(CurrentPath, fileItem.Name);
                        editorWindow.ShowDialog();
                    }
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

        private void NewFolderButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentPath))
            {
                MessageBox.Show("You can't create folder here!");
                return;
            }
            var getNameWindow = new Views.GetItemNameWindow();

            getNameWindow.ShowDialog();

            if (getNameWindow.DialogResult ?? false)
            {
                var directoryPath = Path.Combine(CurrentPath, getNameWindow.NameTextBox.Text);

                if (Directory.Exists(directoryPath))
                {
                    MessageBox.Show($"Directory {getNameWindow.NameTextBox.Text} already exists!");
                    return;
                }

                Directory.CreateDirectory(directoryPath);

                LoadCurrentPath();
            }
        }

        private void NewFileButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentPath))
            {
                MessageBox.Show("You can't create file here!");
                return;
            }

            var getNameWindow = new Views.GetItemNameWindow();

            getNameWindow.ShowDialog();

            if (getNameWindow.DialogResult ?? false)
            {
                var filePath = Path.Combine(CurrentPath, getNameWindow.NameTextBox.Text);

                if (File.Exists(filePath))
                {
                    MessageBox.Show($"File {getNameWindow.NameTextBox.Text} already exists!");
                    return;
                }

                using var stream = File.Create(filePath);

                LoadCurrentPath();
            }
        }
    }
}