using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Demo128___EFCore.DbModel.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string PasswordSalt { get; set; }
    public DateTime RegisterDate { get; set; }
    public string Role { get; set; }
    public bool Disabled { get; set; }
}

public class Member
{
    public int Id { get; set; }
    public string NationalCode { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Fullname { get; set; }
    public DateTime RegistryDate { get; set; }
    public string Mobile { get; set; }
    
    public MemberAddress MemberAddress { get; set; }

    public List<MemberBook> Books { get; set; }
}

public class MemberAddress
{
    public Member Member { get; set; }
    public int MemberId { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
}

public class Author
{
    public int Id { get; set; }
    [MaxLength(200)]
    public string Name { get; set; }

    public List<Book> Books { get; set; }
}

public class BookCategory
{
    public int Id { get; set; }
    [MaxLength(200)]
    public string Title { get; set; }

    public List<Book> Books { get; set; } = new();
}

[Index(nameof(ISBN),IsUnique = true)]
public class Book
{
    public int Id { get; set; }
    public BookCategory Category { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }

    public List<Author> Authors { get; set; }
    public List<MemberBook> Members { get; set; }
}

public class MemberBook
{
    public int Id { get; set; }
    public Member Member { get; set; }
    public int MemberId { get; set; }
    public Book Book { get; set; }
    public int BookId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}