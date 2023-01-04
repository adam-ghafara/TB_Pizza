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
    public partial class orderForm : Form
    {
        connection connect = new connection();
        string p_id;
        public orderForm()
        {
            InitializeComponent();
        }

        string order_misc;
        private void button2_Click(object sender, EventArgs e)
        {
            Form mainCustomer = new customerMainForm();
            mainCustomer.Show();
            this.Hide();
        }
        public void ShowConnect()
        {
            // Get Database
            dtvPizza.DataSource = connect.ShowData("SELECT (p_nama_pizza, p_promo_mode, p_harga, p_gambar) FROM go_pizza");

            // Table
            dtvPizza.Columns[0].HeaderText = "Nama Pizza";
            dtvPizza.Columns[1].HeaderText = "Promo";
            dtvPizza.Columns[2].HeaderText = "Harga";
            dtvPizza.Columns[3].HeaderText = "Penyajian";

        }
        private void dtvPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            ShowConnect();
        }

        private void btMakeOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
