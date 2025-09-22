using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP322Yalunin.View
{
    internal class InventoryManager
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool RemoveProduct(string code)
        {
            var product = products.FirstOrDefault(p => p.Code == code);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
