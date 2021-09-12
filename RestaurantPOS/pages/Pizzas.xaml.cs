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
    /// Interaction logic for Pizzas.xaml
    /// </summary>
    public partial class Pizzas : Page
    {
        public Pizzas()
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
        private void onClickKebab(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 250, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Kebab Pizza")
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
                MainWindow.List.Add(new Item { Name = "Kebab Pizza", Price = "250", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickBBQRanch(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 400, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "BBQ Ranch Pizza")
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
                MainWindow.List.Add(new Item { Name = "BBQ Ranch Pizza", Price = "400", Qnt = "1" });
                UpdateBill();

            }
        }

        private void onClickChickenSupreme(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 300, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Chicken Supreme Pizza")
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
                MainWindow.List.Add(new Item { Name = "Chicken Supreme Pizza", Price = "300", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickMalaiBoti(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 350, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Malai Boti Pizza")
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
                MainWindow.List.Add(new Item { Name = "Malai Boti Pizza", Price = "350", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickFajita(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 400, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Fajita Pizza")
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
                MainWindow.List.Add(new Item { Name = "Fajita Pizza", Price = "400", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickTandoori(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 150, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Tandoori Pizza")
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
                MainWindow.List.Add(new Item { Name = "Tandoori Pizza", Price = "150", Qnt = "1" });
                UpdateBill();
            }
            }

        private void onClickPepperoni(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 350, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Pepperoni Pizza")
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
                MainWindow.List.Add(new Item { Name = "Pepperoni Pizza", Price = "350", Qnt = "1" });
                UpdateBill();
            }
        }

        private void onClickTikka(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            int price = 350, quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == "Tikka Pizza")
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
                MainWindow.List.Add(new Item { Name = "Tikka Pizza", Price = "350", Qnt = "1" });
                UpdateBill();
            }
        }

        
    }
}
