using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo133___EFCoreDbtoModel.LibraryDbModel;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MembersAddress> MembersAddresses { get; set; }

    public virtual DbSet<MembersBook> MembersBooks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=LibraryDb; Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasMany(d => d.Books).WithMany(p => p.Authors)
                .UsingEntity<Dictionary<string, object>>(
                    "BooksAuthor",
                    r => r.HasOne<Book>().WithMany().HasForeignKey("BooksId"),
                    l => l.HasOne<Author>().WithMany().HasForeignKey("AuthorsId"),
                    j =>
                    {
                        j.HasKey("AuthorsId", "BooksId");
                        j.ToTable("BooksAuthors");
                        j.HasIndex(new[] { "BooksId" }, "IX_BooksAuthors_BooksId");
                    });
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Books_CategoryId");

            entity.HasIndex(e => e.Isbn, "IX_Books_ISBN").IsUnique();

            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Category).WithMany(p => p.Books).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.Property(e => e.Firstname).HasMaxLength(100);
            entity.Property(e => e.Fullname)
                .HasMaxLength(201)
                .HasComputedColumnSql("(([Firstname]+' ')+[Lastname])", false);
            entity.Property(e => e.Lastname).HasMaxLength(100);
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NationalCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MembersAddress>(entity =>
        {
            entity.HasKey(e => e.MemberId);

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Member).WithOne(p => p.MembersAddress).HasForeignKey<MembersAddress>(d => d.MemberId);
        });

        modelBuilder.Entity<MembersBook>(entity =>
        {
            entity.HasIndex(e => e.BookId, "IX_MembersBooks_BookId");

            entity.HasIndex(e => e.MemberId, "IX_MembersBooks_MemberId");

            entity.HasOne(d => d.Book).WithMany(p => p.MembersBooks).HasForeignKey(d => d.BookId);

            entity.HasOne(d => d.Member).WithMany(p => p.MembersBooks).HasForeignKey(d => d.MemberId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Username, "IX_Users_Username").IsUnique();

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PasswordSalt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Role)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
