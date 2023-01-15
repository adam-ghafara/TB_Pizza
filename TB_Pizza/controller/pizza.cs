using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_Pizza.model;

namespace TB_Pizza.controller
{
    internal class pizza
    {
        connection koneksi = new connection();
        m_pizza submitFood = new m_pizza();

        public bool Insert(m_pizza AddFood)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO go_pizza (p_nama_pizza, p_promo, p_harga) VALUES ('" + AddFood.P_name + "','" + AddFood.P_promo + "','" + AddFood.P_price + "')");
                status = true;
                MessageBox.Show("Makanan Telah dimasukkan!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Update(m_pizza updateFood, string p_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE go_pizza SET p_nama_pizza='" + updateFood.P_name + "'," + "p_promo='" + updateFood.P_promo + "'," + "p_harga='" + updateFood.P_price + "' WHERE food_id='" + p_id + "'");
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
        public bool Delete(m_pizza deleteFood, string p_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM go_pizza WHERE p_id='"
                    + p_id + "'"); status = true;
                MessageBox.Show("Makanan Dihapus.", "Informasi",
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
