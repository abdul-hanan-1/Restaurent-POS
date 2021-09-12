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
using RestaurantPOS.Model;
namespace RestaurantPOS.pages
{
    /// <summary>
    /// Interaction logic for Burgers.xaml
    /// </summary>
    public partial class Burgers : Page
    {
        List<Item> foodItems=new List<Item>();
        public Burgers()
        {
            InitializeComponent();
            Item ZingerBurger = new Item("Zinger Burger","200","1");
            Item PattyBurger = new Item("Patty Burger","150","1");
            Item SpicyChickenBurger = new Item("Spicy Chicken Burger", "250", "1");
            Item MeatMonster = new Item("Meat Monster", "400", "1");
            Item BeefBurger = new Item("Beef Burger", "300", "1");
            Item SpicyBeefBurger = new Item("Spicy Beef Burger", "350", "1");
            Item DoubleCheese = new Item("Double Cheese", "400", "1");
            Item ChickenChapli = new Item("Chicken Chapli", "150", "1");
            Item FishFilletBurger = new Item("Fish Fillet Burger", "350", "1");
            foodItems.Add(ZingerBurger);
            foodItems.Add(PattyBurger);
            foodItems.Add(SpicyChickenBurger);
            foodItems.Add(MeatMonster);
            foodItems.Add(BeefBurger);
            foodItems.Add(SpicyBeefBurger);
            foodItems.Add(DoubleCheese);
            foodItems.Add(ChickenChapli);
            foodItems.Add(FishFilletBurger);

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

        private void onClickSelectedBurger(object sender, RoutedEventArgs e)
        {
            
            bool cond = false;
            Item selectedItem = new Item();
            foreach(Item item1 in foodItems)
            {
                if (item1.Name == (sender as Button).Content.ToString())
                    selectedItem = item1;
            }
                int price = Convert.ToInt32(selectedItem.Price), quantity;
            foreach (Item item in MainWindow.List)
            {
                if (item.Name == selectedItem.Name)
                {

                    quantity = Convert.ToInt32(item.Qnt);
                    item.Qnt = Convert.ToString(quantity + 1);
                    item.Price = Convert.ToString(Convert.ToInt32(item.Price) + Convert.ToInt32(selectedItem.Price));
                    price = 0;
                    cond = true;
                    UpdateBill();
                }

            }
            Item item2 = new Item();
            item2.Price = selectedItem.Price;
            item2.Name = selectedItem.Name;
            item2.Qnt = selectedItem.Qnt;
            if (cond == false) { 
                MainWindow.List.Add(item2);
                UpdateBill();
                
            }
             
        }

    }
}
