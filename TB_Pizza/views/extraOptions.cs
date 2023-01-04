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
    public partial class extraOptions : Form
    {
        public extraOptions()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void btAdminForm_Click(object sender, EventArgs e)
        {
            AdminViews admins = new AdminViews();
            admins.Show();
        }
    }
}
