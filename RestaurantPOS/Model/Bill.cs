using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS.Model
{
    class Bill : INotifyPropertyChanged
    {
       
        
            private double total;
            private double gst;
            private  double subtotal;
            private string date = DateTime.Now.ToString();



        public double Total
            {
                get
                {
                    return total;
                }
                set
                {

                    total = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Total"));
                    }

                }
            }
        public string Date
        {
            get
            {
                return date;
            }
            set
            {

                date = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
                }

            }
        }

        public double GST
            {
                get
                {
                    return gst;
                }
                set
                {

                    gst = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("GST"));
                    }
                }
            }
            public double Subtotal
            {
                 
                get
                {
                    return subtotal;
                }
                set
                {

                    subtotal = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Subtotal"));
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }
}
