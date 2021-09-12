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
    /// Interaction logic for Sandwitches.xaml
    /// </summary>
    public partial class Sandwitches : Page
    {
        public Sandwitches()
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
        private void onClickChicken(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 250, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Chicken Sandwich")
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
                MainWindow.List.Add(new Item { Name = "Chicken Sandwich", Price = "250", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickBeef(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 320, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Beef Sandwich")
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
                MainWindow.List.Add(new Item { Name = "Beef Sandwich", Price = "320", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickCheese(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 280, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Cheese Sandwich")
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
                MainWindow.List.Add(new Item { Name = "Cheese Sandwich", Price = "280", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickGrill(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 300, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Grill Sandwich")
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
                MainWindow.List.Add(new Item { Name = "Grill Sandwich", Price = "300", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickGrilledCheese(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 340, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Grilled Cheese Sandwich")
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
                MainWindow.List.Add(new Item { Name = "Grilled Cheese Sandwich", Price = "340", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickFish(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 380, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Fish Sandwich")
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
                MainWindow.List.Add(new Item { Name = "Fish Sandwich", Price = "380", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickBacon(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 400, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Bacon Sandwich")
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
                MainWindow.List.Add(new Item { Name = "Bacon Sandwich", Price = "400", Qnt = "1" });
                UpdateBill();
            }
            }
    }
}
