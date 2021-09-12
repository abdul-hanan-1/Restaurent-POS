using RestaurantPOS.Model;
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

namespace RestaurantPOS.pages
{
    /// <summary>
    /// Interaction logic for Icecream.xaml
    /// </summary>
    public partial class Icecream : Page
    {
        public Icecream()
        {
            InitializeComponent();
        }
        public void UpdateBill()
        {
            MainWindow.Bill.Total = 0;
            MainWindow.Bill.GST = 0;
            MainWindow.Bill.Subtotal = 0;
            foreach (Item item in MainWindow.List)
            {
                MainWindow.Bill.Total = MainWindow.Bill.Total + Convert.ToDouble(item.Price);
            }
            MainWindow.Bill.GST = MainWindow.Bill.Total * 0.16;
            MainWindow.Bill.Subtotal = MainWindow.Bill.Total + MainWindow.Bill.GST;
        }
        private void onClickVanilla(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 150, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Vanilla Icecream")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Vanilla Icecream", Price = "150", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickMango(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 150, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Mango Icecream")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Mango Icecream", Price = "150", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickChocolate(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 150, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Chocolate Icecream")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Chocolate Icecream", Price = "150", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickChocolateSundae(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 250, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Chocolate Sundae Icecream")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Chocolate Sundae Icecream", Price = "250", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickBlueberrySundae(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 250, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Blueberry Sundae")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Blueberry Sundae", Price = "250", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickCaramel(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 150, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Caramel Icecream")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Caramel Icecream", Price = "150", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickBrowniw(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 300, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Brownie with Icecream")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Brownie with Icecream", Price = "300", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickStrawbery(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 150, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Strawbery Icecream")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false)
            {
                MainWindow.List.Add(new Item { Name = "Strawbery Icecream", Price = "150", Qnt = "1" });
                UpdateBill();
            }
        }
    }
}
