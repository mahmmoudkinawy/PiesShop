using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class SeedingOnePie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 1, 1, "https://tse2.mm.bing.net/th?id=OIP.Qz8R5MTv4KKTT-OVw8y_fgHaHa&pid=Api&P=0&w=300&h=300", "https://tse2.mm.bing.net/th?id=OIP.Qz8R5MTv4KKTT-OVw8y_fgHaHa&pid=Api&P=0&w=300&h=300", true, true, "Our classic apple pie takes a shortcut with easy Pillsbury™ refrigerated pie crust! Baked with a filling of fresh apples and warm spices, there is as much simple joy in preparing this pie as there is in eating it", "Apple pie", 12.95m, "Perfect Apple Pie." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);
        }
    }
}
