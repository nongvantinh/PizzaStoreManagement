using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreManagement.Utils
{
    public class Product
    {
        public Product(string name, string kind, int price, int quantity) { Name = name; Kind = kind; Price = price; Quantity = quantity; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }

}
