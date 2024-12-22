using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Main_Form.Models
{
    internal class Bill
    {
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
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
