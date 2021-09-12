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
    /// Interaction logic for Desserts.xaml
    /// </summary>
    public partial class ColdDrinks : Page
    {
        public ColdDrinks()
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

        private void onClickCoke(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 70, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Coke")
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + price);
                    cond = true;
                    UpdateBill();
                }

            }
            if (cond == false) {
                MainWindow.List.Add(new Item { Name = "Coke", Price = "70", Qnt = "1" });
                UpdateBill();
                    }
        }

        private void onClickSprite(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 70, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Sprite")
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
                MainWindow.List.Add(new Item { Name = "Sprite", Price = "70", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickDew(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 70, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Dew")
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
                MainWindow.List.Add(new Item { Name = "Dew", Price = "70", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickMirinda(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 70, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Mirinda")
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
                MainWindow.List.Add(new Item { Name = "Mirinda", Price = "70", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickSting(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 70, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Sting")
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
                MainWindow.List.Add(new Item { Name = "Sting", Price = "70", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickBigApple(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 70, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "BigApple")
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
                MainWindow.List.Add(new Item { Name = "BigApple", Price = "70", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickLemonMalt(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 70, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Lemon Malt")
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
                MainWindow.List.Add(new Item { Name = "Lemon Malt", Price = "70", Qnt = "1" });
                UpdateBill();
            }
            }
    }
}
