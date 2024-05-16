﻿using Demo128___EFCore.DbModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo128___EFCore.DbModel.EntityConfigurations;

public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
{
    public void Configure(EntityTypeBuilder<BookCategory> builder)
    {
        builder.HasData(new BookCategory()
        {
            Id = 1,
            Title = "کتاب های داستانی"
        });
    }
}