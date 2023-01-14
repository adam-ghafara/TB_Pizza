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

        private void dtvPizzaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p_id = dtvPizzaList.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbPizzaName.Text = dtvPizzaList.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbPizzaPromo.Text = dtvPizzaList.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPrice.Text = dtvPizzaList.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
