using ExamTest.Models;
using System.Security.Cryptography.X509Certificates;
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

namespace ExamTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string name = "Guest";
        public static string role = "Guest";
    public MainWindow()
        {
            InitializeComponent();

            using var db = new AppDbContext();

            int discount = db.Products.Select(p => p.Discount).FirstOrDefault();
            int quantity = db.Products.Select(p => p.Discount).FirstOrDefault();

            UserInfo.Text = $"{name} ({role})";

            ChangeBackgroundBrush(discount, quantity);
        }

        private void ButtonExitClick(object sender, RoutedEventArgs e)
        {
            MainWindow.name = "Guest";
            MainWindow.role = "Guest";

            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void ChangeBackgroundBrush(int discount, int quantity)
        {
            if (discount > 15)
            {
                ProductBorder.Background = (Brush)new BrushConverter().ConvertFrom("#2E8B57");
            }

            if (quantity == 0)
            {
                ProductBorder.Background = Brushes.LightBlue;
            }

            DiscountSize.Text = $"Скидка {discount}%";
        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }
    }
}