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
using Demo128___EFCore.ViewModels.Authors;

namespace Demo128___EFCore.Views.Authors
{
    /// <summary>
    /// Interaction logic for AuthorEditor.xaml
    /// </summary>
    public partial class AuthorEditor : Window
    {
        private readonly AuthorEditorViewModel viewModel;
        public DbModel.Entities.Author? Author { get; set; }

        public AuthorEditor(AuthorEditorViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.DataContext = viewModel;
            viewModel.OnSubmitChangesSuccess += OnSubmitChangesSuccess;
            this.viewModel = viewModel;
            InitializeComponent();
        }


        private void OnSubmitChangesSuccess(object? sender, EventArgs e)
        {
            if (Author == null)
                Author = new Author();
            Author.Id = viewModel.Id ?? 0;
            Author.Name = viewModel.Name;
            DialogResult = true;
        }

        protected override void OnActivated(EventArgs e)
        {
            if (Author != null)
            {
                this.Title = "ویرایش نویسنده";
                this.viewModel.Id = Author.Id;
                this.viewModel.Name = Author.Name;
            }
            else
            {
                this.Title = "تعریف نویسنده جدید";
            }
            base.OnActivated(e);
        }
    }
}
