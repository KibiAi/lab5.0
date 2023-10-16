using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Product> PurchaseHistory { get; set; } = new List<Product>();

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void AddToPurchaseHistory(Product product)
        {
            PurchaseHistory.Add(product);
        }
    }
}
