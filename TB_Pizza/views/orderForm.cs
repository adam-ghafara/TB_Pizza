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
    public partial class orderForm : Form
    {
        connection connect = new connection();
        newOrder doOrder = new newOrder();
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
            // Get Food Database
            dtvMiscfood.DataSource = connect.ShowData("SELECT * FROM go_miscfood");

            // Food Table
            dtvMiscfood.Columns[0].HeaderText = "No.";
            dtvMiscfood.Columns[1].HeaderText = "Nama Makanan";
            dtvMiscfood.Columns[2].HeaderText = "Jenis";
            dtvMiscfood.Columns[3].HeaderText = "Harga";

        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            ShowConnect();
        }
        string order_status;
        private void rbDine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDine.Checked)
            {
                order_status = "Dine In";
                rbTakeaway.Checked = false;
            }
        }

        private void rbTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeaway.Checked)
            {
                order_status = "Take Away";
                rbDine.Checked = false;
            }
        }

        string miscfood_list;
        string miscfood_idv;
        string listfood = "- \n";
        private void dtvMiscfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {

            }
        }

        // Custom Pizza Method
        string seperator = ", ";
        private void cbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPepperoni.Checked)
            {
            }
        }

        private void cbOlive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbMozarella_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCheddar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbSausage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPizzaSos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbTuna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPineappel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btMakeOrder_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || order_status == "" || tbTable.Text == "" || tbTotal.Text == "" || p_id == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Pastikan kembali pesanan yang anda pilih sudah sesuai.\n anda yakin ingin membuat pesanan?", "Informasi", MessageBoxButtons.YesNo);
                if (MessageBox.Show("Pastikan kembali pesanan yang anda pilih sudah sesuai.\n anda yakin ingin membuat pesanan?", "Informasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    m_order tryOrder = new m_order();
                    tryOrder.Nama = tbName.Text;
                    tryOrder.Take_order = order_status;
                    tryOrder.Meja = tbTable.Text;
                    tryOrder.Pizza = p_id;
                    tryOrder.Misc_order = miscfood_list;
                    tryOrder.Order_total = tbTotal.Text;

                    doOrder.Insert(tryOrder);

                    tbName.Text = "";
                    order_status = "";
                    tbTable.Text = "";
                    p_id = "";
                    miscfood_list = "";
                    tbTotal.Text = "";


                    ShowConnect();

                }
                else if (MessageBox.Show("Pastikan kembali pesanan yang anda pilih sudah sesuai.\n anda yakin ingin membuat pesanan?", "Informasi", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                }
            }

        }

        private void cbCustomPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustomPizza.Checked)
            {

            }
        }
    }
}
