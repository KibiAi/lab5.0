using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Store
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

    }
}
