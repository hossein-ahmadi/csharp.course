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
using Demo128___EFCore.ViewModels.Members;

namespace Demo128___EFCore.Views.Members
{
    /// <summary>
    /// Interaction logic for MemberEditor.xaml
    /// </summary>
    public partial class MemberEditor : Window
    {
        private readonly MemberEditorViewModel viewModel;
        public DbModel.Entities.Member? Member { get; set; }

        public MemberEditor(ViewModels.Members.MemberEditorViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.DataContext = viewModel;
            viewModel.OnSubmitChangesSuccess += OnSubmitChangesSuccess;
            InitializeComponent();
        }

        private void OnSubmitChangesSuccess(object? sender, EventArgs e)
        {
            if (Member == null)
                Member = new Member();
            Member.Id = viewModel.Id ?? 0;
            Member.NationalCode = viewModel.NationalCode;
            Member.Lastname = viewModel.Lastname;
            Member.Firstname = viewModel.Firstname;
            Member.Mobile = viewModel.Mobile;
            DialogResult = true;
        }

        protected override void OnActivated(EventArgs e)
        {
            if (Member != null)
            {
                this.Title = "ویرایش عضو";
                this.viewModel.Id = Member.Id;
                this.viewModel.Firstname = Member.Firstname;
                this.viewModel.Lastname = Member.Lastname;
                this.viewModel.NationalCode = Member.NationalCode;
                this.viewModel.Mobile = Member.Mobile;
            }
            else
            {
                this.Title = "تعریف عضو جدید";
            }
            base.OnActivated(e);
        }
    }
}
