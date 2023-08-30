using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext>options) : base(options) { }
        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "Testeee",
                ImageURL = "https://i.pinimg.com/236x/36/1e/7a/361e7a167b68bcad8e038d65a03788bf.jpg",
                CategoryName = "T-Shirt"
            });
            //base.OnModelCreating(modelBuilder);
        }
    }
}
