namespace ProductReview.Migrations
{
    using ProductReview.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductReview.Models.ProductReviewContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductReview.Models.ProductReviewContext context)
        {
            context.Products.AddOrUpdate(p => p.ProductId,
                new Product { Name = "Microsft", Category = "Software", Price = 200 },
                new Product { Name = "Google", Category = "Software", Price = 500 },
                new Product { Name = "Amazon", Category = "E-Commerce", Price = 700 }
                );

            context.Reviews.AddOrUpdate(r => r.ReviewId,
                            new Review { Title = "Review 1", Description = "Wonderful", ProductId = 1 },
                            new Review { Title = "Review 2", Description = "Very Good", ProductId = 1 },
                            new Review { Title = "Review 3", Description = "Excellent", ProductId = 2 },
                            new Review { Title = "Review 4", Description = "Excellent", ProductId = 2 }
                            );
        }
    }
}
