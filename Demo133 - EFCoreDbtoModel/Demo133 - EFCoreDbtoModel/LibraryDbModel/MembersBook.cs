using System;
using System.Collections.Generic;

namespace Demo133___EFCoreDbtoModel.LibraryDbModel;

public partial class MembersBook
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int BookId { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
