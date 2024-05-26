using System.Collections.ObjectModel;
using Demo128___EFCore.Base;
using Demo128___EFCore.DbModel;
using Demo128___EFCore.DbModel.Entities;

namespace Demo128___EFCore.ViewModels.Authors;

public class AuthorsListViewModel : ViewModelBase
{
    public AuthorsListViewModel(ApplicationDbContext dbContext)
    {
        this.Authors = new ObservableCollection<Author>(dbContext.Authors.OrderBy(c => c.Name).ToList());
    }

    public ObservableCollection<Author> Authors { get; set; }
}