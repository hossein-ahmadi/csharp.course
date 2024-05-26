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
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;
using Demo128___EFCore.ViewModels.Members;
using Microsoft.Extensions.DependencyInjection;

namespace Demo128___EFCore.Views.Members
{
    /// <summary>
    /// Interaction logic for MembersList.xaml
    /// </summary>
    public partial class MembersList : Window
    {
        private readonly IServiceProvider services;
        private readonly MemberListViewModel viewModel;

        public MembersList(ViewModels.Members.MemberListViewModel viewModel, IServiceProvider services)
        {
            this.viewModel = viewModel;
            this.services = services;
            this.DataContext = viewModel;
            InitializeComponent();
        }

        private void AddNewMemberButton_OnClick(object sender, RoutedEventArgs e)
        {
            var editorWindow = services.GetService<Views.Members.MemberEditor>();
            if (editorWindow != null)
            {
                var dialogResult = editorWindow.ShowDialog();
                if ((dialogResult ?? false) && editorWindow.Member != null)
                {
                    viewModel.Members.Add(editorWindow.Member);
                }
            }
        }

        private void EditMemberWindow_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedMember = MembersDataGrid.SelectedItem as DbModel.Entities.Member;
            if (selectedMember == null)
            {
                MessageBox.Show("ابتدا یک عضو را انتخاب کنید");
                return;
            }

            var editorWindow = services.GetService<Views.Members.MemberEditor>();
            editorWindow.Member = selectedMember;
            editorWindow.ShowDialog();
            MembersDataGrid.ItemsSource = null;
            MembersDataGrid.ItemsSource = viewModel.Members;
        }

        private void DeleteMemberButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (MembersDataGrid.SelectedItem == null)
            {
                MessageBox.Show("ابتدا یک عضو را انتخاب کنید");
                return;
            }
            if (MessageBox.Show("آیا از حذف رکورد مطمئن هستید؟", "حذف رکورد", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var member = (Member)MembersDataGrid.SelectedItem;
                var dbContext = services.GetService<ApplicationDbContext>();
                var memberToRemove = dbContext.Members.Find(member.Id);
                dbContext.Members.Remove(memberToRemove);
                dbContext.SaveChanges();
                viewModel.Members.Remove(member);
            }
        }
    }
}
