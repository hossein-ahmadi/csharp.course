using System.Collections.ObjectModel;
using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;

namespace Demo128___EFCore.ViewModels.Members;

public class MemberListViewModel : ViewModelBase
{
    public MemberListViewModel(ApplicationDbContext dbContext)
    {
        this.Members = new ObservableCollection<Member>(dbContext.Members.ToList());
    }

    public ObservableCollection<DbModel.Entities.Member> Members { get; set; } = new();
}