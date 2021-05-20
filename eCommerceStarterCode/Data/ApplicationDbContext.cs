using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Seasoned"
                }
                );
            modelBuilder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 11,
                    Name = "Goat -butter",
                    Description = "you've GOAT to try it",
                    Price = 10.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Horse-butter",
                    Description = "Your NEIGHbors will love it",
                    Price = 20.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Cow-butter",
                    Description = "Other butter MOOve out of the way",
                    Price = 20.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Basil-gin infused butter",
                    Description = "We get it you're hip...",
                    Price = 80.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Name = "Melted-butter",
                    Description = "Will go back to solid during shipping",
                    Price = 60.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Name = "Almond-butter",
                    Description = "You ever milk an almond....",
                    Price = 30.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 7,
                    Name = "Lifestyle-butter",
                    Description = "Great snack after your Peleton workout",
                    Price = 60.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 8,
                    Name = "Norwegian-butter",
                    Description = "Greenland-shark-butter",
                    Price = 500.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 9,
                    Name = "Hokkaido-butter",
                    Description = "Godzilla's favorite butter (easter egg)",
                    Price = 150.0,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 10,
                    Name = "Hugo Chavez-butter",
                    Description = "You don't have to share",
                    Price = 1.0,
                    CategoryId = 1
                }
            ) ;

        //    modelBuilder.Entity<Category>().HasData(
        //        new Category
        //        {
        //            Id = 1,
        //            Name = "Seasoned"
        //        }
        //        );
        //    modelBuilder.Entity<Product>().HasData
        //    (
        //        new Product
        //        {
        //            Id = 1,
        //            Name = "Goat -butter",
        //            Description = "you've GOAT to try it",
        //            Price = 10.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 2,
        //            Name = "Horse-butter",
        //            Description = "Your NEIGHbors will love it",
        //            Price = 20.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 3,
        //            Name = "Cow-butter",
        //            Description = "Other butter MOOve out of the way",
        //            Price = 20.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 4,
        //            Name = "Basil-gin infused butter",
        //            Description = "We get it you're hip...",
        //            Price = 80.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 5,
        //            Name = "Melted-butter",
        //            Description = "Will go back to solid during shipping",
        //            Price = 60.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 6,
        //            Name = "Almond-butter",
        //            Description = "You ever milk an almond....",
        //            Price = 30.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 7,
        //            Name = "Lifestyle-butter",
        //            Description = "Great snack after your Peleton workout",
        //            Price = 60.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 8,
        //            Name = "Norwegian-butter",
        //            Description = "Greenland-shark-butter",
        //            Price = 500.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 9,
        //            Name = "Hokkaido-butter",
        //            Description = "Godzilla's favorite butter (easter egg)",
        //            Price = 150.0,
        //            CategoryId = 1
        //        },
        //        new Product
        //        {
        //            Id = 10,
        //            Name = "Hugo Chavez-butter",
        //            Description = "You don't have to share",
        //            Price = 1.0,
        //            CategoryId = 1
        //        }
        //    ) ;

        }
        public DbSet<Product>Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

    }
}
