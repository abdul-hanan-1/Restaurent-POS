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
using System.Windows.Threading;
using RestaurantPOS.pages;
using RestaurantPOS.Model;
using System.Collections.ObjectModel;
using System.Windows.Media.Animation;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.ComponentModel;
using System.Drawing;
using Brushes = System.Windows.Media.Brushes;
using Syncfusion.Pdf.Grid;
using System.Data;
using System.IO;

namespace RestaurantPOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static ObservableCollection<Item> list = new ObservableCollection<Item>();

        internal static ObservableCollection<Item> List { get => list; set => list = value; }
        internal static Bill Bill { get => bill; set => bill = value; }

        private static Bill bill;

        



        public MainWindow()
        {
            InitializeComponent();
            mygrid.ItemsSource = List;
            bill = new Bill();
            this.DataContext = bill;
           

        }
        

        public void UpdateBill()
        {
            bill.Total = 0;
            bill.GST = 0;
            bill.Subtotal = 0;
            foreach (Item item in MainWindow.List)
            {
                MainWindow.Bill.Total = MainWindow.Bill.Total + Convert.ToDouble(item.Price);
            }
            MainWindow.Bill.GST = MainWindow.Bill.Total * 0.16;
            MainWindow.Bill.Subtotal = MainWindow.Bill.Total + MainWindow.Bill.GST;
        }


        private void powerButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void onClickBurgers(object sender, RoutedEventArgs e)
        {
            fram1.Content = new Burgers();
           
            
            
        }

        private void onClickPizzas(object sender, RoutedEventArgs e)
        {
            fram1.Content = new Pizzas();
            
        }

        private void onClickSandwiches(object sender, RoutedEventArgs e)
        {
            fram1.Content = new Sandwitches();
           
        }

        private void onClickShakes(object sender, RoutedEventArgs e)
        {
            fram1.Content = new Shakes();
            
        }

        private void onClickColddrinks(object sender, RoutedEventArgs e)
        {
            fram1.Content = new ColdDrinks();
            
        }

        private void onClickIcecream(object sender, RoutedEventArgs e)
        {
            fram1.Content = new Icecream();
           
        }

       

        private void delete(object sender, RoutedEventArgs e)
        {
            
                if (mygrid.SelectedItem != null)
                {

                        list.Remove(mygrid.SelectedItem as Item);
                        bill.Total = 0;
                        bill.GST = 0;
                        bill.Subtotal = 0;
                        UpdateBill();

                }
                else
                {
                    MessageBox.Show("select some thing from grid");
                }
            
        }
        private void IncreaseQty(object sender, RoutedEventArgs e)
        {

            if (mygrid.SelectedItem != null)
            {
                int index=list.IndexOf(mygrid.SelectedItem as Item);
                string Price = Convert.ToString(Convert.ToInt32(list[index].Price) / Convert.ToInt32(list[index].Qnt));
                list[index].Qnt = Convert.ToString(Convert.ToInt32(list[index].Qnt) + 1);
                
                list[index].Price= Convert.ToString(Convert.ToInt32(list[index].Price)+Convert.ToInt32(Price));
                bill.Total = 0;
                bill.GST = 0;
                bill.Subtotal = 0;
                UpdateBill();

            }
            else
            {
                MessageBox.Show("select some thing from grid");
            }

        }
        private void DecreaseQty(object sender, RoutedEventArgs e)
        {

            if (mygrid.SelectedItem != null)
            {
                int index = list.IndexOf(mygrid.SelectedItem as Item);
                if (Convert.ToInt32(list[index].Qnt) > 1)
                {
                    string Price = Convert.ToString(Convert.ToInt32(list[index].Price) / Convert.ToInt32(list[index].Qnt));
                    list[index].Qnt = Convert.ToString(Convert.ToInt32(list[index].Qnt) - 1);

                    list[index].Price = Convert.ToString(Convert.ToInt32(list[index].Price) - Convert.ToInt32(Price));
                    bill.Total = 0;
                    bill.GST = 0;
                    bill.Subtotal = 0;
                    UpdateBill();

                }
                else
                    delete(sender,e);

            }
            else
            {
                MessageBox.Show("select some thing from grid");
            }

        }

        private void PrintbtnClicked(object sender, RoutedEventArgs e)
        {

            if (list.Any())
            {
                PdfDocument doc = new PdfDocument();

                PdfPage page = doc.Pages.Add();

                FileStream imageStream = new FileStream("../../Assets/logo.png", FileMode.Open, FileAccess.Read);
                RectangleF bounds = new RectangleF(165, 10, 180, 160);
                PdfImage image = PdfImage.FromStream(imageStream);


                page.Graphics.DrawImage(image, bounds);

                PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                bounds = new RectangleF(0, bounds.Bottom + 40, page.Graphics.ClientSize.Width, 30);

                page.Graphics.DrawRectangle(solidBrush, bounds);

                PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);

                PdfTextElement element = new PdfTextElement("INVOICE", subHeadingFont);
                element.Brush = PdfBrushes.White;


                PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
                string currentDate = "DATE " + DateTime.Now.ToString("MM/dd/yyyy");

                SizeF textSize = subHeadingFont.MeasureString(currentDate);
                PointF textPosition = new PointF(page.Graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);

                page.Graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);
                PdfFont timesRoman = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);

                PdfGrid pdfGrid = new PdfGrid();


                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Item Name");
                dataTable.Columns.Add("Qty");
                dataTable.Columns.Add("Price");

                foreach (Item item in MainWindow.List)
                {
                    dataTable.Rows.Add(new object[] { "  " + item.Name, "  " + item.Qnt, "  " + item.Price });
                }


                dataTable.Rows.Add(new object[] { "", "                                       Total:", " Rs. " + MainWindow.Bill.Total });
                dataTable.Rows.Add(new object[] { "", "                                       GST @16% :", " Rs. " + MainWindow.Bill.GST });
                dataTable.Rows.Add(new object[] { "", "                                       SubTotal:", " Rs. " + MainWindow.Bill.Subtotal });


                pdfGrid.DataSource = dataTable;

                PdfGridCellStyle cellStyle = new PdfGridCellStyle();
                cellStyle.Borders.All = PdfPens.White;
                PdfGridRow header = pdfGrid.Headers[0];

                PdfGridCellStyle headerStyle = new PdfGridCellStyle();
                headerStyle.Borders.All = new PdfPen(new PdfColor(126, 151, 173));
                headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
                headerStyle.TextBrush = PdfBrushes.White;
                headerStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 14f, PdfFontStyle.Regular);

                for (int i = 0; i < header.Cells.Count; i++)
                {
                    if (i == 0 || i == 1)
                        header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                    else
                        header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle);
                }


                header.ApplyStyle(headerStyle);
                cellStyle.Borders.Bottom = new PdfPen(new PdfColor(217, 217, 217), 0.70f);
                cellStyle.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12f);
                cellStyle.TextBrush = new PdfSolidBrush(new PdfColor(131, 130, 136));

                PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();

                layoutFormat.Layout = PdfLayoutType.Paginate;

                PdfGridLayoutResult gridResult = pdfGrid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height - 100)), layoutFormat);

                element = new PdfTextElement("Thankyou! For any complaint or query please contact us at 03XX-XXXXXXX. ", timesRoman);
                element.Brush = new PdfSolidBrush(new PdfColor(126, 151, 171));
                result = element.Draw(page, new PointF(10, gridResult.Bounds.Bottom + 25));
                PdfPen linePen = new PdfPen(new PdfColor(126, 151, 173), 0.70f);
                PointF startPoint = new PointF(0, result.Bounds.Bottom + 3);
                PointF endPoint = new PointF(page.Graphics.ClientSize.Width, result.Bounds.Bottom + 3);

                page.Graphics.DrawLine(linePen, startPoint, endPoint);
                string dt = DateTime.Now.ToString("ddd, dd MMM yyy HH'-'mm'-'ss 'GMT'");


                doc.Save($"../../Printed Bills/{dt}.pdf");

                doc.Close(true);

                DatabaseHandler db = new DatabaseHandler();
                db.InsertinOrders();
                list.Clear();
                UpdateBill();
                MessageBox.Show("Bill Printed at Printed Bills folder as PDF File and record saved in DB.");
            }
            else
                MessageBox.Show("Please select something first.");
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            list.Clear();
            UpdateBill();
        }
    }
}
