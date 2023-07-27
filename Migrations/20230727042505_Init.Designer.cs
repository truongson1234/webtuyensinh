﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace webtuyensinh.Migrations
{
    [DbContext(typeof(WebtuyensinhDbContext))]
    [Migration("20230727042505_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webtuyensinh.Models.AdmissionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EducationLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfTraining")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Admissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Hà Nội",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5902),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A1",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Đà Nẵng",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5907),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A2",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Hà Nội",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5912),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A3",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 4,
                            Address = "HCM",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5917),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A4",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 5,
                            Address = "HCM",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6051),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A5",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 6,
                            Address = "HCM",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6057),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A6",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 7,
                            Address = "Hà Nội",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6062),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A7",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 8,
                            Address = "Hà Nội",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6067),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A8",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 9,
                            Address = "Đà Nẵng",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6072),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A9",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        },
                        new
                        {
                            Id = 10,
                            Address = "Hà Nội",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6076),
                            Desire = "......",
                            EducationLevel = 5,
                            Name = "Nguyễn Văn A10",
                            PhoneNumber = "0369109466",
                            TypeOfTraining = 0
                        });
                });

            modelBuilder.Entity("webtuyensinh.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6148),
                            Description = "......",
                            Name = "Danh mục tin tức 1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6153),
                            Description = "......",
                            Name = "Danh mục tin tức 2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6157),
                            Description = "......",
                            Name = "Danh mục tin tức 3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6161),
                            Description = "......",
                            Name = "Danh mục tin tức 4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6165),
                            Description = "......",
                            Name = "Danh mục tin tức 5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6169),
                            Description = "......",
                            Name = "Danh mục tin tức 6"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6173),
                            Description = "......",
                            Name = "Danh mục tin tức 7"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6177),
                            Description = "......",
                            Name = "Danh mục tin tức 8"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6181),
                            Description = "......",
                            Name = "Danh mục tin tức 9"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6185),
                            Description = "......",
                            Name = "Danh mục tin tức 10"
                        });
                });

            modelBuilder.Entity("webtuyensinh.Models.MenuItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Controller")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayCondition")
                        .HasColumnType("int");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int?>("GroupID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Target")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("URL")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GroupID");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6415),
                            DisplayCondition = 0,
                            DisplayOrder = 1,
                            GroupID = 1,
                            Name = "Giới thiệu",
                            Status = true,
                            Target = "_self",
                            URL = "/"
                        },
                        new
                        {
                            Id = 2,
                            Action = "Privacy",
                            Controller = "Home",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6422),
                            DisplayCondition = 0,
                            DisplayOrder = 2,
                            GroupID = 1,
                            Name = "Privacy",
                            Status = true,
                            Target = "_blank"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6428),
                            DisplayCondition = 0,
                            DisplayOrder = 3,
                            GroupID = 1,
                            Name = "Đăng nhập",
                            Status = true,
                            Target = "_self",
                            URL = "/login"
                        },
                        new
                        {
                            Id = 4,
                            Action = "Index",
                            Controller = "Admin",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6435),
                            DisplayCondition = 3,
                            DisplayOrder = 4,
                            GroupID = 1,
                            Name = "Quản trị viên",
                            Status = true,
                            Target = "_self"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6441),
                            DisplayCondition = 2,
                            DisplayOrder = 5,
                            GroupID = 1,
                            Name = "Đăng xuất",
                            Status = true,
                            Target = "_self",
                            URL = "/logout"
                        });
                });

            modelBuilder.Entity("webtuyensinh.Models.MenuModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6353),
                            Name = "Home"
                        });
                });

            modelBuilder.Entity("webtuyensinh.Models.PostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avartar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 2,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6254),
                            Description = "......",
                            Title = "Bài viết 1"
                        },
                        new
                        {
                            Id = 2,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 2,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6260),
                            Description = "......",
                            Title = "Bài viết 2"
                        },
                        new
                        {
                            Id = 3,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 3,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6265),
                            Description = "......",
                            Title = "Bài viết 3"
                        },
                        new
                        {
                            Id = 4,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 3,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6269),
                            Description = "......",
                            Title = "Bài viết 4"
                        },
                        new
                        {
                            Id = 5,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 5,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6274),
                            Description = "......",
                            Title = "Bài viết 5"
                        },
                        new
                        {
                            Id = 6,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 5,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6278),
                            Description = "......",
                            Title = "Bài viết 6"
                        },
                        new
                        {
                            Id = 7,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 9,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6282),
                            Description = "......",
                            Title = "Bài viết 7"
                        },
                        new
                        {
                            Id = 8,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 8,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6287),
                            Description = "......",
                            Title = "Bài viết 8"
                        },
                        new
                        {
                            Id = 9,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 10,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6291),
                            Description = "......",
                            Title = "Bài viết 9"
                        },
                        new
                        {
                            Id = 10,
                            Avartar = "news-avartar.jpg",
                            CategoryId = 1,
                            Content = "<p>Đây là nội dung bài viết</p>",
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6296),
                            Description = "......",
                            Title = "Bài viết 10"
                        });
                });

            modelBuilder.Entity("webtuyensinh.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5363),
                            Password = "123123",
                            Role = "Admin",
                            UserName = "user11"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5385),
                            Password = "123123",
                            Role = "User",
                            UserName = "user22"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5389),
                            Password = "123123",
                            Role = "User",
                            UserName = "user33"
                        });
                });

            modelBuilder.Entity("webtuyensinh.Models.MenuItemModel", b =>
                {
                    b.HasOne("webtuyensinh.Models.MenuModel", "Group")
                        .WithMany("Menus")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("webtuyensinh.Models.PostModel", b =>
                {
                    b.HasOne("webtuyensinh.Models.CategoryModel", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("webtuyensinh.Models.CategoryModel", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("webtuyensinh.Models.MenuModel", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}