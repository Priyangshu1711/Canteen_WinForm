using Microsoft.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main_Form.Admin.Customer;
using Main_Form.Admin.Inventory;
using Main_Form.Admin.Billing;

namespace Main_Form.Admin
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }


        private void Admin_Form_Load(object? sender, EventArgs e)
        {

        }


        void Inventory_button_Click(object? sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        void Customer_button_Click(object? sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void Billing_button_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();
        }

        private void Report_button_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}
