using ISIP322Yalunin.View;
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
        private InventoryManager inventoryManager = new InventoryManager();
        public MainWindow()
        {
            InitializeComponent();
            inventoryManager.AddProduct(new Product("1001", "Молоко", 50, 10, "Продукты"));
            inventoryManager.AddProduct(new Product("1002", "Хлеб", 30, 20, "Продукты"));
            inventoryManager.AddProduct(new Product("2003", "Шампунь", 150, 5, "Бытовая химия"));
            inventoryManager.AddProduct(new Product("2004", "Ручка", 150, 5, "Концелярия"));
            inventoryManager.AddProduct(new Product("2005", "Карандаш", 150, 5, "Концелярия"));

            ProductsDataGrid.ItemsSource = inventoryManager.GetProducts();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string query = SearchTextBox.Text;
            ProductsDataGrid.ItemsSource = inventoryManager.SearchProducts(query);
        }

   
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string code = CodeTextBox.Text;
            string name = NameTextBox.Text;
            decimal price = decimal.Parse(PriceTextBox.Text);
            int quantity = int.Parse(QuantityTextBox.Text);
            string category = CategoryTextBox.Text;

            inventoryManager.AddProduct(new Product(code, name, price, quantity, category));
            ProductsDataGrid.ItemsSource = inventoryManager.GetProducts();
        }

      
        private void RemoveProductButton_Click(object sender, RoutedEventArgs e)
        {
            string code = RemoveCodeTextBox.Text;
            inventoryManager.RemoveProduct(code);
            ProductsDataGrid.ItemsSource = inventoryManager.GetProducts();
        }

      
        private void SellProductButton_Click(object sender, RoutedEventArgs e)
        {
            string code = SellCodeTextBox.Text;
            int quantity = int.Parse(SellQuantityTextBox.Text);

            if (inventoryManager.SellProduct(code, quantity))
            {
                MessageBox.Show("Товар успешно продан!");
            }
            else
            {
                MessageBox.Show("Ошибка: не хватает товара на складе или товар не найден.");
            }

            ProductsDataGrid.ItemsSource = inventoryManager.GetProducts();
        }
    }
}