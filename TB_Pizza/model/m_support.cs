using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Pizza.model
{
    internal class m_support
    {
        string support_name, support_message;

        public string Support_name { get => support_name; set => support_name = value; }
        public string Support_message { get => support_message; set => support_message = value; }

        public m_support(string support_name, string support_message)
        {
            this.Support_name = support_name;
            this.Support_message = support_message;
        }

        public m_support()
        {
          
        }
    }

}
