using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webtuyensinh.Models;

public class WebtuyensinhDbContext : DbContext
{
    public WebtuyensinhDbContext (DbContextOptions<WebtuyensinhDbContext> options)
        : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModel>().HasData(
            new UserModel { Id = 1, UserName = "user11", Password = "123123", Role = "Admin", CreatedAt = DateTime.Now },
            new UserModel { Id = 2, UserName = "user22", Password = "123123", Role = "User", CreatedAt = DateTime.Now },
            new UserModel { Id = 3, UserName = "user33", Password = "123123", Role = "User", CreatedAt = DateTime.Now }
        );

        modelBuilder.Entity<AdmissionModel>().HasData(
            new AdmissionModel { Id = 1, Name = "Nguyễn Văn A1", Address = "Hà Nội", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 2, Name = "Nguyễn Văn A2", Address = "Đà Nẵng", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 3, Name = "Nguyễn Văn A3", Address = "Hà Nội", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 4, Name = "Nguyễn Văn A4", Address = "HCM", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 5, Name = "Nguyễn Văn A5", Address = "HCM", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 6, Name = "Nguyễn Văn A6", Address = "HCM", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 7, Name = "Nguyễn Văn A7", Address = "Hà Nội", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 8, Name = "Nguyễn Văn A8", Address = "Hà Nội", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 9, Name = "Nguyễn Văn A9", Address = "Đà Nẵng", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now },
            new AdmissionModel { Id = 10, Name = "Nguyễn Văn A10", Address = "Hà Nội", PhoneNumber = "0369109466", EducationLevel = LevelOptions.German, TypeOfTraining = TypeOptions.UniversityTransfer, Desire = "......", CreatedAt = DateTime.Now }
        );

        modelBuilder.Entity<CategoryModel>().HasData(
            new CategoryModel { Id = 1, Name = "Danh mục tin tức 1", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 2, Name = "Danh mục tin tức 2", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 3, Name = "Danh mục tin tức 3", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 4, Name = "Danh mục tin tức 4", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 5, Name = "Danh mục tin tức 5", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 6, Name = "Danh mục tin tức 6", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 7, Name = "Danh mục tin tức 7", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 8, Name = "Danh mục tin tức 8", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 9, Name = "Danh mục tin tức 9", Description = "......", CreatedAt = DateTime.Now },
            new CategoryModel { Id = 10, Name = "Danh mục tin tức 10", Description = "......", CreatedAt = DateTime.Now }
        );

        modelBuilder.Entity<PostModel>().HasData(
            new PostModel { Id = 1, CategoryId = 2, Title = "Bài viết 1", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 2, CategoryId = 2, Title = "Bài viết 2", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 3, CategoryId = 3, Title = "Bài viết 3", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 4, CategoryId = 3, Title = "Bài viết 4", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 5, CategoryId = 5, Title = "Bài viết 5", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 6, CategoryId = 5, Title = "Bài viết 6", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 7, CategoryId = 9, Title = "Bài viết 7", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 8, CategoryId = 8, Title = "Bài viết 8", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 9, CategoryId = 10, Title = "Bài viết 9", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now },
            new PostModel { Id = 10, CategoryId = 1, Title = "Bài viết 10", Avartar = "news-avartar.jpg", Content = "<p>Đây là nội dung bài viết</p>", Description = "......", CreatedAt = DateTime.Now }
        );

        modelBuilder.Entity<MenuGroupModel>().HasData(
            new MenuGroupModel { Id = 1, Name = "Home", CreatedAt = DateTime.Now }    
        );

        modelBuilder.Entity<MenuModel>().HasData(
            new MenuModel { Id = 1, Name = "Giới thiệu", GroupID = 1, URL = "/", Controller = null, Action = null, DisplayOrder = 1, DisplayCondition = Conditions.Normal, Status = true, Target = "_self", CreatedAt = DateTime.Now },
            new MenuModel { Id = 2, Name = "Privacy", GroupID = 1, URL = null, Controller = "Home", Action = "Privacy", DisplayOrder = 2, DisplayCondition = Conditions.Normal, Status = true, Target = "_blank", CreatedAt = DateTime.Now },
            new MenuModel { Id = 3, Name = "Đăng nhập", GroupID = 1, URL = "/login", Controller = null, Action = null, DisplayOrder = 3, DisplayCondition = Conditions.Normal, Status = true, Target = "_self", CreatedAt = DateTime.Now },
            new MenuModel { Id = 4, Name = "Quản trị viên", GroupID = 1, URL = null, Controller = "Admin", Action = "Index", DisplayOrder = 4, DisplayCondition = Conditions.RoleAdmin, Status = true, Target = "_self", CreatedAt = DateTime.Now },
            new MenuModel { Id = 5, Name = "Đăng xuất", GroupID = 1, URL = "/logout", Controller = null, Action = null, DisplayOrder = 5, DisplayCondition = Conditions.Authentication, Status = true, Target = "_self", CreatedAt = DateTime.Now }
        );
    }

    public DbSet<AdmissionModel> AdmissionModel { get; set; }
    public DbSet<UserModel> UserModel { get; set; }
    public DbSet<CategoryModel> CategoryModel { get; set; }
    public DbSet<PostModel> PostModel { get; set; }
    public DbSet<MenuGroupModel> MenuGroupModel { get; set; }
    public DbSet<MenuModel> MenuModel { get; set; }

}
