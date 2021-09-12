using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestaurantPOS.Model
{
    class DatabaseHandler
    {

        private string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RestaurantPOS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection con;
        public DatabaseHandler()
        {
            con = new SqlConnection(constring);

        }

        public bool InsertinOrders()
        {
            int num=0;
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            try
            {
                con.Open();
                SqlParameter p1 = new SqlParameter("total", MainWindow.Bill.Total);
                SqlParameter p2 = new SqlParameter("tax", MainWindow.Bill.GST);
                SqlParameter p3 = new SqlParameter("subtotal", MainWindow.Bill.Subtotal);
                SqlParameter p4 = new SqlParameter("date", date);
                string query = $"insert into Orders(Total,Tax,Subtotal,Date) values(@total,@tax,@subtotal,@Date)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                num = cmd.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            if (num >= 1)
            {
                InsertinItems();
                return true;
            }
            else
            {
                return false;
            }

        }
        public int getCurrentOrderId()
        {
            int orderid=0;
            try
            {
                con.Open();
                string query;


                query = "select * from Orders";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader sr = cmd.ExecuteReader();

                while (sr.Read())
                {
                    orderid = sr.GetInt32(0);
                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return orderid;
        }

        public void InsertinItems()
        {
            int orderid = getCurrentOrderId();
            try
            {
                con.Open();
                string query;
                foreach (var item in MainWindow.List)
                {
                    SqlParameter p1 = new SqlParameter("n",item.Name);
                    SqlParameter p2 = new SqlParameter("p", item.Price);
                    SqlParameter p3 = new SqlParameter("q", item.Qnt);
                    SqlParameter p4 = new SqlParameter("o", orderid);
                    query = "insert into items(OrderId,itemName,itemPrice,itemQnt) values(@o,@n,@p,@q)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);

                    cmd.ExecuteNonQuery();
                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

    }

    }



