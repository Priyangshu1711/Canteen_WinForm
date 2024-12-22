namespace Main_Form.Admin.Billing
{
    partial class BillingForm
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
            Food_Cart_dataGridView = new DataGridView();
            label1 = new Label();
            Total_textBox = new TextBox();
            Total_label = new Label();
            CheckOut_button = new Button();
            label2 = new Label();
            Available_Items_dataGridView = new DataGridView();
            label3 = new Label();
            Ph_no_textBox = new TextBox();
            Fid_textBox = new TextBox();
            Fid_label = new Label();
            Qty_textBox = new TextBox();
            label5 = new Label();
            Add_button = new Button();
            Delete_button = new Button();
            Calculate_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Food_Cart_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Available_Items_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Food_Cart_dataGridView
            // 
            Food_Cart_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Food_Cart_dataGridView.Location = new Point(772, 49);
            Food_Cart_dataGridView.Name = "Food_Cart_dataGridView";
            Food_Cart_dataGridView.RowHeadersWidth = 51;
            Food_Cart_dataGridView.Size = new Size(276, 365);
            Food_Cart_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(808, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "Food Cart";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Total_textBox
            // 
            Total_textBox.Location = new Point(923, 430);
            Total_textBox.Name = "Total_textBox";
            Total_textBox.Size = new Size(125, 27);
            Total_textBox.TabIndex = 2;
            // 
            // Total_label
            // 
            Total_label.AutoSize = true;
            Total_label.Location = new Point(868, 433);
            Total_label.Name = "Total_label";
            Total_label.Size = new Size(49, 20);
            Total_label.TabIndex = 3;
            Total_label.Text = "Total :";
            Total_label.TextAlign = ContentAlignment.BottomCenter;
            // 
            // CheckOut_button
            // 
            CheckOut_button.BackColor = SystemColors.ButtonFace;
            CheckOut_button.Location = new Point(954, 479);
            CheckOut_button.Name = "CheckOut_button";
            CheckOut_button.Size = new Size(94, 25);
            CheckOut_button.TabIndex = 4;
            CheckOut_button.Text = "CheckOut";
            CheckOut_button.UseVisualStyleBackColor = false;
            CheckOut_button.Click += CheckOut_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 36);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 5;
            label2.Text = "Customer Phno:";
            // 
            // Available_Items_dataGridView
            // 
            Available_Items_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Available_Items_dataGridView.Location = new Point(419, 49);
            Available_Items_dataGridView.Name = "Available_Items_dataGridView";
            Available_Items_dataGridView.RowHeadersWidth = 51;
            Available_Items_dataGridView.Size = new Size(300, 365);
            Available_Items_dataGridView.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(468, 9);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 7;
            label3.Text = "Available Items";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ph_no_textBox
            // 
            Ph_no_textBox.Location = new Point(23, 59);
            Ph_no_textBox.Name = "Ph_no_textBox";
            Ph_no_textBox.Size = new Size(288, 27);
            Ph_no_textBox.TabIndex = 8;
            Ph_no_textBox.TextChanged += Ph_no_textBox_TextChanged;
            // 
            // Fid_textBox
            // 
            Fid_textBox.Location = new Point(23, 122);
            Fid_textBox.Name = "Fid_textBox";
            Fid_textBox.Size = new Size(288, 27);
            Fid_textBox.TabIndex = 10;
            // 
            // Fid_label
            // 
            Fid_label.AutoSize = true;
            Fid_label.Location = new Point(23, 99);
            Fid_label.Name = "Fid_label";
            Fid_label.Size = new Size(66, 20);
            Fid_label.TabIndex = 9;
            Fid_label.Text = "Item Fid:";
            // 
            // Qty_textBox
            // 
            Qty_textBox.Location = new Point(23, 187);
            Qty_textBox.Name = "Qty_textBox";
            Qty_textBox.Size = new Size(288, 27);
            Qty_textBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 164);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 11;
            label5.Text = "Qty:";
            // 
            // Add_button
            // 
            Add_button.BackColor = SystemColors.ButtonFace;
            Add_button.Location = new Point(217, 242);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 14;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = SystemColors.ButtonFace;
            Delete_button.Location = new Point(102, 242);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(94, 29);
            Delete_button.TabIndex = 15;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            Delete_button.Click += Delete_button_Click;
            // 
            // Calculate_button
            // 
            Calculate_button.BackColor = SystemColors.ButtonFace;
            Calculate_button.Location = new Point(752, 430);
            Calculate_button.Name = "Calculate_button";
            Calculate_button.Size = new Size(94, 29);
            Calculate_button.TabIndex = 16;
            Calculate_button.Text = "Calculate";
            Calculate_button.UseVisualStyleBackColor = false;
            Calculate_button.Click += Calculate_Click;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1073, 538);
            Controls.Add(Calculate_button);
            Controls.Add(Delete_button);
            Controls.Add(Add_button);
            Controls.Add(Qty_textBox);
            Controls.Add(label5);
            Controls.Add(Fid_textBox);
            Controls.Add(Fid_label);
            Controls.Add(Ph_no_textBox);
            Controls.Add(label3);
            Controls.Add(Available_Items_dataGridView);
            Controls.Add(label2);
            Controls.Add(CheckOut_button);
            Controls.Add(Total_label);
            Controls.Add(Total_textBox);
            Controls.Add(label1);
            Controls.Add(Food_Cart_dataGridView);
            Name = "BillingForm";
            Text = "Billing";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)Food_Cart_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Available_Items_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Food_Cart_dataGridView;
        private Label label1;
        private TextBox Total_textBox;
        private Label Total_label;
        private Button CheckOut_button;
        private Label label2;
        private DataGridView Available_Items_dataGridView;
        private Label label3;
        private TextBox Ph_no_textBox;
        private TextBox Fid_textBox;
        private Label Fid_label;
        private TextBox Qty_textBox;
        private Label label5;
        private Button Add_button;
        private Button Delete_button;
        private Button Calculate_button;
    }
}