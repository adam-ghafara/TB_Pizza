using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Pizza.model
{
    internal class m_order
    {
        string nama, take_order, meja, pizza, p_custom, misc_order, order_total;

        public string Nama { get => nama; set => nama = value; }
        public string Take_order { get => take_order; set => take_order = value; }
        public string Meja { get => meja; set => meja = value; }
        public string Pizza { get => pizza; set => pizza = value; }
        public string P_custom { get => p_custom; set => p_custom = value; }
        public string Misc_order { get => misc_order; set => misc_order = value; }
        public string Order_total { get => order_total; set => order_total = value; }

        public m_order(string nama, string take_order, string meja, string pizza, string p_custom, string misc_order, string order_total)
        {
            this.Nama = nama;
            this.Take_order = take_order;
            this.Meja = meja;
            this.Pizza = pizza;
            this.P_custom = p_custom;
            this.Misc_order = misc_order;
            this.Order_total = order_total;
        }

        public m_order()
        {

        }
    }
}
