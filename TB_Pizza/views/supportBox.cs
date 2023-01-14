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
    public partial class supportBox : Form
    {
        connection connect = new connection();
        public supportBox()
        {
            InitializeComponent();
        }

        public void ShowConnect()
        {
            // Load Support
            dtvSupportBox.DataSource = connect.ShowData("SELECT * FROM go_support");

            // Load to Table View
            dtvSupportBox.Columns[0].HeaderText = "No.";
            dtvSupportBox.Columns[1].HeaderText = "Nama";
            dtvSupportBox.Columns[2].HeaderText = "Masukkan";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void supportBox_Load(object sender, EventArgs e)
        {
            ShowConnect();
        }
    }
}
