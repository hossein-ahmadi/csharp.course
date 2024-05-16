using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo128___EFCore.DbModel.EntityConfigurations;

public class BookConfiguration : IEntityTypeConfiguration<Entities.Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasOne(e => e.Category)
            .WithMany(e => e.Books)
            .HasForeignKey(e => e.CategoryId);

        builder.HasMany(e => e.Authors)
            .WithMany(e => e.Books)
            .UsingEntity("BooksAuthors");

        builder.Property(e => e.Title).HasMaxLength(200);
        builder.Property(e => e.ISBN).HasMaxLength(20).IsUnicode(false);

        var books = Enumerable.Range(1, 100).Select(n => new Book
        {
            Id = n,
            Title = "کتاب شماره " + n,
            ISBN = "B12345_" + n,
            CategoryId = 1
        });

        builder.HasData(books);
    }
}