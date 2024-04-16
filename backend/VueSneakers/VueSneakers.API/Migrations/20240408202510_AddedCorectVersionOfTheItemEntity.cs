using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VueSneakers.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedCorectVersionOfTheItemEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 5, "/sneakers/sneakers-1.jpg", 123m, "Мужские Кроссовки Nike Blazer Mid Suede" },
                    { 6, "/sneakers/sneakers-2.jpg", 123m, "Мужские Кроссовки Nike Blazer Mid Suede" },
                    { 7, "/sneakers/sneakers-3.jpg", 123m, "Мужские Кроссовки Nike Blazer Mid Suede" },
                    { 8, "/sneakers/sneakers-4.jpg", 123m, "Мужские Кроссовки Nike Blazer Mid Suede" },
                    { 9, "/sneakers/sneakers-5.jpg", 123m, "Мужские Кроссовки Nike Blazer Mid Suede" },
                    { 10, "/sneakers/sneakers-6.jpg", 123m, "Мужские Кроссовки Nike Blazer Mid Suede" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Items");
        }
    }
}
