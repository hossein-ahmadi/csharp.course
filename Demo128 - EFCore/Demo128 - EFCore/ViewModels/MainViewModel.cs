using System.Collections.ObjectModel;
using Demo128___EFCore.Base;

namespace Demo128___EFCore.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ObservableCollection<DbModel.Entities.MemberBook> Items { get; set; } = new();
}