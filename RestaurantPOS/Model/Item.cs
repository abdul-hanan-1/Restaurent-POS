using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS.Model
{
    class Item : INotifyPropertyChanged
    {
        private string name;
        private string price;
        private string quantity;

        public Item(string n,string p,string q)
        {
            name = n;
            price = p;
            quantity = q;

        }
        public Item()
        {

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }

            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {

                price = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Price"));
                }
            }
        }
        public string Qnt
        {
            get
            {
                return quantity;
            }
            set
            {

                quantity = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Qnt"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
