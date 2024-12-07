using Hw_ProductService.Models;
using System.Security.Cryptography.X509Certificates;

namespace Hw_ProductService.Service
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
                products = new List<Product>()
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Laptop Pro X",
                        Price = 1200,
                        Category = "Laptop",
                        Description = "High-performance laptop for professionals."
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Smartphone Ultra",
                        Price = 800,
                        Category = "Smartphone",
                        Description = "Flagship smartphone with advanced camera features."
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Wireless Headphones Max",
                        Price = 300,
                        Category = "Headphones",
                        Description = "Noise-cancelling headphones with superior sound quality."
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Smart Watch Series 7",
                        Price = 350,
                        Category = "Smart Watch",
                        Description = "Fitness tracker and smart notifications in a sleek design."
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Gaming Laptop GX",
                        Price = 1500,
                        Category = "Laptop",
                        Description = "High-performance gaming laptop with RGB lighting."
                    }
                };
        }
        public void UpdateProduct(Product product)
        {
            var currentElement = products.FirstOrDefault(e => e.Id == product.Id);
            if (product != null)
            {
                currentElement.Name = product.Name;
                currentElement.Price = product.Price;
                currentElement.Description = product.Description;
            }
        }
        public Product GetProduct(int productId)
        {
            return products.FirstOrDefault(e => e.Id == productId);
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
