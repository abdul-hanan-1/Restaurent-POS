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
    /// Interaction logic for Shakes.xaml
    /// </summary>
    public partial class Shakes : Page
    {
        public Shakes()
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
        private void onClickOreo(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Oreo Shake")
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
                MainWindow.List.Add(new Item { Name = "Oreo Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickChocolate(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Chocolate Shake")
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
                MainWindow.List.Add(new Item { Name = "Chocolate Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickKitkat(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "KitKat Shake")
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
                MainWindow.List.Add(new Item { Name = "KitKat Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickStrawbery(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Strawbery Shake")
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
                MainWindow.List.Add(new Item { Name = "Strawbery Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickVanilla(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Vanilla Shake")
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
                MainWindow.List.Add(new Item { Name = "Vanilla Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickCaramel(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Caramel Shake")
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
                MainWindow.List.Add(new Item { Name = "Caramel Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickColdCoffee(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Cold Coffee")
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
                MainWindow.List.Add(new Item { Name = "Cold Coffee", Price = "270", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickBanana(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Banana Shake")
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
                MainWindow.List.Add(new Item { Name = "Banana Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickToffee(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 270, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Toffee Shake")
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
                MainWindow.List.Add(new Item { Name = "Toffee Shake", Price = "270", Qnt = "1" });
                UpdateBill();
            }
        }
    }
}
