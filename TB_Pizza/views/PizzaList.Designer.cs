namespace TB_Pizza.views
{
    partial class PizzaList
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
            this.btTambah = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUbah = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPizzaPromo = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPizzaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvPizzaList = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPizzaList)).BeginInit();
            this.SuspendLayout();
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(532, 273);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(75, 23);
            this.btTambah.TabIndex = 19;
            this.btTambah.Text = "Tambah";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(700, 339);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 18;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(700, 273);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 17;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(613, 273);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(75, 23);
            this.btUbah.TabIndex = 16;
            this.btUbah.Text = "Ubah";
            this.btUbah.UseVisualStyleBackColor = true;
            this.btUbah.Click += new System.EventHandler(this.btUbah_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPizzaPromo);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbPizzaName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(475, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 177);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // cbPizzaPromo
            // 
            this.cbPizzaPromo.FormattingEnabled = true;
            this.cbPizzaPromo.Items.AddRange(new object[] {
            "Hot!",
            "Special!",
            "Discount!"});
            this.cbPizzaPromo.Location = new System.Drawing.Point(90, 77);
            this.cbPizzaPromo.Name = "cbPizzaPromo";
            this.cbPizzaPromo.Size = new System.Drawing.Size(210, 21);
            this.cbPizzaPromo.TabIndex = 14;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(90, 116);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(210, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Promo";
            // 
            // tbPizzaName
            // 
            this.tbPizzaName.Location = new System.Drawing.Point(90, 38);
            this.tbPizzaName.Name = "tbPizzaName";
            this.tbPizzaName.Size = new System.Drawing.Size(210, 20);
            this.tbPizzaName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Pizza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(475, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Produk";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(70, 28);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(230, 20);
            this.tbFind.TabIndex = 1;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
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
            // dtvPizzaList
            // 
            this.dtvPizzaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvPizzaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPizzaList.Location = new System.Drawing.Point(12, 12);
            this.dtvPizzaList.Name = "dtvPizzaList";
            this.dtvPizzaList.Size = new System.Drawing.Size(457, 350);
            this.dtvPizzaList.TabIndex = 13;
            this.dtvPizzaList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvPizzaList_CellContentClick);
            // 
            // PizzaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUbah);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtvPizzaList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PizzaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Pizza";
            this.Load += new System.EventHandler(this.PizzaList_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPizzaList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPizzaPromo;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPizzaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvPizzaList;
    }
}