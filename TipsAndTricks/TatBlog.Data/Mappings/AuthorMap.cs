﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TatBlog.Core.Entities;

namespace TatBlog.Data.Mappings;

internal class AuthorMap : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.FullName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.UrlSlug)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(a => a.ImageUrl)
            .HasMaxLength(500);

        builder.Property(a => a.Email) 
            .HasMaxLength(150);

        builder.Property(a => a.JoinedDate)
            .HasColumnType("datetime");

        builder.Property(a => a.Notes)
            .HasMaxLength (500);

    }
}