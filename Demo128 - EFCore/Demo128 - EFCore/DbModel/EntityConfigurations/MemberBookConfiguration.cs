using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo128___EFCore.DbModel.EntityConfigurations;

public class MemberBookConfiguration : IEntityTypeConfiguration<MemberBook>
{
    public void Configure(EntityTypeBuilder<MemberBook> builder)
    {
        builder.ToTable("MembersBooks");
        builder.HasOne(e => e.Member)
            .WithMany(e => e.Books)
            .HasForeignKey(e => e.MemberId);
        builder.HasOne(e => e.Book)
            .WithMany(e => e.Members)
            .HasForeignKey(e => e.BookId);
    }
}