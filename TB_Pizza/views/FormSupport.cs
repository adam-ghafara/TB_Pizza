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

namespace TB_Pizza
{
    public partial class FormSupport : Form
    {
        connection connect = new connection();
        support createsupport = new support();
        public FormSupport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || rtbMasukkan.Text == "")
            {
                MessageBox.Show("Data Harus Di isi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                m_support getSupport = new m_support();
                getSupport.Support_name = tbNama.Text;
                getSupport.Support_message = rtbMasukkan.Text;

                createsupport.Insert(getSupport);

                this.Hide();
            }
        }
    }
}
