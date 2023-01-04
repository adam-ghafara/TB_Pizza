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
    public partial class orderForm : Form
    {
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
    }
}
