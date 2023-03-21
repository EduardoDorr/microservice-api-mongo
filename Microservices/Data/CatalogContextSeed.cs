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
                    Name = "IPhone X",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Phasellus vel tempor massa. Ut est est, sodales accumsan laoreet quis, vulputate nec turpis." +
                    "Morbi nunc risus, lobortis rhoncus tellus sit amet, pulvinar ultricies purus. In eget est lectus." +
                    "Cras sollicitudin, nulla non sollicitudin varius, turpis odio laoreet nunc, a placerat lorem urna semper enim." +
                    "Proin at lectus ac ligula interdum faucibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Praesent a libero ullamcorper, pulvinar mi sit amet, semper arcu. Fusce lacinia nec velit in hendrerit." +
                    "Integer volutpat scelerisque nisi. Nulla facilisi.",
                    Image = "product-1.png",
                    Price = 950.00M,
                    Category = "Smartphone",
                },
                new Product()
                {
                    Name = "IPhone X Pro",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Phasellus vel tempor massa. Ut est est, sodales accumsan laoreet quis, vulputate nec turpis." +
                    "Morbi nunc risus, lobortis rhoncus tellus sit amet, pulvinar ultricies purus. In eget est lectus." +
                    "Cras sollicitudin, nulla non sollicitudin varius, turpis odio laoreet nunc, a placerat lorem urna semper enim." +
                    "Proin at lectus ac ligula interdum faucibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Praesent a libero ullamcorper, pulvinar mi sit amet, semper arcu. Fusce lacinia nec velit in hendrerit." +
                    "Integer volutpat scelerisque nisi. Nulla facilisi. ",
                    Image = "product-2.png",
                    Price = 1150.00M,
                    Category = "Smartphone",
                },
                new Product()
                {
                    Name = "Samsung 10",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Phasellus vel tempor massa. Ut est est, sodales accumsan laoreet quis, vulputate nec turpis." +
                    "Morbi nunc risus, lobortis rhoncus tellus sit amet, pulvinar ultricies purus. In eget est lectus." +
                    "Cras sollicitudin, nulla non sollicitudin varius, turpis odio laoreet nunc, a placerat lorem urna semper enim." +
                    "Proin at lectus ac ligula interdum faucibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Praesent a libero ullamcorper, pulvinar mi sit amet, semper arcu. Fusce lacinia nec velit in hendrerit." +
                    "Integer volutpat scelerisque nisi. Nulla facilisi. ",
                    Image = "product-3.png",
                    Price = 650.00M,
                    Category = "Smartphone",
                },
                new Product()
                {
                    Name = "Samsung 20",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Phasellus vel tempor massa. Ut est est, sodales accumsan laoreet quis, vulputate nec turpis." +
                    "Morbi nunc risus, lobortis rhoncus tellus sit amet, pulvinar ultricies purus. In eget est lectus." +
                    "Cras sollicitudin, nulla non sollicitudin varius, turpis odio laoreet nunc, a placerat lorem urna semper enim." +
                    "Proin at lectus ac ligula interdum faucibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Praesent a libero ullamcorper, pulvinar mi sit amet, semper arcu. Fusce lacinia nec velit in hendrerit." +
                    "Integer volutpat scelerisque nisi. Nulla facilisi. ",
                    Image = "product-4.png",
                    Price = 900.00M,
                    Category = "Smartphone",
                },
                new Product()
                {
                    Name = "Xiaomi Poco",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Phasellus vel tempor massa. Ut est est, sodales accumsan laoreet quis, vulputate nec turpis." +
                    "Morbi nunc risus, lobortis rhoncus tellus sit amet, pulvinar ultricies purus. In eget est lectus." +
                    "Cras sollicitudin, nulla non sollicitudin varius, turpis odio laoreet nunc, a placerat lorem urna semper enim." +
                    "Proin at lectus ac ligula interdum faucibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    "Praesent a libero ullamcorper, pulvinar mi sit amet, semper arcu. Fusce lacinia nec velit in hendrerit." +
                    "Integer volutpat scelerisque nisi. Nulla facilisi. ",
                    Image = "product-5.png",
                    Price = 550.00M,
                    Category = "Smartphone",
                }
            };
        }
    }
}
