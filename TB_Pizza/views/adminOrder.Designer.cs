namespace TB_Pizza.views
{
    partial class adminOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtvOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPizza = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbMisc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbTopping = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrderstatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btUbah = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btTransfer = new System.Windows.Forms.Button();
            this.cbIDPizza = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvOrder
            // 
            this.dtvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvOrder.Location = new System.Drawing.Point(12, 12);
            this.dtvOrder.Name = "dtvOrder";
            this.dtvOrder.Size = new System.Drawing.Size(457, 541);
            this.dtvOrder.TabIndex = 0;
            this.dtvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(475, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Pesanan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbIDPizza);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbPizza);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbTable);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rtbMisc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rtbTopping);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbOrderstatus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(475, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 397);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Pesanan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "ID Pizza";
            // 
            // tbPizza
            // 
            this.tbPizza.Location = new System.Drawing.Point(90, 204);
            this.tbPizza.Name = "tbPizza";
            this.tbPizza.Size = new System.Drawing.Size(210, 20);
            this.tbPizza.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pizza";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(90, 371);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(210, 20);
            this.tbTotal.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rp.";
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(90, 116);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(210, 20);
            this.tbTable.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "No Meja";
            // 
            // rtbMisc
            // 
            this.rtbMisc.Location = new System.Drawing.Point(26, 306);
            this.rtbMisc.Name = "rtbMisc";
            this.rtbMisc.Size = new System.Drawing.Size(274, 46);
            this.rtbMisc.TabIndex = 11;
            this.rtbMisc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pesanan Lainnya";
            // 
            // rtbTopping
            // 
            this.rtbTopping.Location = new System.Drawing.Point(26, 245);
            this.rtbTopping.Name = "rtbTopping";
            this.rtbTopping.Size = new System.Drawing.Size(274, 42);
            this.rtbTopping.TabIndex = 9;
            this.rtbTopping.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Detail Pesanan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Topping";
            // 
            // tbOrderstatus
            // 
            this.tbOrderstatus.Location = new System.Drawing.Point(90, 77);
            this.tbOrderstatus.Name = "tbOrderstatus";
            this.tbOrderstatus.Size = new System.Drawing.Size(210, 20);
            this.tbOrderstatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Take Order";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(70, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 20);
            this.tbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(613, 493);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(75, 23);
            this.btUbah.TabIndex = 3;
            this.btUbah.Text = "Ubah";
            this.btUbah.UseVisualStyleBackColor = true;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(700, 493);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 4;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(700, 531);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btTransfer
            // 
            this.btTransfer.Location = new System.Drawing.Point(489, 493);
            this.btTransfer.Name = "btTransfer";
            this.btTransfer.Size = new System.Drawing.Size(118, 23);
            this.btTransfer.TabIndex = 6;
            this.btTransfer.Text = "Transfer ke History";
            this.btTransfer.UseVisualStyleBackColor = true;
            this.btTransfer.Click += new System.EventHandler(this.btTransfer_Click);
            // 
            // cbIDPizza
            // 
            this.cbIDPizza.FormattingEnabled = true;
            this.cbIDPizza.Location = new System.Drawing.Point(90, 177);
            this.cbIDPizza.Name = "cbIDPizza";
            this.cbIDPizza.Size = new System.Drawing.Size(54, 21);
            this.cbIDPizza.TabIndex = 20;
            // 
            // adminOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btTransfer);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUbah);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "adminOrder";
            this.Text = "adminOrder";
            this.Load += new System.EventHandler(this.adminOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbOrderstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbTopping;
        private System.Windows.Forms.RichTextBox rtbMisc;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btTransfer;
        private System.Windows.Forms.TextBox tbPizza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbIDPizza;
    }
}