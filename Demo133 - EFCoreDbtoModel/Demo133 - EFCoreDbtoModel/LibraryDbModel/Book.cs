using System;
using System.Collections.Generic;

namespace Demo133___EFCoreDbtoModel.LibraryDbModel;

public partial class Book
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public virtual BookCategory Category { get; set; } = null!;

    public virtual ICollection<MembersBook> MembersBooks { get; set; } = new List<MembersBook>();

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
