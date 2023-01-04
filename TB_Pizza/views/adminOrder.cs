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

namespace TB_Pizza.views
{
    public partial class adminOrder : Form
    {
        connection connect = new connection();
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
            dtvOrder.Columns[3].HeaderText = "Beverage dan Lainnya";
            dtvOrder.Columns[4].HeaderText = "Order";
            dtvOrder.Columns[5].HeaderText = "Nomor Meja";
            dtvOrder.Columns[6].HeaderText = "Total";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminOrder_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
