using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            var existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
                productCollection.InsertManyAsync(GetMyProducts());
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "iPhone 9",
                    Description = "An apple mobile which is nothing like apple",
                    Image = "https://i.dummyjson.com/data/products/1/thumbnail.jpg",
                    Price = 549.00M,
                    Category = "smartphones",
                },
                new Product()
                {
                    Name = "iPhone X",
                    Description = "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...",
                    Image = "https://i.dummyjson.com/data/products/2/thumbnail.jpg",
                    Price = 899.00M,
                    Category = "smartphones",
                },
                new Product()
                {
                    Name = "Samsung Universe 9",
                    Description = "Samsung's new variant which goes beyond Galaxy to the Universe",
                    Image = "https://i.dummyjson.com/data/products/3/thumbnail.jpg",
                    Price = 1249.00M,
                    Category = "smartphones",
                },
                new Product()
                {
                    Name = "OPPOF19",
                    Description = "OPPO F19 is officially announced on April 2021.",
                    Image = "https://i.dummyjson.com/data/products/4/thumbnail.jpg",
                    Price = 280.00M,
                    Category = "smartphones",
                },
                new Product()
                {
                    Name = "Huawei P30",
                    Description = "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.",
                    Image = "https://i.dummyjson.com/data/products/5/thumbnail.jpg",
                    Price = 499.00M,
                    Category = "smartphones",
                }
            };
        }
    }
}
