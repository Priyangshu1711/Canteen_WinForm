using Main_Form.Admin.Inventory;

namespace Main_Form.Admin.Customer
{
    public partial class CustomerForm : Form
    {
        string oldname = "";
        Boolean isEditing = false;
        public CustomerForm()
        {

            InitializeComponent();
            
        }
        private void Customer_Form_Load(object sender, EventArgs e)
        {
            GetAllCustomer obj = new GetAllCustomer();
            Cus_dataGridView.DataSource = obj.GetAllCustomers();
        }



        private void cus_delete_button_Click(object sender, EventArgs e)
        {
            string name = Name_textBox.Text;
            CusDelete obj = new CusDelete();
            Boolean isDeleted = obj.DeleteFromCustomers(name);
            if (isDeleted)
            {
                Reload_Page(sender, e);
            }
        }
        void Reload_Page(object sender, EventArgs e)
        {
            Name_textBox.Text = "";
            Password_textBox.Text = "";
            Ph_no_textBox.Text = "";
            Balance_textBox.Clear();
            Customer_Form_Load(sender, e);
        }

        private void Cus_save_button_Click(object sender, EventArgs e)
        {

            try
            {

                string Oldname = oldname;
                string name = Name_textBox.Text;
                string password = Password_textBox.Text;
                string ph_no = Ph_no_textBox.Text;
                int balance = Convert.ToInt32(Balance_textBox.Text);


                if (isEditing == false)
                {
                    CusInsert obj = new CusInsert();
                    Boolean isInserted = obj.InsetIntoCustomers(name, password, ph_no, balance);
                    if (isInserted)
                    {
                        Reload_Page(sender, e);
                    }
                }
                else
                {
                    CusUpdate obj = new CusUpdate();

                    Boolean isUpdated = obj.Update_Customers(name, Oldname, password, ph_no, balance);
                    if (isUpdated)
                    {
                        Reload_Page(sender, e);
                    }

                    oldname = "";
                    isEditing = false;
                }



            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void Cus_update_button_Click(object sender, EventArgs e)
        {
            isEditing = true;

            if (Cus_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Cus_dataGridView.SelectedRows[0];
                if (row != null)
                {
                    Name_textBox.Text = row.Cells["Name"].Value.ToString();
                    Password_textBox.Text = row.Cells["Password"].Value.ToString();
                    Ph_no_textBox.Text = row.Cells["Phno"].Value.ToString();
                    Balance_textBox.Text = row.Cells["Balance"].Value.ToString();
                    oldname = Name_textBox.Text;

                }
            }
            else
            {
                MessageBox.Show("No rows selected");
            }
        }

        private void cus_clear_button_Click(object sender, EventArgs e)
        {
            Reload_Page(sender,e);
        }
    }
}
