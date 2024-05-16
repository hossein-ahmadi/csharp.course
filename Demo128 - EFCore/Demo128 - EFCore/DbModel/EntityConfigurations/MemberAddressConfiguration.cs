using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo128___EFCore.DbModel.EntityConfigurations;

public class MemberAddressConfiguration : IEntityTypeConfiguration<Entities.MemberAddress>
{
    public void Configure(EntityTypeBuilder<MemberAddress> builder)
    {
        builder.ToTable("MembersAddresses");
        builder.HasKey(e => e.MemberId);
        builder.HasOne(e => e.Member)
            .WithOne(e => e.MemberAddress)
            .HasForeignKey<MemberAddress>(e => e.MemberId);
        builder.Property(e => e.City).HasMaxLength(100);
        builder.Property(e => e.Address).HasMaxLength(500);
        builder.Property(e => e.PostalCode).HasMaxLength(10).IsUnicode(false);
    }
}