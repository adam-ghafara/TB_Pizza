using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Pizza.model
{
    internal class m_pizza
    {
        string p_name, p_promo, p_price;

        public string P_name { get => p_name; set => p_name = value; }
        public string P_promo { get => p_promo; set => p_promo = value; }
        public string P_price { get => p_price; set => p_price = value; }

        public m_pizza(string p_name, string p_promo, string p_price)
        {
            this.P_name = p_name;
            this.P_promo = p_promo;
            this.P_price = p_price;
        }

        public m_pizza()
        {

        }
    }
}
