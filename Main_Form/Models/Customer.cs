namespace Main_Form.Models
{
    internal class Customer
    {
        private int id;
        public int Id
        {
            get { return id;}
            set { id = value; }
        }

        private string? name;
        public string? Name
        {
            get { return name;}
            set { name = value; }
        }
        
        private string? password;
        public string? Password
        {
            get { return password; }
            set { password = value; }
        }

        private string? ph_no;
        public string? Phno
        {
            get { return ph_no; }
            set { ph_no = value; }
        }

        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
