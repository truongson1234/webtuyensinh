using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webtuyensinh.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admission",
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
                    table.PrimaryKey("PK_Admission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
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
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
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
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
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
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admission",
                columns: new[] { "Id", "Address", "CreatedAt", "Desire", "EducationLevel", "Name", "PhoneNumber", "TypeOfTraining", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Hà Nội", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2670), "......", 5, "Nguyễn Văn A1", "0369109466", 0, null },
                    { 2, "Đà Nẵng", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2675), "......", 5, "Nguyễn Văn A2", "0369109466", 0, null },
                    { 3, "Hà Nội", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2680), "......", 5, "Nguyễn Văn A3", "0369109466", 0, null },
                    { 4, "HCM", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2685), "......", 5, "Nguyễn Văn A4", "0369109466", 0, null },
                    { 5, "HCM", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2849), "......", 5, "Nguyễn Văn A5", "0369109466", 0, null },
                    { 6, "HCM", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2854), "......", 5, "Nguyễn Văn A6", "0369109466", 0, null },
                    { 7, "Hà Nội", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2859), "......", 5, "Nguyễn Văn A7", "0369109466", 0, null },
                    { 8, "Hà Nội", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2865), "......", 5, "Nguyễn Văn A8", "0369109466", 0, null },
                    { 9, "Đà Nẵng", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2871), "......", 5, "Nguyễn Văn A9", "0369109466", 0, null },
                    { 10, "Hà Nội", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2877), "......", 5, "Nguyễn Văn A10", "0369109466", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2950), "......", "Danh mục tin tức 1", null },
                    { 2, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2955), "......", "Danh mục tin tức 2", null },
                    { 3, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2959), "......", "Danh mục tin tức 3", null },
                    { 4, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2963), "......", "Danh mục tin tức 4", null },
                    { 5, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2966), "......", "Danh mục tin tức 5", null },
                    { 6, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2970), "......", "Danh mục tin tức 6", null },
                    { 7, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2974), "......", "Danh mục tin tức 7", null },
                    { 8, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2978), "......", "Danh mục tin tức 8", null },
                    { 9, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2982), "......", "Danh mục tin tức 9", null },
                    { 10, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2986), "......", "Danh mục tin tức 10", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Password", "Role", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2239), "123123", "Admin", null, "user11" },
                    { 2, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2265), "123123", "User", null, "user22" },
                    { 3, new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(2269), "123123", "User", null, "user33" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Avartar", "CategoryId", "Content", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "news-avartar.jpg", 2, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3053), "......", "Bài viết 1", null },
                    { 2, "news-avartar.jpg", 2, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3058), "......", "Bài viết 2", null },
                    { 3, "news-avartar.jpg", 3, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3062), "......", "Bài viết 3", null },
                    { 4, "news-avartar.jpg", 3, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3067), "......", "Bài viết 4", null },
                    { 5, "news-avartar.jpg", 5, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3071), "......", "Bài viết 5", null },
                    { 6, "news-avartar.jpg", 5, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3076), "......", "Bài viết 6", null },
                    { 7, "news-avartar.jpg", 9, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3080), "......", "Bài viết 7", null },
                    { 8, "news-avartar.jpg", 8, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3085), "......", "Bài viết 8", null },
                    { 9, "news-avartar.jpg", 10, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3090), "......", "Bài viết 9", null },
                    { 10, "news-avartar.jpg", 1, "<p>Đây là nội dung bài viết</p>", new DateTime(2023, 7, 20, 19, 11, 56, 504, DateTimeKind.Local).AddTicks(3094), "......", "Bài viết 10", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_CategoryId",
                table: "Post",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admission");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
