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
    public partial class AdminViews : Form
    {
        public AdminViews()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void daftarPesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form adminOrderGrid = new adminOrder();
            adminOrderGrid.Show();
        }
    }
}
