using System;
using System.Collections.Generic;

namespace Demo133___EFCoreDbtoModel.LibraryDbModel;

public partial class Member
{
    public int Id { get; set; }

    public string NationalCode { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public DateTime RegistryDate { get; set; }

    public string Mobile { get; set; } = null!;

    public virtual MembersAddress? MembersAddress { get; set; }

    public virtual ICollection<MembersBook> MembersBooks { get; set; } = new List<MembersBook>();
}
