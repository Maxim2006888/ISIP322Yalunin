using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISIP322Yalunin
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public class Product
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
}