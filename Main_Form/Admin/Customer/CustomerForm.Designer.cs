namespace Main_Form.Admin.Customer
{
    partial class CustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Name_label = new Label();
            Name_textBox = new TextBox();
            Ph_no_textBox = new TextBox();
            Password_textBox = new TextBox();
            Ph_no_label = new Label();
            Password_label = new Label();
            Cus_update_button = new Button();
            Cus_save_button = new Button();
            cus_delete_button = new Button();
            cus_clear_button = new Button();
            Cus_dataGridView = new DataGridView();
            Balance_textBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Cus_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Name_label
            // 
            Name_label.Location = new Point(41, 115);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(75, 24);
            Name_label.TabIndex = 0;
            Name_label.Text = "Name";
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(122, 112);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(304, 27);
            Name_textBox.TabIndex = 1;
            // 
            // Ph_no_textBox
            // 
            Ph_no_textBox.Location = new Point(122, 215);
            Ph_no_textBox.Name = "Ph_no_textBox";
            Ph_no_textBox.Size = new Size(304, 27);
            Ph_no_textBox.TabIndex = 3;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(122, 161);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.Size = new Size(304, 27);
            Password_textBox.TabIndex = 4;
            // 
            // Ph_no_label
            // 
            Ph_no_label.Location = new Point(41, 218);
            Ph_no_label.Name = "Ph_no_label";
            Ph_no_label.Size = new Size(75, 24);
            Ph_no_label.TabIndex = 5;
            Ph_no_label.Text = "Ph_no";
            // 
            // Password_label
            // 
            Password_label.Location = new Point(41, 164);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(75, 24);
            Password_label.TabIndex = 6;
            Password_label.Text = "Password";
            // 
            // Cus_update_button
            // 
            Cus_update_button.Location = new Point(209, 313);
            Cus_update_button.Name = "Cus_update_button";
            Cus_update_button.Size = new Size(94, 29);
            Cus_update_button.TabIndex = 7;
            Cus_update_button.Text = "Update";
            Cus_update_button.UseVisualStyleBackColor = true;
            Cus_update_button.Click += Cus_update_button_Click;
            // 
            // Cus_save_button
            // 
            Cus_save_button.Location = new Point(332, 313);
            Cus_save_button.Name = "Cus_save_button";
            Cus_save_button.Size = new Size(94, 29);
            Cus_save_button.TabIndex = 8;
            Cus_save_button.Text = "Save";
            Cus_save_button.UseVisualStyleBackColor = true;
            Cus_save_button.Click += Cus_save_button_Click;
            // 
            // cus_delete_button
            // 
            cus_delete_button.Location = new Point(209, 358);
            cus_delete_button.Name = "cus_delete_button";
            cus_delete_button.Size = new Size(94, 29);
            cus_delete_button.TabIndex = 9;
            cus_delete_button.Text = "Delete";
            cus_delete_button.UseVisualStyleBackColor = true;
            cus_delete_button.Click += cus_delete_button_Click;
            // 
            // cus_clear_button
            // 
            cus_clear_button.Location = new Point(332, 358);
            cus_clear_button.Name = "cus_clear_button";
            cus_clear_button.Size = new Size(94, 29);
            cus_clear_button.TabIndex = 10;
            cus_clear_button.Text = "Clear";
            cus_clear_button.UseVisualStyleBackColor = true;
            cus_clear_button.Click += cus_clear_button_Click;
            // 
            // Cus_dataGridView
            // 
            Cus_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cus_dataGridView.Location = new Point(499, 91);
            Cus_dataGridView.Name = "Cus_dataGridView";
            Cus_dataGridView.RowHeadersWidth = 51;
            Cus_dataGridView.Size = new Size(543, 296);
            Cus_dataGridView.TabIndex = 11;
            // 
            // Balance_textBox
            // 
            Balance_textBox.Location = new Point(122, 266);
            Balance_textBox.Name = "Balance_textBox";
            Balance_textBox.Size = new Size(304, 27);
            Balance_textBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.Location = new Point(41, 269);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 13;
            label1.Text = "Balance";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1080, 595);
            Controls.Add(label1);
            Controls.Add(Balance_textBox);
            Controls.Add(Cus_dataGridView);
            Controls.Add(cus_clear_button);
            Controls.Add(cus_delete_button);
            Controls.Add(Cus_save_button);
            Controls.Add(Cus_update_button);
            Controls.Add(Password_label);
            Controls.Add(Ph_no_label);
            Controls.Add(Password_textBox);
            Controls.Add(Ph_no_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(Name_label);
            Name = "CustomerForm";
            Text = "Customers";
            Load += Customer_Form_Load;
            ((System.ComponentModel.ISupportInitialize)Cus_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_label;
        private TextBox Name_textBox;
        private TextBox Ph_no_textBox;
        private TextBox Password_textBox;
        private Label Ph_no_label;
        private Label Password_label;
        private Button Cus_update_button;
        private Button Cus_save_button;
        private Button cus_delete_button;
        private Button cus_clear_button;
        private DataGridView Cus_dataGridView;
        private TextBox Balance_textBox;
        private Label label1;
    }
}
