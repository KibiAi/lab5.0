using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Product : ISearchable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
        public static List<Product> Products { get; set; } = new List<Product>();

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public List<Product> SearchByPriceRange(double minPrice, double maxPrice)
        {
            return Products.FindAll(p => p.Price >= minPrice && p.Price <= maxPrice);
        }

        public List<Product> SearchByCategory(string category)
        {
            return Products.FindAll(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }
    }
}