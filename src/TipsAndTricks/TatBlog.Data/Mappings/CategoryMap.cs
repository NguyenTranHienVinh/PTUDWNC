﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TatBlog.Core.Entities;

namespace TatBlog.Data.Mappings;

internal class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(p => p.UrlSlug)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.ShowOnMenu)
            .IsRequired()
            .HasDefaultValue(false);
    }
}