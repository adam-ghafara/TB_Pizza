using MySql.Data.MySqlClient;
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
        history transferOrder = new history();
        string order_id;
        public adminOrder()
        {
            InitializeComponent();
        }

        public void LoadOrder()
        {
            // Load Database
            dtvOrder.DataSource = connect.ShowData("SELECT order_id, order_date, order_name, order_take, order_table, go_order.p_id, p_nama_pizza, order_pizza_topping, order_beverage, order_total FROM go_order JOIN go_pizza ON go_pizza.p_id = go_order.p_id");

            // Tables
            dtvOrder.Columns[0].HeaderText = "ID";
            dtvOrder.Columns[1].HeaderText = "Tanggal";
            dtvOrder.Columns[2].HeaderText = "Nama";
            dtvOrder.Columns[3].HeaderText = "Order";
            dtvOrder.Columns[4].HeaderText = "Meja";
            dtvOrder.Columns[5].HeaderText = "ID Pizza";
            dtvOrder.Columns[6].HeaderText = "Nama Pizza";
            dtvOrder.Columns[7].HeaderText = "Topping";
            dtvOrder.Columns[8].HeaderText = "Menu Lainnya";
            dtvOrder.Columns[9].HeaderText = "Total";

        }

        public void GetPizzaID()
        {
            connect.OpenConnection();
            MySqlDataReader reader = connect.reader("SELECT * FROM go_pizza");
            while (reader.Read())
            {
                cbIDPizza.Items.Add(reader.GetString("p_id"));
            }
            connect.CloseConnection();
        }

        public void GetPizzaName()
        {
            connect.OpenConnection();
            MySqlDataReader reader = connect.reader("SELECT p_nama_pizza FROM go_pizza " +
                "WHERE p_id= '" + cbIDPizza.Text + "'");
            while (reader.Read())
            {
                tbPizza.Text = reader.GetString(0);
            }
            connect.CloseConnection();
        }
        string orderDate;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            order_id = dtvOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            orderDate = dtvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbName.Text = dtvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbOrderstatus.Text = dtvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbTable.Text = dtvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbIDPizza.Text = dtvOrder.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbPizza.Text = dtvOrder.Rows[e.RowIndex].Cells[6].Value.ToString();
            rtbTopping.Text = dtvOrder.Rows[e.RowIndex].Cells[7].Value.ToString();
            rtbMisc.Text = dtvOrder.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbTotal.Text = dtvOrder.Rows[e.RowIndex].Cells[9].Value.ToString();
        }


        private void adminOrder_Load(object sender, EventArgs e)
        {
            LoadOrder();
            GetPizzaID();
        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbOrderstatus.Text == "" || rtbTopping.Text == "" || rtbMisc.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_order tryOrder = new m_order();
                tryOrder.Nama = tbName.Text;
                tryOrder.Take_order = tbOrderstatus.Text;
                tryOrder.Meja = tbTable.Text;
                tryOrder.P_id = cbIDPizza.Text;
                tryOrder.Pizza = tbPizza.Text;
                tryOrder.P_custom = rtbTopping.Text;
                tryOrder.Misc_order = rtbMisc.Text;
                tryOrder.Order_total = tbTotal.Text;

                setOrder.Update(tryOrder, order_id);

                tbName.Text = "";
                tbOrderstatus.Text = "";
                tbTable.Text = "";
                cbIDPizza.SelectedIndex = -1;
                tbPizza.Text = "";
                rtbTopping.Text = "";
                rtbMisc.Text = "";
                tbTotal.Text = "";


                LoadOrder();

            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            m_order tryOrder = new m_order();
            setOrder.Delete(tryOrder, order_id);

            tbName.Text = "";
            tbOrderstatus.Text = "";
            tbTable.Text = "";
            cbIDPizza.SelectedIndex = -1;
            tbPizza.Text = "";
            rtbTopping.Text = "";
            rtbMisc.Text = "";
            tbTotal.Text = "";

            LoadOrder();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btTransfer_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbOrderstatus.Text == "" || rtbTopping.Text == "" || rtbMisc.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_history getTransferData = new m_history();
                getTransferData.Tanggal = 
                getTransferData.Nama = tbName.Text;
                getTransferData.Take_order = tbOrderstatus.Text;
                getTransferData.Meja = tbTable.Text;
                getTransferData.P_id = cbIDPizza.Text;
                getTransferData.Pizza = tbPizza.Text;
                getTransferData.P_custom = rtbTopping.Text;
                getTransferData.Misc_order = rtbMisc.Text;
                getTransferData.Order_total = tbTotal.Text;

                transferOrder.Insert(getTransferData, order_id);

                tbName.Text = "";
                tbOrderstatus.Text = "";
                tbTable.Text = "";
                cbIDPizza.SelectedIndex = -1;
                tbPizza.Text = "";
                rtbTopping.Text = "";
                rtbMisc.Text = "";
                tbTotal.Text = "";


                LoadOrder();

            }
        }
    }
}
