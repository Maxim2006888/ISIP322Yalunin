using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP322Yalunin.View
{
    internal class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool InStock { get; set; }
        public string Category { get; set; }

        public Product(string code, string name, decimal price, int quantity, string category)
        {
            Code = code;
            Name = name;
            Price = price;
            Quantity = quantity;
            InStock = quantity > 0;
            Category = category;
        }
    }
}
