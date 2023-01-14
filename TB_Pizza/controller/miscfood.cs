using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_Pizza.model;

namespace TB_Pizza.controller
{
    internal class miscfood
    {
        connection koneksi = new connection();
        m_miscfood submitFood = new m_miscfood();

        public bool Insert(m_miscfood AddFood)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO go_miscfood (food_name, food_type, food_price) VALUES ('"
                    + AddFood.Nama_makanan + "','" + AddFood.Jenis_makanan + "," + AddFood.Harga + "')");
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
        public bool Update(m_miscfood updateFood, string food_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE go_miscfood SET food_name='"
                    + updateFood.Nama_makanan + "'," + "food_type='" + updateFood.Jenis_makanan + "'," + "food_price='" + updateFood.Harga + "',"
                    + "' WHERE food_id='" + food_id + "'");
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
        public bool Delete(m_miscfood deleteFood, string food_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM go_miscfood WHERE food_id='"
                    + food_id + "'"); status = true;
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
