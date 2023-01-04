using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_Pizza.controller
{
    internal class logging
    {
        connection log = new connection();
        public bool Login(string User, string Pass)
        {
            try
            {
                log.OpenConnection();
                MySqlDataReader reader = log.reader("SELECT * FROM go_user WHERE u_name='" +
                    (User) + "' AND u_password='" + (Pass) + "'");
                if (reader.Read())
                {
                    log.CloseConnection();
                    return true;
                }
                else
                {
                    log.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                log.CloseConnection();
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
