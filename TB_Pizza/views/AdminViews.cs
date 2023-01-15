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

        private void daftarBeverageDanLainnyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FoodList = new MiscFoodList();
            FoodList.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutUS = new about();
            aboutUS.Show();
        }

        private void supportBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SupportingList = new supportBox();
            SupportingList.Show();
        }

        private void btQuote_Click(object sender, EventArgs e)
        {
            string[] quotes = { "“Start where you are. Use what you have. Do what you can.”\n – Arthur Ashe"
                                   ,"“A diamond is a piece of coal that stuck to the job.”\n– Michael Larsen"
                                   ,"“Throw yourself into some work you believe in with all you heart, live for it, die for it, and you will find happiness that you had thought could never be yours.”\n– Dale Carnegie"
                                   ,"“Everyone talks about building a relationship with your customer. I think you build one with your employees first.”\n – Angela Ahrendts"
                                   ,"“The man who has confidence in himself gains the confidence of others.”\n– Hasidic Proverb"
                                   ,"“Your work is going to fill a large part of your life, and the only way to be truly satisfied is to do what you believe is great work. And the only way to do great work is to love what you do. If you haven’t found it yet, keep looking. Don’t settle.”\n– Steve Jobs"
                                   ,"“The employer generally gets the employees he deserves.”\n– J. Paul Getty"
                                   ,"“The real competitive advantage in any business is one word only, which is ‘people.’”\n– Komil Toume"
                                   ,"“Try not to become a man of success but rather try to become a man of value.”\n– Albert Einstein"
            };
                Random getQuote = new Random();
                int RandomQuote = getQuote.Next(0, 8);
                quotelabel.Text = quotes[RandomQuote];
        }

        private void daftarPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pizzaList = new PizzaList();
            pizzaList.Show();
        }

        private void ReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mainForm = new customerMainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
