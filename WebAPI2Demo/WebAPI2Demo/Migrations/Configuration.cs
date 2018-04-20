using WebAPI2Demo.Models;

namespace WebAPI2Demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI2DemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPI2DemoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(x => x.Id,
                new Category { Id = 1, Name = "Mobile" },
                new Category { Id = 2, Name = "Tablet" },
                new Category { Id = 3, Name = "Smart TV" });
            context.Products.AddOrUpdate(x => x.Id,
                new Product { Id = 1, Name = "Product 1", CategoryId = 1, Price = 9.9M },
                new Product { Id = 2, Name = "Product 2", CategoryId = 2, Price = 0.9M },
                new Product { Id = 3, Name = "Product 3", CategoryId = 1, Price = 2.8M },
                new Product { Id = 4, Name = "Product 4", CategoryId = 3, Price = 0.4M });
        }
    }
}
