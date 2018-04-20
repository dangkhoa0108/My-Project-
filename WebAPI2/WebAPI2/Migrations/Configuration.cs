using WebAPI2.Models;

namespace WebAPI2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI2DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPI2DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

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
