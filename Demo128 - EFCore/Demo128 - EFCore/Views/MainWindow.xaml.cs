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
using Demo128___EFCore.DbModel.Entities;
using Demo128___EFCore.Views.Members;
using Microsoft.Extensions.DependencyInjection;

namespace Demo128___EFCore.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IServiceProvider services;

        public MainWindow(ViewModels.MainViewModel viewModel, IServiceProvider services)
        {
            this.services = services;
            this.DataContext = viewModel;
            viewModel.Items.Add(new MemberBook()
            {
                Id = 1,
            });
            InitializeComponent();
        }

        private void MembersMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var membersList = services.GetService<Views.Members.MembersList>();
            membersList.ShowDialog();
        }

        private void AuthorsMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var authorsList = services.GetService<Views.Authors.AuthorsList>();
            authorsList.ShowDialog();
        }

        private void BookCategoriesMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var categoriesList = services.GetService<Views.BookCategories.BookCategoriesList>();
            categoriesList.ShowDialog();
        }
    }
}
