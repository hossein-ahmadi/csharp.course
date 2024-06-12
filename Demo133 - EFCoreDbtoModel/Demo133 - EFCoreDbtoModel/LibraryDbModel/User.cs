using System;
using System.Collections.Generic;

namespace Demo133___EFCoreDbtoModel.LibraryDbModel;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime RegisterDate { get; set; }

    public string Role { get; set; } = null!;

    public bool Disabled { get; set; }

    public string PasswordSalt { get; set; } = null!;
}
