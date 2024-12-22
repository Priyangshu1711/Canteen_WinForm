using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Main_Form.Admin.Billing
{
    public class BillReceipt : Form
    {
        private Label totalLabel;
        private ListView itemsListView;
        private BillLogger billLogger;

        public BillReceipt(int totalAmount, BindingList<BillingForm.BillingItem> billingItems, string customerName, int remainingBalance)
        {
            InitializeComponent(totalAmount, billingItems);
            billLogger = new BillLogger("C:\\Users\\priya\\source\\repos\\GINESYS_CANTEEN\\Logs");

            // Log the bill including customer, total amount, item details, and remaining balance
            LogBill(customerName, totalAmount, remainingBalance, billingItems);
        }

        private void InitializeComponent(int totalAmount, BindingList<BillingForm.BillingItem> billingItems)
        {
            // Set up form properties
            this.Text = "Bill Details";
            this.Size = new System.Drawing.Size(400, 300);

            // Total amount label
            totalLabel = new Label
            {
                Text = $"Total Amount: {totalAmount:C}", // Formatting as currency
                Dock = DockStyle.Top,
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Padding = new Padding(10)
            };
            this.Controls.Add(totalLabel);

            // Items ListView
            itemsListView = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };
            itemsListView.Columns.Add("Item", 100);
            itemsListView.Columns.Add("Quantity", 100);
            itemsListView.Columns.Add("Item Total", 100);

            foreach (var item in billingItems)
            {
                var listViewItem = new ListViewItem(item.Fname);
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add(item.ItemTotal.ToString("C"));
                itemsListView.Items.Add(listViewItem);
            }

            this.Controls.Add(itemsListView);
        }

        private void LogBill(string customerName, int totalAmount, int remainingBalance, BindingList<BillingForm.BillingItem> billingItems)
        {
            // Log the entire bill, including customer details, total, itemized billing info, and remaining balance
            billLogger.LogBill(customerName, totalAmount, remainingBalance, billingItems);
        }
    }

    public class BillLogger
    {
        private readonly string logFilePath;

        public BillLogger(string logDirectory)
        {
            logFilePath = Path.Combine(logDirectory, "billing_log.txt");
            RefreshLogIfNeeded();
        }

        private void RefreshLogIfNeeded()
        {
            if (File.Exists(logFilePath))
            {
                var lastWriteTime = File.GetLastWriteTime(logFilePath);
                if (lastWriteTime.Month != DateTime.Now.Month || lastWriteTime.Year != DateTime.Now.Year)
                {
                    File.WriteAllText(logFilePath, ""); // Clear the log file if it’s a new month or year
                }
            }
            else
            {
                File.WriteAllText(logFilePath, ""); // Start with an empty file if it doesn’t exist
            }
        }

        public void LogBill(string customerName, int totalAmount, int remainingBalance, BindingList<BillingForm.BillingItem> billingItems)
        {
            // Log customer name, total amount, and remaining balance
            var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | Customer: {customerName} | Total Amount: {totalAmount:C} | Remaining Balance: {remainingBalance:C}" + Environment.NewLine;
            File.AppendAllText(logFilePath, logEntry);

            // Log details of each billing item
            foreach (var item in billingItems)
            {
                var itemLogEntry = $"\tItem: {item.Fname}, Quantity: {item.Quantity}, Item Total: {item.ItemTotal:C}" + Environment.NewLine;
                File.AppendAllText(logFilePath, itemLogEntry);
            }

            // End with a separator for clarity
            File.AppendAllText(logFilePath, "---------------------------------------" + Environment.NewLine);
        }
    }
}


