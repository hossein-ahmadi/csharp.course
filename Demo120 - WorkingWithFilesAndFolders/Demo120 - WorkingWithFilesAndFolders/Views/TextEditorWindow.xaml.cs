using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for TextEditorWindow.xaml
    /// </summary>
    public partial class TextEditorWindow : Window
    {
        public string FilePath { get; set; }

        public TextEditorWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(FilePath, EditorTextBox.Text);
        }

        private void TextEditorWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var fileContent = File.ReadAllText(FilePath);

            EditorTextBox.Text = fileContent;
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
