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
            ProductsDataGrid.ItemsSource = inventoryManager.GetProducts();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string query = SearchTextBox.Text;
            ProductsDataGrid.ItemsSource = inventoryManager.SearchProducts(query);
        }

    }
}