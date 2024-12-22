using Main_Form.Admin.Inventory;
using System.ComponentModel;
using System.Windows.Forms;

namespace Main_Form.Admin.Billing
{
    public partial class BillingForm : Form
    {
        Boolean isCheckedOut = false;
        int totalAmount = 0;
        BindingList<BillingItem> billingItems = new BindingList<BillingItem>();

        public BillingForm()
        {
            InitializeComponent();
            Food_Cart_dataGridView.DataSource = billingItems;
        }

        public class BillingItem
        {
            public string Fname { get; set; }
            public int Rate { get; set; }
            public int Quantity { get; set; }
            public int ItemTotal { get; set; }
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            GetAllInventory obj = new GetAllInventory();
            Available_Items_dataGridView.DataSource = obj.GetAllInventories();

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (!isCheckedOut)
            {
                int itemFid = int.Parse(Fid_textBox.Text);
                int qty = int.Parse(Qty_textBox.Text);
                int currQty = FnameAndRate.GetQty(itemFid, qty);
                FnameRate fr = FnameAndRate.GetFnameRate(itemFid);
                string fname = fr.fname;
                int rate = fr.rate;
                int itemTotal = qty * rate;
                totalAmount += itemTotal;

                if (currQty > 0)
                {
                    billingItems.Add(new BillingItem
                    {
                        Fname = fname,
                        Rate = rate,
                        Quantity = qty,
                        ItemTotal = itemTotal
                    });

                }
                Fid_textBox.Text = "";
                Qty_textBox.Text = "";




            }
            else
            {

            }


        }

        private void Ph_no_textBox_TextChanged(object sender, EventArgs e)
        {
            totalAmount = 0;

        }

        private void CheckOut_button_Click(object sender, EventArgs e)
        {
            string phno = Ph_no_textBox.Text;
            Billing obj = new Billing(phno, totalAmount, billingItems);
            ///////////
            obj.Bill();
            ///////////
            isCheckedOut = true;
            totalAmount = 0;
            billingItems.Clear();
            Reload_Form(sender, e);
        }

        void Reload_Form(object sender, EventArgs e)
        {
            Ph_no_textBox.Text = "";
            Fid_textBox.Text = "";
            Qty_textBox.Text = "";
            Total_textBox.Text = "";
            Total_label.Text = "";
            BillingForm_Load(sender, e);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Total_textBox.Text = totalAmount.ToString();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Food_Cart_dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = Food_Cart_dataGridView.SelectedRows[0];

                if (selectedRow.DataBoundItem is BillingItem itemToRemove)
                {
                    totalAmount -= itemToRemove.ItemTotal;

                    billingItems.Remove(itemToRemove);
                }

                Food_Cart_dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("No rows selected");
            }
        }

    }
}
