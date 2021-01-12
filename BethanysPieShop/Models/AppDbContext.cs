using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies" });


            //seed pies 
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple pie",
                Price = 12.95M,
                ShortDescription = "Perfect Apple Pie.",
                LongDescription = "Our classic apple pie takes a shortcut with easy Pillsbury™ refrigerated pie crust! Baked with a filling of fresh apples and warm spices, there is as much simple joy in preparing this pie as there is in eating it",
                CategoryId = 1,
                ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.Qz8R5MTv4KKTT-OVw8y_fgHaHa&pid=Api&P=0&w=300&h=300",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://tse2.mm.bing.net/th?id=OIP.Qz8R5MTv4KKTT-OVw8y_fgHaHa&pid=Api&P=0&w=300&h=300",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Blueberry Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it.",
                LongDescription = "Cool and then remove cake from pan by loosening edges with a knife. Place frozen blueberries on top of cake. Melt jelly and spoon over blueberries to glaze. Chill until ready to serve.",
                CategoryId = 2,
                ImageUrl = "https://images.pexels.com/photos/3450560/pexels-photo-3450560.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://images.pexels.com/photos/3450560/pexels-photo-3450560.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Cheese Cake",
                Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription = "My guests always expect me to create something new, a real showstopper! Here is my latest creation. Decorate with whipped cream just before serving. ",
                CategoryId = 3,
                ImageUrl = "https://tse1.mm.bing.net/th?id=OIP.XmO7CJJxtwMD-3osPGe45gD6D6&pid=Api&P=0&w=300&h=300",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://tse1.mm.bing.net/th?id=OIP.XmO7CJJxtwMD-3osPGe45gD6D6&pid=Api&P=0&w=300&h=300",
            });
        }
    }
}
