using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Client;

namespace Main_Form.Admin.Inventory
{
    public partial class InventoryForm : Form
    {
        Boolean isEditing = false;
        string oldfname = "";
        public InventoryForm()
        {
            InitializeComponent();
        }


        private void InventoryForm_Load(object? sender, EventArgs e)
        {
            GetAllInventory obj = new GetAllInventory();
            Inv_dataGridView.DataSource = obj.GetAllInventories();
        }


        private void Inv_save_button_Click(object sender, EventArgs e)
        {
            try
            {

                string Oldfname = oldfname; 
                string fname = Fname_textBox.Text;
                int rate = Convert.ToInt32(Rate_textBox.Text);
                int qty = Convert.ToInt32(Qty_textBox.Text);


                if (isEditing == false)
                {
                    InvInsert obj = new InvInsert();
                    Boolean isInserted = obj.InsetIntoInventory(fname, rate, qty);
                    if (isInserted)
                    {
                        Reload_Page(sender, e);
                    }
                }
                else
                {
                    InvUpdate obj = new InvUpdate();
                    
                    Boolean isUpdated = obj.Update_Inventory(fname, Oldfname, rate, qty);
                    if (isUpdated)
                    {
                        Reload_Page(sender, e);
                    }

                    oldfname = "";
                    isEditing = false;
                }



            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }



        private void Inv_delete_button_Click(object sender, EventArgs e)
        {
            string fname = Fname_textBox.Text;
            InvDelete obj = new InvDelete();
            Boolean isDeleted = obj.DeleteFromInventory(fname);
            if (isDeleted)
            {
                Reload_Page(sender, e);
            }
        }


        private void Inv_update_button_Click(object sender, EventArgs e)
        {
            isEditing = true;

            if (Inv_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Inv_dataGridView.SelectedRows[0];
                if (row != null)
                {
                    Fname_textBox.Text = row.Cells["Fname"].Value.ToString();
                    Rate_textBox.Text = row.Cells["Rate"].Value.ToString();
                    Qty_textBox.Text = row.Cells["Qty"].Value.ToString();
                    oldfname = Fname_textBox.Text;

                }
            }
            else
            {
                MessageBox.Show("No rows selected");
            }

        }

        

        private void Inv_clear_button_Click(object sender, EventArgs e)
        {
            Reload_Page(sender, e);
        }

        void Reload_Page(object sender, EventArgs e)
        {
            Fname_textBox.Text = "";
            Rate_textBox.Text = "";
            Qty_textBox.Text = "";
            InventoryForm_Load(sender, e);
        }
    }
}
