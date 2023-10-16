using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }

        public Order(List<Product> products, int quantity)
        {
            Products = products;
            Quantity = quantity;
            TotalPrice = CalculateTotalPrice();
            Status = "Processing";
        }


        private double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice * Quantity;
        }
    }
}
