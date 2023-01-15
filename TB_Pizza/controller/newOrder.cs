using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_Pizza.model;

namespace TB_Pizza.controller
{
    internal class newOrder
    {
        connection koneksi = new connection();
        m_order getOrder = new m_order();

        public bool Insert(m_order newOrder)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO go_order (order_name, p_id, order_beverage, order_take, order_table, order_total) VALUES ('"
                    + newOrder.Nama + "','" + newOrder.Pizza + "','" + newOrder.Misc_order + "','" + newOrder.Take_order + "','" + newOrder.Meja + "','" + newOrder.Order_total + "')");
                status = true;
                MessageBox.Show("Pesanan telah berhasil di input. Silahkan menunggu untuk pesanan anda!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Update(m_order updateOrder, string order_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE go_order SET order_name='"
                    + updateOrder.Nama + "'," + "order_table='" + updateOrder.Meja + "'," + "p_id='" + updateOrder.Pizza + "',"
                    + "' WHERE order_id='" + order_id + "'");
                status = true;
                MessageBox.Show("Data berhasil di ubah", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Delete(m_order deleteOrder, string order_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM go_order WHERE order_id='"
                    + order_id + "'"); status = true;
                MessageBox.Show("Order berhasil dihapus", "Informasi",
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
