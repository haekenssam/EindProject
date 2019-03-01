using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Eindproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product product = new Product("test");
        public static List<Product> products = new List<Product>();
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void addList_Click(object sender, RoutedEventArgs e)
        {
            product.omschrijving = omschrijvingTextBox.Text;
            products.Add(product);

            
        }
    }
}
