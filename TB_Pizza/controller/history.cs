using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_Pizza.model;

namespace TB_Pizza.controller
{
    internal class history
    {
        connection koneksi = new connection();
        m_history historyData = new m_history();

        public bool Insert(m_history history, string order_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO go_order (order_date, order_name, order_take, order_table, p_id, p_nama_pizza, order_pizza_topping, order_beverage, order_total) VALUES ('"
                 + history.Tanggal + ",'" + history.Nama + "','" + history.Take_order + "','" + history.Meja + "','" + history.P_id + "','" + history.Pizza + "','" + history.P_custom + "','" + history.Misc_order + "','" + history.Order_total + "')");
                status = true;
                MessageBox.Show("Pemesanan telah di transfer ke History!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Delete(m_history deleteHistory, string history_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM go_order WHERE history_id='"
                    + history_id + "'"); status = true;
                MessageBox.Show("History Pemesanan dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
    }
}
}
