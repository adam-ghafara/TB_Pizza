using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_Pizza.views
{
    public partial class orderHistory : Form
    {
        public orderHistory()
        {
            InitializeComponent();
        }

        private void orderHistory_Load(object sender, EventArgs e)
        {

        }

        public void LoadHistory()
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Form mainAdmin = new AdminViews();
            mainAdmin.Show();
            this.Hide();
        }

        private void btExcelsave_Click(object sender, EventArgs e)
        {

        }


    }
}
