namespace Main_Form.Models
{
    internal class Inventory
    {
        private int fid;

        public int Fid
        {
            get { return fid;}
            set { fid = value; }
        }

        private string fname;
        
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        private int rate;

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }

        }
    }
}
