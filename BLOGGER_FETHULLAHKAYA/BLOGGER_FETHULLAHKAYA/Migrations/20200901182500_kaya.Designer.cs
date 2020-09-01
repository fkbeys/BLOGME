﻿// <auto-generated />
using System;
using BLOGGER_FETHULLAHKAYA.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BLOGGER_FETHULLAHKAYA.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200901182500_kaya")]
    partial class kaya
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BLOGS.Models.ARTICLES", b =>
                {
                    b.Property<int>("ARTICLE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ARTICLE_AUTHOR_ID")
                        .HasColumnType("int");

                    b.Property<string>("ARTICLE_CONTENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ARTICLE_CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("ARTICLE_DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ARTICLE_EDIT_AUTHOR_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ARTICLE_EDIT_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("ARTICLE_IMAGEURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ARTICLE_ISACTIVE")
                        .HasColumnType("bit");

                    b.Property<int>("ARTICLE_LIKE")
                        .HasColumnType("int");

                    b.Property<string>("ARTICLE_TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ARTICLE_ID");

                    b.ToTable("ARTICLES");
                });

            modelBuilder.Entity("BLOGS.Models.AUTHORS", b =>
                {
                    b.Property<int>("AUTOHOR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AUTHOR_CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<bool>("AUTHOR_ISACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("AUTHOR_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("AUTHOR_SURNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AUTOHOR_ID");

                    b.ToTable("AUTHORS");
                });
#pragma warning restore 612, 618
        }
    }
}
