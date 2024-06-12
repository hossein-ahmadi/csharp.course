using System;
using System.Collections.Generic;

namespace Demo133___EFCoreDbtoModel.LibraryDbModel;

public partial class MembersAddress
{
    public int MemberId { get; set; }

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
