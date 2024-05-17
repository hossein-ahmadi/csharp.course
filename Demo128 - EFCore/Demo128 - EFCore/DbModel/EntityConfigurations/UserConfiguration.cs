using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo128___EFCore.DbModel.EntityConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<Entities.User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(user => user.Username).IsUnique();
        builder.Property(e => e.Username).HasMaxLength(100);
        builder.Property(e => e.Password).HasMaxLength(100).IsUnicode(false);
        builder.Property(e => e.PasswordSalt).HasMaxLength(100).IsUnicode(false);
        builder.Property(e => e.Role).HasMaxLength(100).IsUnicode(false);
    }
}