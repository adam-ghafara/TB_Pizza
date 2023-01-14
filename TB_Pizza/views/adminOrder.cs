using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_Pizza.controller;
using TB_Pizza.model;

namespace TB_Pizza.views
{
    public partial class adminOrder : Form
    {
        connection connect = new connection();
        newOrder setOrder = new newOrder();
        string order_id;
        public adminOrder()
        {
            InitializeComponent();
        }

        public void LoadOrder()
        {
            // Load Database
            dtvOrder.DataSource = connect.ShowData("SELECT * FROM go_order");

            // Tables
            dtvOrder.Columns[0].HeaderText = "ID";
            dtvOrder.Columns[1].HeaderText = "Nama";
            dtvOrder.Columns[2].HeaderText = "Pizza";
            dtvOrder.Columns[3].HeaderText = "Pesanan Lainnya";
            dtvOrder.Columns[4].HeaderText = "Order";
            dtvOrder.Columns[5].HeaderText = "Nomor Meja";
            dtvOrder.Columns[6].HeaderText = "Total";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            order_id = dtvOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbName.Text = dtvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtbPizza.Text = dtvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
            rtbMisc.Text = dtvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbOrderstatus.Text = dtvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTable.Text = dtvOrder.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbTotal.Text = dtvOrder.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void adminOrder_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbOrderstatus.Text == "" || tbTable.Text == "" || rtbPizza.Text == "" || rtbMisc.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_order tryOrder = new m_order();
                tryOrder.Nama = tbName.Text;
                tryOrder.Take_order = tbOrderstatus.Text;
                tryOrder.Meja = tbTable.Text;
                tryOrder.Pizza = rtbPizza.Text;
                tryOrder.Misc_order = rtbMisc.Text;
                tryOrder.Order_total = tbTotal.Text;

                setOrder.Update(tryOrder, order_id);

                tbName.Text = "";
                tbOrderstatus.Text = "";
                tbTable.Text = "";
                rtbPizza.Text = "";
                rtbMisc.Text = "";
                tbTotal.Text = "";


                LoadOrder();

            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            m_order tryOrder = new m_order();
            setOrder.Delete(tryOrder, order_id);

            tryOrder.Nama = tbName.Text;
            tryOrder.Take_order = tbOrderstatus.Text;
            tryOrder.Meja = tbTable.Text;
            tryOrder.Pizza = rtbPizza.Text;
            tryOrder.Misc_order = rtbMisc.Text;
            tryOrder.Order_total = tbTotal.Text;

            LoadOrder();
        }
    }
}
