
using System;
using System.IO;
using System.Windows.Forms;

namespace Main_Form.Admin.Billing
{
    public class ReportForm : Form
    {
        private TextBox logTextBox;

        public ReportForm()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void InitializeComponent()
        {
            logTextBox = new TextBox();
            SuspendLayout();
            // 
            // logTextBox
            // 
            logTextBox.Dock = DockStyle.Fill;
            logTextBox.Location = new Point(0, 0);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(693, 430);
            logTextBox.TabIndex = 0;
            // 
            // ReportForm
            // 
            ClientSize = new Size(693, 430);
            Controls.Add(logTextBox);
            Name = "ReportForm";
            Text = "Billing Logs";
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadLogs()
        {
            string logDirectoryPath = "C:\\Users\\priya\\source\\repos\\GINESYS_CANTEEN\\Logs";
            string logFilePath = Path.Combine(logDirectoryPath, "billing_log.txt");

            try
            {
                // Ensure the directory exists
                if (!Directory.Exists(logDirectoryPath))
                {
                    Directory.CreateDirectory(logDirectoryPath);
                }

                // Check if the log file exists and load it
                if (File.Exists(logFilePath))
                {
                    string logContent = File.ReadAllText(logFilePath);
                    logTextBox.Text = logContent; // Display the logs in the TextBox
                }
                else
                {
                    logTextBox.Text = "No logs available.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
