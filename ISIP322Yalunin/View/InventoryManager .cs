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

        public List<Product> SearchProducts(string query)
        {
            return products.Where(p =>
                p.Code.Contains(query) ||
                p.Name.Contains(query) ||
                p.Category.Contains(query)).ToList();
        }

        public bool SellProduct(string code, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Code == code);
            if (product != null && product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
                product.InStock = product.Quantity > 0;
                return true;
            }
            return false;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
