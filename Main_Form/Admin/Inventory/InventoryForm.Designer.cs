namespace Main_Form.Admin.Inventory
{
    partial class InventoryForm
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
            Inv_dataGridView = new DataGridView();
            Inv_clear_button = new Button();
            Inv_delete_button = new Button();
            Inv_save_button = new Button();
            Inv_update_button = new Button();
            Rate_label = new Label();
            Rate_textBox = new TextBox();
            Fname_textBox = new TextBox();
            Fname_label = new Label();
            Qty_textBox = new TextBox();
            Qty = new Label();
            ((System.ComponentModel.ISupportInitialize)Inv_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Inv_dataGridView
            // 
            Inv_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inv_dataGridView.Location = new Point(523, 87);
            Inv_dataGridView.Name = "Inv_dataGridView";
            Inv_dataGridView.RowHeadersWidth = 51;
            Inv_dataGridView.Size = new Size(510, 266);
            Inv_dataGridView.TabIndex = 22;
            // 
            // Inv_clear_button
            // 
            Inv_clear_button.Location = new Point(323, 309);
            Inv_clear_button.Name = "Inv_clear_button";
            Inv_clear_button.Size = new Size(94, 29);
            Inv_clear_button.TabIndex = 21;
            Inv_clear_button.Text = "Clear";
            Inv_clear_button.UseVisualStyleBackColor = true;
            Inv_clear_button.Click += Inv_clear_button_Click;
            // 
            // Inv_delete_button
            // 
            Inv_delete_button.Location = new Point(200, 309);
            Inv_delete_button.Name = "Inv_delete_button";
            Inv_delete_button.Size = new Size(94, 29);
            Inv_delete_button.TabIndex = 20;
            Inv_delete_button.Text = "Delete";
            Inv_delete_button.UseVisualStyleBackColor = true;
            Inv_delete_button.Click += Inv_delete_button_Click;
            // 
            // Inv_save_button
            // 
            Inv_save_button.Location = new Point(323, 264);
            Inv_save_button.Name = "Inv_save_button";
            Inv_save_button.Size = new Size(94, 29);
            Inv_save_button.TabIndex = 19;
            Inv_save_button.Text = "Save";
            Inv_save_button.UseVisualStyleBackColor = true;
            Inv_save_button.Click += Inv_save_button_Click;
            // 
            // Inv_update_button
            // 
            Inv_update_button.Location = new Point(200, 264);
            Inv_update_button.Name = "Inv_update_button";
            Inv_update_button.Size = new Size(94, 29);
            Inv_update_button.TabIndex = 18;
            Inv_update_button.Text = "Update";
            Inv_update_button.UseVisualStyleBackColor = true;
            Inv_update_button.Click += Inv_update_button_Click;
            // 
            // Rate_label
            // 
            Rate_label.Location = new Point(32, 160);
            Rate_label.Name = "Rate_label";
            Rate_label.Size = new Size(75, 24);
            Rate_label.TabIndex = 17;
            Rate_label.Text = "Rate";
            // 
            // Rate_textBox
            // 
            Rate_textBox.Location = new Point(113, 157);
            Rate_textBox.Name = "Rate_textBox";
            Rate_textBox.Size = new Size(304, 27);
            Rate_textBox.TabIndex = 15;
            // 
            // Fname_textBox
            // 
            Fname_textBox.Location = new Point(113, 108);
            Fname_textBox.Name = "Fname_textBox";
            Fname_textBox.Size = new Size(304, 27);
            Fname_textBox.TabIndex = 13;
            // 
            // Fname_label
            // 
            Fname_label.Location = new Point(32, 111);
            Fname_label.Name = "Fname_label";
            Fname_label.Size = new Size(75, 24);
            Fname_label.TabIndex = 12;
            Fname_label.Text = "Fname";
            // 
            // Qty_textBox
            // 
            Qty_textBox.Location = new Point(113, 210);
            Qty_textBox.Name = "Qty_textBox";
            Qty_textBox.Size = new Size(304, 27);
            Qty_textBox.TabIndex = 23;
            // 
            // Qty
            // 
            Qty.Location = new Point(32, 210);
            Qty.Name = "Qty";
            Qty.Size = new Size(75, 24);
            Qty.TabIndex = 24;
            Qty.Text = "Qty";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1080, 595);
            Controls.Add(Qty);
            Controls.Add(Qty_textBox);
            Controls.Add(Inv_dataGridView);
            Controls.Add(Inv_clear_button);
            Controls.Add(Inv_delete_button);
            Controls.Add(Inv_save_button);
            Controls.Add(Inv_update_button);
            Controls.Add(Rate_label);
            Controls.Add(Rate_textBox);
            Controls.Add(Fname_textBox);
            Controls.Add(Fname_label);
            Name = "InventoryForm";
            Text = "Inventory";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)Inv_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Inv_dataGridView;
        private Button Inv_clear_button;
        private Button Inv_delete_button;
        private Button Inv_save_button;
        private Button Inv_update_button;
        private Label Rate_label;
        private TextBox Rate_textBox;
        private TextBox Fname_textBox;
        private Label Fname_label;
        private TextBox Qty_textBox;
        private Label Qty;
    }
}