using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void ExportExcel(DataGridView dataGrid, string searchData)
        {
            string Output = "";
            string Headers = "";

            // Exporting Title
            for (int j = 0; j < dataGrid.ColumnCount; j++)
            {
                Headers = Headers.ToString() + Convert.ToString(dataGrid.Columns[j].HeaderText) + "\t";

            }
            Output += Headers + "\r\n";

            // Export Data
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                string Line = "";
                for (int j = 0; j < dataGrid.Rows[i].Cells.Count; j++)
                {
                    Line = Line.ToString() + Convert.ToString(dataGrid.Rows[i].Cells[j].Value) + "\t";
                }
                Output += Line + "\r\n";
            }
            Encoding encoding = Encoding.GetEncoding(1254);
            // array dgn tipe byte
            byte[] outputs = encoding.GetBytes(Output);
            FileStream file = new FileStream(searchData, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);

            binary.Write(outputs, 0, outputs.Length);
            binary.Flush();
            binary.Close();
            file.Close();
        }

        private void btExcelsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xls)|*.xls";
            save.FileName = "History Pemesanan.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(dtvHistory, save.FileName);
            }
        }


    }
}
