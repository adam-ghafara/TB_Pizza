using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        string pizza_name;
        public orderForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form mainCustomer = new customerMainForm();
            mainCustomer.Show();
            this.Hide();
        }
        public void ShowConnect()
        {
            // Get Pizza Database
            dtvPizza.DataSource = connect.ShowData("SELECT * FROM go_pizza");

            // Pizza Tablle
            dtvPizza.Columns[0].HeaderText = "No.";
            dtvPizza.Columns[1].HeaderText = "Nama Pizza";
            dtvPizza.Columns[2].HeaderText = "Promos";
            dtvPizza.Columns[3].HeaderText = "Harga";

            // Get Food Database
            dtvMiscfood.DataSource = connect.ShowData("SELECT * FROM go_miscfood");

            // Food Table
            dtvMiscfood.Columns[0].HeaderText = "Pilihan";
            dtvMiscfood.Columns[1].HeaderText = "No.";
            dtvMiscfood.Columns[2].HeaderText = "Nama Makanan";
            dtvMiscfood.Columns[3].HeaderText = "Jenis Menu";
            dtvMiscfood.Columns[4].HeaderText = "Harga";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p_id = dtvPizza.Rows[e.RowIndex].Cells[0].Value.ToString();
            pizza_name = dtvPizza.Rows[e.RowIndex].Cells[1].Value.ToString();
            pizzaprice = dtvPizza.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        string miscfood_list;
        string listfood = "- ";
        string stringJump = "\n";
        private void dtvMiscfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == colMenucek.Index && e.RowIndex != -1))
            {
                miscfood_list = listfood += dtvMiscfood.Rows[e.RowIndex].Cells[2].Value.ToString() + stringJump;
                miscfoodprice = dtvMiscfood.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        int pricetotal;
        string pizzaprice;
        string miscfoodprice;
        public void priceoperator()
        {
            pricetotal = Convert.ToInt32(pizzaprice) + Convert.ToInt32(miscfoodprice);
            tbTotal.Text = Convert.ToString(pricetotal);
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            priceoperator();
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
                tbTable.Text = String.Empty;
                tbTable.Enabled = false;
            }
            else
            {
                tbTable.Enabled = true;
            }
        }

        // Custom Pizza Method
        string decideTopping = string.Empty;
        string seperator = ", ";
        private void cbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPepperoni.Checked)
            {
                decideTopping += cbPepperoni.Text + stringJump;
            }
        }
        private void cbOlive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOlive.Checked)
            {
                decideTopping += seperator + cbOlive.Text + stringJump;
            }
        }

        private void cbMozarella_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMozarella.Checked)
            {
                decideTopping += seperator + cbMozarella.Text + stringJump ;
            }
        }

        private void cbCheddar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheddar.Checked)
            {
                decideTopping += seperator + cbCheddar.Text + stringJump;
            }
        }

        private void cbSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSausage.Checked)
            {
                decideTopping += seperator + cbSausage.Text + stringJump;
            }
        }

        private void cbPizzaSos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPizzaSos.Checked)
            {
                decideTopping += seperator + cbPizzaSos.Text + stringJump;
            }
        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnion.Checked)
            {
                decideTopping += seperator + cbOnion.Text + stringJump;
            }
        }

        private void cbTuna_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTuna.Checked)
            {
                decideTopping += seperator + cbTuna.Text + stringJump;
            }
        }

        private void cbPineappel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPineappel.Checked)
            {
                decideTopping += seperator + cbPineappel.Text + stringJump;
            }
        }

        private void btMakeOrder_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || order_status == "" || tbTotal.Text == "" || p_id == "")
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
                    tryOrder.P_id = p_id;
                    tryOrder.Pizza = pizza_name;
                    tryOrder.P_custom = decideTopping;
                    tryOrder.Misc_order = miscfood_list;
                    tryOrder.Order_total = tbTotal.Text;

                    doOrder.Insert(tryOrder);

                    tbName.Text = "";
                    order_status = "";
                    tbTable.Text = "";
                    p_id = "";
                    pizza_name = "";
                    decideTopping = "";
                    miscfood_list = "";
                    tbTotal.Text = "";


                    ShowConnect();
                    this.Hide();
                    Form mainForm = new customerMainForm();
                    mainForm.Show();
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
                dtvPizza.Enabled = false;
                gbCustom.Enabled = true;
                p_id = "101";
            }
            else
            {
                dtvPizza.Enabled = true;
                gbCustom.Enabled = false;
                decideTopping = "";
            }
        }
    }
}
