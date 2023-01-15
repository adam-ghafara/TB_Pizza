using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_Pizza.controller;
using TB_Pizza.model;

namespace TB_Pizza.views
{
    public partial class PizzaList : Form
    {
        connection connect = new connection();
        pizza GetPizza = new pizza();
        string p_id;
        public PizzaList()
        {
            InitializeComponent();
        }

        public void ShowConnect()
        {
            // Get Pizza List
            dtvPizzaList.DataSource = connect.ShowData("SELECT * FROM go_pizza");

            // Table Content
            dtvPizzaList.Columns[0].HeaderText = "No.";
            dtvPizzaList.Columns[1].HeaderText = "Nama Pizza";
            dtvPizzaList.Columns[2].HeaderText = "Promo";
            dtvPizzaList.Columns[3].HeaderText = "Harga";

        }
        private void PizzaList_Load(object sender, EventArgs e)
        {
            ShowConnect();
        }

        private void dtvPizzaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p_id = dtvPizzaList.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbPizzaName.Text = dtvPizzaList.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbPizzaPromo.Text = dtvPizzaList.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPrice.Text = dtvPizzaList.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            if (tbPizzaName.Text == "" || cbPizzaPromo.SelectedIndex == -1 || tbPrice.Text == "")
            {
                MessageBox.Show("Data Harus Di isi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if ((tbPrice.Text).All(Char.IsNumber))
                {
                    m_pizza pizzaData = new m_pizza();
                    pizzaData.P_name = tbPizzaName.Text;
                    pizzaData.P_promo = cbPizzaPromo.Text;
                    pizzaData.P_price = tbPrice.Text;

                    GetPizza.Insert(pizzaData);

                    tbPizzaName.Text = "";
                    cbPizzaPromo.SelectedIndex = -1;
                    tbPrice.Text = "";


                    ShowConnect();
                }
                else
                {
                    MessageBox.Show("Harga hanya dimasukkan Angka Saja.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }

        private void btUbah_Click(object sender, EventArgs e)
        {
            if (tbPizzaName.Text == "" || cbPizzaPromo.SelectedIndex == -1 || tbPrice.Text == "")
            {
                MessageBox.Show("Data Harus Di isi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if ((tbPrice.Text).All(Char.IsNumber))
                {
                    m_pizza pizzaData = new m_pizza();
                    pizzaData.P_name = tbPizzaName.Text;
                    pizzaData.P_promo = cbPizzaPromo.Text;
                    pizzaData.P_price = tbPrice.Text;

                    GetPizza.Update(pizzaData,p_id);

                    tbPizzaName.Text = "";
                    cbPizzaPromo.SelectedIndex = -1;
                    tbPrice.Text = "";


                    ShowConnect();
                }
                else
                {
                    MessageBox.Show("Harga hanya dimasukkan Angka Saja.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            m_pizza pizzaData = new m_pizza();

            GetPizza.Delete(pizzaData, p_id);

            tbPizzaName.Text = "";
            cbPizzaPromo.SelectedIndex = -1;
            tbPrice.Text = "";


            ShowConnect();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            dtvPizzaList.DataSource = connect.ShowData("SELECT * FROM go_pizza WHERE p_nama_pizza LIKE '%' '" + tbFind.Text + "' '%' OR p_promo '%' '" + tbFind.Text + "' '%"); ;
        }


    }
}
