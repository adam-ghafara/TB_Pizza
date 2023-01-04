using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Pizza.model
{
    internal class m_login
    {
        string user, pass;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        public m_login(string user, string pass)
        {
            this.User = user;
            this.Pass = pass;
        }

        public m_login()
        {

        }
    }
}
