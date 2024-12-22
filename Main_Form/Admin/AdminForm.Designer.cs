namespace Main_Form.Admin
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Billing_button = new Button();
            Report_button = new Button();
            Inventory_button = new Button();
            Customer_button = new Button();
            SuspendLayout();
            // 
            // Billing_button
            // 
            Billing_button.Location = new Point(234, 241);
            Billing_button.Name = "Billing_button";
            Billing_button.Size = new Size(243, 105);
            Billing_button.TabIndex = 2;
            Billing_button.Text = "Billing";
            Billing_button.UseVisualStyleBackColor = true;
            Billing_button.Click += Billing_button_Click;
            // 
            // Report_button
            // 
            Report_button.Location = new Point(580, 241);
            Report_button.Name = "Report_button";
            Report_button.Size = new Size(243, 105);
            Report_button.TabIndex = 3;
            Report_button.Text = "Report";
            Report_button.UseVisualStyleBackColor = true;
            Report_button.Click += Report_button_Click;
            // 
            // Inventory_button
            // 
            Inventory_button.Location = new Point(580, 81);
            Inventory_button.Name = "Inventory_button";
            Inventory_button.Size = new Size(243, 105);
            Inventory_button.TabIndex = 4;
            Inventory_button.Text = "Inventory";
            Inventory_button.UseVisualStyleBackColor = true;
            Inventory_button.Click += Inventory_button_Click;
            // 
            // Customer_button
            // 
            Customer_button.Location = new Point(234, 81);
            Customer_button.Name = "Customer_button";
            Customer_button.Size = new Size(243, 105);
            Customer_button.TabIndex = 5;
            Customer_button.Text = "Customer";
            Customer_button.UseVisualStyleBackColor = true;
            Customer_button.Click += Customer_button_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 595);
            Controls.Add(Customer_button);
            Controls.Add(Inventory_button);
            Controls.Add(Report_button);
            Controls.Add(Billing_button);
            Name = "AdminForm";
            Text = "Admin";
            Load += Admin_Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Billing_button;
        private Button Report_button;
        private Button Inventory_button;
        private Button Customer_button;
    }
}