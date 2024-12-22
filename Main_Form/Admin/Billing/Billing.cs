using System.ComponentModel;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Main_Form.Admin.Billing
{
    class Billing
    {
        private string phno;
        private int totalAmount;
        private int remaining;
        BindingList<BillingForm.BillingItem> billingItems;

        static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        static SqlConnection _conn = new SqlConnection(ConnectionString);
        public Billing(string phno, int totalAmount, BindingList<BillingForm.BillingItem> billingItems)//,int itemFid,int qty,int totalAmount)
        {
           this.phno = phno;
           this.totalAmount = totalAmount;
           this.billingItems = billingItems;
            
        //    this.itemFid = itemFid;
        //    this.qty = qty;
        //    this.totalAmount = totalAmount;
        }
        public void Bill()
        {
            try
            {
                _conn.Open();
                string query1 = $"select id , name from Customers where Ph_no = '{phno}';";
                SqlCommand command = new SqlCommand(query1, _conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string name = Convert.ToString(reader["Name"]);
                    reader. Close();
                    string query2 = $"Select balance from Token_Money where id = {id}";
                    command = new SqlCommand( query2, _conn);
                    reader = command.ExecuteReader();
                    int balance=0;
                    if (reader.Read())
                    {
                        balance = Convert.ToInt32(reader["balance"]);
                        reader.Close();
                    }

                    if (balance>=totalAmount)
                    {
                        remaining = balance - totalAmount;
                        string query3 = $"Update Token_Money set balance = {remaining} where id= {id}";
                        command = new SqlCommand(query3, _conn);
                        int rowAffected = command.ExecuteNonQuery();
                        
                            foreach (BillingForm.BillingItem item in billingItems)
                            {
                                string fname = item.Fname;
                                int quantitySold = item.Quantity;
                                string query4 = $"UPDATE Stock SET qty = qty - {quantitySold} WHERE fid = (select fid from Inventory where fname = '{fname}');";
                                command = new SqlCommand(query4, _conn);

                                // Execute the update and check for success
                                int stockRowsAffected = command.ExecuteNonQuery();
                                
                                if(stockRowsAffected < 0)
                                {
                                    MessageBox.Show($"Failed to update stock for item  {fname}. It may not exist or insufficient stock.");
                                    _conn.Close();
                                }
                            }
                        _conn.Close();
                        BillReceipt billDetails = new BillReceipt(totalAmount, billingItems,name ,remaining);
                        billDetails.ShowDialog();

                    }

                    if (balance < totalAmount)
                    {
                        MessageBox.Show($"Your current balance is {balance}, but your billing amount = {totalAmount} ");
                        _conn.Close();
                    }
                    MessageBox.Show($"TotalAmount = {totalAmount}, Outstanding balance = {remaining} ");
                    _conn.Close();
                    
                }
                else
                {
                    MessageBox.Show("Enter a valid Ph_no.");
                    _conn.Close();
                } 

            }
            catch (Exception ex)
            {
                _conn.Close();
                Console.WriteLine(ex);
            }
            _conn.Close();
        }

    }
}
