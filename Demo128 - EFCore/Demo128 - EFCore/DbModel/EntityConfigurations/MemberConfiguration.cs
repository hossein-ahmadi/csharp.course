using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo128___EFCore.DbModel.EntityConfigurations;

public class MemberConfiguration : IEntityTypeConfiguration<Entities.Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.Property(e => e.NationalCode).HasMaxLength(10).IsUnicode(false);
        builder.Property(e => e.Firstname).HasMaxLength(100);
        builder.Property(e => e.Lastname).HasMaxLength(100);
        builder.Property(e => e.Mobile).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.Fullname).HasComputedColumnSql("[Firstname] + ' ' + [Lastname]");
    }
}