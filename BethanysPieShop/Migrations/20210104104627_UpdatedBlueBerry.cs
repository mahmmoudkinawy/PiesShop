using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class UpdatedBlueBerry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://images.pexels.com/photos/3450560/pexels-photo-3450560.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260", "https://images.pexels.com/photos/3450560/pexels-photo-3450560.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://tse4.mm.bing.net/th?id=OIP.Y63KW4HDy401PiQtVH-qtAHaE8&pid=Api&P=0&w=229&h=153", "https://tse4.mm.bing.net/th?id=OIP.Y63KW4HDy401PiQtVH-qtAHaE8&pid=Api&P=0&w=229&h=153" });
        }
    }
}
