using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webtuyensinh.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationLevel = table.Column<int>(type: "int", nullable: false),
                    TypeOfTraining = table.Column<int>(type: "int", nullable: false),
                    Desire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avartar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Controller = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Action = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    DisplayCondition = table.Column<int>(type: "int", nullable: false),
                    Target = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_MenuGroups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "MenuGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Admissions",
                columns: new[] { "Id", "Address", "CreatedAt", "Desire", "EducationLevel", "Name", "PhoneNumber", "TypeOfTraining", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Hà Nội", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2109), "......", 5, "Nguyễn Văn A1", "0369109466", 0, null },
                    { 2, "Đà Nẵng", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2115), "......", 5, "Nguyễn Văn A2", "0369109466", 0, null },
                    { 3, "Hà Nội", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2120), "......", 5, "Nguyễn Văn A3", "0369109466", 0, null },
                    { 4, "HCM", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2124), "......", 5, "Nguyễn Văn A4", "0369109466", 0, null },
                    { 5, "HCM", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2129), "......", 5, "Nguyễn Văn A5", "0369109466", 0, null },
                    { 6, "HCM", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2134), "......", 5, "Nguyễn Văn A6", "0369109466", 0, null },
                    { 7, "Hà Nội", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2139), "......", 5, "Nguyễn Văn A7", "0369109466", 0, null },
                    { 8, "Hà Nội", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2143), "......", 5, "Nguyễn Văn A8", "0369109466", 0, null },
                    { 9, "Đà Nẵng", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2148), "......", 5, "Nguyễn Văn A9", "0369109466", 0, null },
                    { 10, "Hà Nội", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2153), "......", 5, "Nguyễn Văn A10", "0369109466", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2215), "......", "Danh mục tin tức 1", null },
                    { 2, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2221), "......", "Danh mục tin tức 2", null },
                    { 3, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2224), "......", "Danh mục tin tức 3", null },
                    { 4, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2228), "......", "Danh mục tin tức 4", null },
                    { 5, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2232), "......", "Danh mục tin tức 5", null },
                    { 6, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2236), "......", "Danh mục tin tức 6", null },
                    { 7, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2240), "......", "Danh mục tin tức 7", null },
                    { 8, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2244), "......", "Danh mục tin tức 8", null },
                    { 9, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2248), "......", "Danh mục tin tức 9", null },
                    { 10, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2251), "......", "Danh mục tin tức 10", null }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2517), "Home", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Password", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(1588), "123123", "Admin", null, "user11" },
                    { 2, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(1612), "123123", "User", null, "user22" },
                    { 3, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(1616), "123123", "User", null, "user33" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Action", "Controller", "CreatedAt", "DisplayCondition", "DisplayOrder", "GroupID", "Name", "Status", "Target", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2563), 0, 1, 1, "Giới thiệu", true, "_self", "/", null },
                    { 2, "Privacy", "Home", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2570), 0, 2, 1, "Privacy", true, "_blank", null, null },
                    { 3, null, null, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2576), 0, 3, 1, "Đăng nhập", true, "_self", "/login", null },
                    { 4, "Index", "Admin", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2582), 2, 4, 1, "Quản trị viên", true, "_self", null, null },
                    { 5, null, null, new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2589), 1, 5, 1, "Giới thiệu", true, "_self", "/logout", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Avartar", "CategoryId", "Content", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "news-avartar.jpg", 2, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2310), "......", "Bài viết 1", null },
                    { 2, "news-avartar.jpg", 2, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2316), "......", "Bài viết 2", null },
                    { 3, "news-avartar.jpg", 3, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2321), "......", "Bài viết 3", null },
                    { 4, "news-avartar.jpg", 3, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2325), "......", "Bài viết 4", null },
                    { 5, "news-avartar.jpg", 5, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2330), "......", "Bài viết 5", null },
                    { 6, "news-avartar.jpg", 5, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2334), "......", "Bài viết 6", null },
                    { 7, "news-avartar.jpg", 9, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2338), "......", "Bài viết 7", null },
                    { 8, "news-avartar.jpg", 8, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2343), "......", "Bài viết 8", null },
                    { 9, "news-avartar.jpg", 10, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2347), "......", "Bài viết 9", null },
                    { 10, "news-avartar.jpg", 1, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 26, 15, 2, 7, 729, DateTimeKind.Local).AddTicks(2352), "......", "Bài viết 10", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_GroupID",
                table: "Menus",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admissions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MenuGroups");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
