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
    public partial class MiscFoodList : Form
    {
        connection connect = new connection();
        miscfood newMisc = new miscfood();
        string food_id;
        public MiscFoodList()
        {
            InitializeComponent();
        }

        public void ShowConnect()
        {
            // Table Connect
            dtvFoodList.DataSource = connect.ShowData("SELECT * FROM go_miscfood");

            // Table Content
            dtvFoodList.Columns[0].HeaderText = "No.";
            dtvFoodList.Columns[1].HeaderText = "Nama Makanan";
            dtvFoodList.Columns[2].HeaderText = "Jenis";
            dtvFoodList.Columns[3].HeaderText = "Harga";

        }
        private void MiscFoodList_Load(object sender, EventArgs e)
        {
            ShowConnect();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            if (tbFoodName.Text == "" || cbFoodType.SelectedIndex != -1 || tbPrice.Text == "")
            {
                MessageBox.Show("Data Harus Di isi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if ((tbPrice.Text).All(Char.IsNumber))
                {
                    m_miscfood getMisc = new m_miscfood();
                    getMisc.Nama_makanan = tbFoodName.Text;
                    getMisc.Jenis_makanan = cbFoodType.Text;
                    getMisc.Harga = tbPrice.Text;

                    newMisc.Insert(getMisc);

                    tbFoodName.Text = "";
                    cbFoodType.SelectedIndex = -1;
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
            if (tbFoodName.Text == "" || cbFoodType.SelectedIndex != -1 || tbPrice.Text == "")
            {
                MessageBox.Show("Data Harus Di isi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if ((tbPrice.Text).All(Char.IsNumber))
                {
                    m_miscfood getMisc = new m_miscfood();
                    getMisc.Nama_makanan = tbFoodName.Text;
                    getMisc.Jenis_makanan = cbFoodType.Text;
                    getMisc.Harga = tbPrice.Text;

                    newMisc.Update(getMisc, food_id);

                    tbFoodName.Text = "";
                    cbFoodType.SelectedIndex = -1;
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
            m_miscfood getMisc = new m_miscfood();

            newMisc.Delete(getMisc,food_id);

            tbFoodName.Text = "";
            cbFoodType.SelectedIndex = -1;
            tbPrice.Text = "";


            ShowConnect();

        }

        private void dtvFoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            food_id = dtvFoodList.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbFoodName.Text = dtvFoodList.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbFoodType.Text = dtvFoodList.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPrice.Text = dtvFoodList.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
