using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_Pizza.model;

namespace TB_Pizza.controller
{
    internal class support
    {
        connection koneksi = new connection();
        m_support supportbox = new m_support();

        public bool Insert(m_support NewMessage)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO go_support (support_name, support_message) VALUES ('"
                    + NewMessage.Support_name + "','" + NewMessage.Support_message + "')");
                status = true;
                MessageBox.Show("Masukkan Telah diterima! Terima Kasih telah memberi masukkan anda kepada kami.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return status;
        }
        public bool Delete(m_support SolveSupport, string support_id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM go_support WHERE support_id='"
                    + support_id + "'"); status = true;
                MessageBox.Show("Masukkan telah di selesaikan, Masukkan ini akan dihapus.", "Informasi",
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
