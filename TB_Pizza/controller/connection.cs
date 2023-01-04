using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TB_Pizza.controller
{
    internal class connection
    {
        string connectionstring = "Server=localhost;Database=tb_pesanpizza;Uid=root,pwd=;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string Query)
        {
            MySqlCommand command = new MySqlCommand(Query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }

        public MySqlDataReader reader(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, kon);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader dr = commandDatabase.ExecuteReader();
            return dr;
        }
    }
}
