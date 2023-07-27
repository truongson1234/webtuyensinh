using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webtuyensinh.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
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
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_Menus_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admissions",
                columns: new[] { "Id", "Address", "CreatedAt", "Desire", "EducationLevel", "Name", "PhoneNumber", "TypeOfTraining", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Hà Nội", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5902), "......", 5, "Nguyễn Văn A1", "0369109466", 0, null },
                    { 2, "Đà Nẵng", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5907), "......", 5, "Nguyễn Văn A2", "0369109466", 0, null },
                    { 3, "Hà Nội", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5912), "......", 5, "Nguyễn Văn A3", "0369109466", 0, null },
                    { 4, "HCM", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5917), "......", 5, "Nguyễn Văn A4", "0369109466", 0, null },
                    { 5, "HCM", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6051), "......", 5, "Nguyễn Văn A5", "0369109466", 0, null },
                    { 6, "HCM", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6057), "......", 5, "Nguyễn Văn A6", "0369109466", 0, null },
                    { 7, "Hà Nội", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6062), "......", 5, "Nguyễn Văn A7", "0369109466", 0, null },
                    { 8, "Hà Nội", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6067), "......", 5, "Nguyễn Văn A8", "0369109466", 0, null },
                    { 9, "Đà Nẵng", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6072), "......", 5, "Nguyễn Văn A9", "0369109466", 0, null },
                    { 10, "Hà Nội", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6076), "......", 5, "Nguyễn Văn A10", "0369109466", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6148), "......", "Danh mục tin tức 1", null },
                    { 2, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6153), "......", "Danh mục tin tức 2", null },
                    { 3, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6157), "......", "Danh mục tin tức 3", null },
                    { 4, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6161), "......", "Danh mục tin tức 4", null },
                    { 5, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6165), "......", "Danh mục tin tức 5", null },
                    { 6, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6169), "......", "Danh mục tin tức 6", null },
                    { 7, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6173), "......", "Danh mục tin tức 7", null },
                    { 8, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6177), "......", "Danh mục tin tức 8", null },
                    { 9, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6181), "......", "Danh mục tin tức 9", null },
                    { 10, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6185), "......", "Danh mục tin tức 10", null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6353), "Home", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Password", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5363), "123123", "Admin", null, "user11" },
                    { 2, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5385), "123123", "User", null, "user22" },
                    { 3, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(5389), "123123", "User", null, "user33" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Action", "Controller", "CreatedAt", "DisplayCondition", "DisplayOrder", "GroupID", "Name", "ParentID", "Status", "Target", "URL", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6415), 0, 1, 1, "Giới thiệu", null, true, "_self", "/", null },
                    { 2, "Privacy", "Home", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6422), 0, 2, 1, "Privacy", null, true, "_blank", null, null },
                    { 3, null, null, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6428), 0, 3, 1, "Đăng nhập", null, true, "_self", "/login", null },
                    { 4, "Index", "Admin", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6435), 3, 4, 1, "Quản trị viên", null, true, "_self", null, null },
                    { 5, null, null, new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6441), 2, 5, 1, "Đăng xuất", null, true, "_self", "/logout", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Avartar", "CategoryId", "Content", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "news-avartar.jpg", 2, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6254), "......", "Bài viết 1", null },
                    { 2, "news-avartar.jpg", 2, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6260), "......", "Bài viết 2", null },
                    { 3, "news-avartar.jpg", 3, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6265), "......", "Bài viết 3", null },
                    { 4, "news-avartar.jpg", 3, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6269), "......", "Bài viết 4", null },
                    { 5, "news-avartar.jpg", 5, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6274), "......", "Bài viết 5", null },
                    { 6, "news-avartar.jpg", 5, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6278), "......", "Bài viết 6", null },
                    { 7, "news-avartar.jpg", 9, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6282), "......", "Bài viết 7", null },
                    { 8, "news-avartar.jpg", 8, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6287), "......", "Bài viết 8", null },
                    { 9, "news-avartar.jpg", 10, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6291), "......", "Bài viết 9", null },
                    { 10, "news-avartar.jpg", 1, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 27, 11, 25, 5, 255, DateTimeKind.Local).AddTicks(6296), "......", "Bài viết 10", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_GroupID",
                table: "MenuItems",
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
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
