using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class newFe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://tse4.mm.bing.net/th?id=OIP.Y63KW4HDy401PiQtVH-qtAHaE8&pid=Api&P=0&w=229&h=153", "https://tse4.mm.bing.net/th?id=OIP.Y63KW4HDy401PiQtVH-qtAHaE8&pid=Api&P=0&w=229&h=153" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://tse3.mm.bing.net/th?id=OIP.7VhZCLjSJ51MCXH9E-o3QgHaE8&pid=Api&P=0&w=267&h=179", "https://tse3.mm.bing.net/th?id=OIP.7VhZCLjSJ51MCXH9E-o3QgHaE8&pid=Api&P=0&w=267&h=179" });
        }
    }
}
