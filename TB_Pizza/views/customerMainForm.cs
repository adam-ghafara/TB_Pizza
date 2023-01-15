using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace TB_Pizza.views
{
    public partial class customerMainForm : Form
    {
        public customerMainForm()
        {
            InitializeComponent();
        }
        private void keyBinds()
        {
            var Keybinds = new KeyEventArgs(Keys.F1);
            if (Keybinds.Handled)
            {
                Form extraOptions = new extraOptions();
                extraOptions.Show();
            }
        }
        private void customerMainForm_Load(object sender, EventArgs e)
        {
            keyBinds();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderForm makeOrder = new orderForm();
            makeOrder.Show();
            this.Hide();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAdmins_Click(object sender, EventArgs e)
        {
            Form adminForm = new extraOptions();
            adminForm.Show();
            this.Hide();
        }

        private void customerMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemQuotes && e.Modifiers == Keys.Control)
            {
                Form options = new extraOptions();
                options.Show();
                this.Hide();
            }
        }

        private void btSupport_Click(object sender, EventArgs e)
        {
            Form supportBox = new FormSupport();
            supportBox.Show();
        }
    }
}
