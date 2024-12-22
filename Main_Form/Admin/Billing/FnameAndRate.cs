using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Main_Form.Admin.Billing
{

     class FnameRate
    {
        public string fname;
        public int rate;
    }
    class FnameAndRate
    {
        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);
        public static FnameRate GetFnameRate(int itemFid)
        {
            FnameRate fr = new FnameRate();
            try
            {
                _conn.Open();
                string query =$"Select fname,rate from inventory where fid ={itemFid}";
                SqlCommand command = new SqlCommand(query, _conn);
                
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    fr.fname =  reader["fname"].ToString();
                    fr.rate = Convert.ToInt32(reader["rate"]);
                    _conn.Close();
                    return fr;

                }
                MessageBox.Show("invalid fid");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                _conn.Close();
            }
            _conn.Close();
            return fr;
        }

        public static int GetQty(int fid,int qty)
        {

            try
            {
                _conn.Open();
                string query = $"select qty from stock where fid = {fid}";
                SqlCommand command = new SqlCommand(query, _conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int currQty = Convert.ToInt32(reader["Qty"]);
                    if (currQty >= qty)
                    {
                        _conn.Close();
                        return qty;
                    }
                    
                    MessageBox.Show($"Total stock for this item is only {currQty}");

                }

            }
            catch (Exception e)
            {
               Console.WriteLine(e);
                _conn.Close();
            }

            _conn.Close();
            return 0;
        }
    }
}
