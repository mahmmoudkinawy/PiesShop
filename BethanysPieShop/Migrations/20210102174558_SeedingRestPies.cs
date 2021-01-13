using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class SeedingRestPies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, 2, "https://tse3.mm.bing.net/th?id=OIP.7VhZCLjSJ51MCXH9E-o3QgHaE8&pid=Api&P=0&w=267&h=179", "https://tse3.mm.bing.net/th?id=OIP.7VhZCLjSJ51MCXH9E-o3QgHaE8&pid=Api&P=0&w=267&h=179", true, true, "Cool and then remove cake from pan by loosening edges with a knife. Place frozen blueberries on top of cake. Melt jelly and spoon over blueberries to glaze. Chill until ready to serve.", "Blueberry Cake", 18.95m, "You'll love it." });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 3, 3, "https://tse1.mm.bing.net/th?id=OIP.XmO7CJJxtwMD-3osPGe45gD6D6&pid=Api&P=0&w=300&h=300", "https://tse1.mm.bing.net/th?id=OIP.XmO7CJJxtwMD-3osPGe45gD6D6&pid=Api&P=0&w=300&h=300", true, true, "My guests always expect me to create something new, a real showstopper! Here is my latest creation. Decorate with whipped cream just before serving. ", "Cheese Cake", 18.95m, "Plain cheese cake. Plain pleasure." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);
        }
    }
}
