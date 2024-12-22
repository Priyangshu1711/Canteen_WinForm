using Microsoft.Data.SqlClient;
using System.Configuration;
using Main_Form.Admin;
using Main_Form.Admin.Customer;

namespace Main_Form
{
    internal class Program 
    {
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new AdminForm());

        }

        
       
    }
}