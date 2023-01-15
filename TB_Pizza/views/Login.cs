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
using TB_Pizza.views;

namespace TB_Pizza
{
    public partial class Login : Form
    {
        logging logprocess = new logging();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" | tbPass.Text == "")
            {
                    MessageBox.Show("Harap isi Password!", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string User = tbID.Text;
                string Pass = tbPass.Text;

                bool status = logprocess.Login(User, Pass);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    customerMainForm dash = new customerMainForm();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }

            }
        }
    }
}
