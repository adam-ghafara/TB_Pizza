namespace TB_Pizza.views
{
    partial class orderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtvPizza = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCustomPizza = new System.Windows.Forms.CheckBox();
            this.gbCustom = new System.Windows.Forms.GroupBox();
            this.cbPineappel = new System.Windows.Forms.CheckBox();
            this.cbTuna = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbPizzaSos = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbCheddar = new System.Windows.Forms.CheckBox();
            this.cbMozarella = new System.Windows.Forms.CheckBox();
            this.cbOlive = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtvMiscfood = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbTakeaway = new System.Windows.Forms.RadioButton();
            this.rbDine = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btMakeOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPizza)).BeginInit();
            this.gbCustom.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMiscfood)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtvPizza);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbCustomPizza);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Silahkan Pilih Pizza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Rp. 25000";
            // 
            // dtvPizza
            // 
            this.dtvPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPizza.Location = new System.Drawing.Point(6, 19);
            this.dtvPizza.Name = "dtvPizza";
            this.dtvPizza.Size = new System.Drawing.Size(669, 110);
            this.dtvPizza.TabIndex = 4;
            this.dtvPizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 73);
            this.label5.TabIndex = 3;
            this.label5.Text = "?";
            // 
            // cbCustomPizza
            // 
            this.cbCustomPizza.AutoSize = true;
            this.cbCustomPizza.Location = new System.Drawing.Point(681, 92);
            this.cbCustomPizza.Name = "cbCustomPizza";
            this.cbCustomPizza.Size = new System.Drawing.Size(89, 17);
            this.cbCustomPizza.TabIndex = 2;
            this.cbCustomPizza.Text = "Custom Pizza";
            this.cbCustomPizza.UseVisualStyleBackColor = true;
            this.cbCustomPizza.CheckedChanged += new System.EventHandler(this.cbCustomPizza_CheckedChanged);
            // 
            // gbCustom
            // 
            this.gbCustom.Controls.Add(this.cbPineappel);
            this.gbCustom.Controls.Add(this.cbTuna);
            this.gbCustom.Controls.Add(this.cbOnion);
            this.gbCustom.Controls.Add(this.cbPizzaSos);
            this.gbCustom.Controls.Add(this.cbSausage);
            this.gbCustom.Controls.Add(this.cbCheddar);
            this.gbCustom.Controls.Add(this.cbMozarella);
            this.gbCustom.Controls.Add(this.cbOlive);
            this.gbCustom.Controls.Add(this.cbPepperoni);
            this.gbCustom.Enabled = false;
            this.gbCustom.Location = new System.Drawing.Point(10, 254);
            this.gbCustom.Name = "gbCustom";
            this.gbCustom.Size = new System.Drawing.Size(411, 135);
            this.gbCustom.TabIndex = 1;
            this.gbCustom.TabStop = false;
            this.gbCustom.Text = "Custom Pizza (Silahkan Pilih Topping)";
            // 
            // cbPineappel
            // 
            this.cbPineappel.AutoSize = true;
            this.cbPineappel.Location = new System.Drawing.Point(225, 103);
            this.cbPineappel.Name = "cbPineappel";
            this.cbPineappel.Size = new System.Drawing.Size(57, 17);
            this.cbPineappel.TabIndex = 8;
            this.cbPineappel.Text = "Nanas";
            this.cbPineappel.UseVisualStyleBackColor = true;
            this.cbPineappel.CheckedChanged += new System.EventHandler(this.cbPineappel_CheckedChanged);
            // 
            // cbTuna
            // 
            this.cbTuna.AutoSize = true;
            this.cbTuna.Location = new System.Drawing.Point(225, 61);
            this.cbTuna.Name = "cbTuna";
            this.cbTuna.Size = new System.Drawing.Size(75, 17);
            this.cbTuna.TabIndex = 7;
            this.cbTuna.Text = "Ikan Tuna";
            this.cbTuna.UseVisualStyleBackColor = true;
            this.cbTuna.CheckedChanged += new System.EventHandler(this.cbTuna_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(225, 19);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(106, 17);
            this.cbOnion.TabIndex = 6;
            this.cbOnion.Text = "Bawang Bombay";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbPizzaSos
            // 
            this.cbPizzaSos.AutoSize = true;
            this.cbPizzaSos.Location = new System.Drawing.Point(129, 106);
            this.cbPizzaSos.Name = "cbPizzaSos";
            this.cbPizzaSos.Size = new System.Drawing.Size(78, 17);
            this.cbPizzaSos.TabIndex = 5;
            this.cbPizzaSos.Text = "Saos Pizza";
            this.cbPizzaSos.UseVisualStyleBackColor = true;
            this.cbPizzaSos.CheckedChanged += new System.EventHandler(this.cbPizzaSos_CheckedChanged);
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(129, 64);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(82, 17);
            this.cbSausage.TabIndex = 4;
            this.cbSausage.Text = "Sosis Bakar";
            this.cbSausage.UseVisualStyleBackColor = true;
            this.cbSausage.CheckedChanged += new System.EventHandler(this.cbSausage_CheckedChanged);
            // 
            // cbCheddar
            // 
            this.cbCheddar.AutoSize = true;
            this.cbCheddar.Location = new System.Drawing.Point(129, 22);
            this.cbCheddar.Name = "cbCheddar";
            this.cbCheddar.Size = new System.Drawing.Size(90, 17);
            this.cbCheddar.TabIndex = 3;
            this.cbCheddar.Text = "Keju Cheddar";
            this.cbCheddar.UseVisualStyleBackColor = true;
            this.cbCheddar.CheckedChanged += new System.EventHandler(this.cbCheddar_CheckedChanged);
            // 
            // cbMozarella
            // 
            this.cbMozarella.AutoSize = true;
            this.cbMozarella.Location = new System.Drawing.Point(28, 106);
            this.cbMozarella.Name = "cbMozarella";
            this.cbMozarella.Size = new System.Drawing.Size(95, 17);
            this.cbMozarella.TabIndex = 2;
            this.cbMozarella.Text = "Keju Mozarella";
            this.cbMozarella.UseVisualStyleBackColor = true;
            this.cbMozarella.CheckedChanged += new System.EventHandler(this.cbMozarella_CheckedChanged);
            // 
            // cbOlive
            // 
            this.cbOlive.AutoSize = true;
            this.cbOlive.Location = new System.Drawing.Point(28, 64);
            this.cbOlive.Name = "cbOlive";
            this.cbOlive.Size = new System.Drawing.Size(84, 17);
            this.cbOlive.TabIndex = 1;
            this.cbOlive.Text = "Buah Zaitun";
            this.cbOlive.UseVisualStyleBackColor = true;
            this.cbOlive.CheckedChanged += new System.EventHandler(this.cbOlive_CheckedChanged);
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(28, 22);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(74, 17);
            this.cbPepperoni.TabIndex = 0;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            this.cbPepperoni.CheckedChanged += new System.EventHandler(this.cbPepperoni_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtvMiscfood);
            this.groupBox3.Location = new System.Drawing.Point(12, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 135);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Makanan Lainnya";
            // 
            // dtvMiscfood
            // 
            this.dtvMiscfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMiscfood.Location = new System.Drawing.Point(6, 17);
            this.dtvMiscfood.Name = "dtvMiscfood";
            this.dtvMiscfood.Size = new System.Drawing.Size(397, 112);
            this.dtvMiscfood.TabIndex = 4;
            this.dtvMiscfood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMiscfood_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.rbTakeaway);
            this.groupBox4.Controls.Add(this.rbDine);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbTable);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbName);
            this.groupBox4.Location = new System.Drawing.Point(427, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 157);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detail Pemesanan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Take Order";
            // 
            // rbTakeaway
            // 
            this.rbTakeaway.AutoSize = true;
            this.rbTakeaway.Location = new System.Drawing.Point(202, 72);
            this.rbTakeaway.Name = "rbTakeaway";
            this.rbTakeaway.Size = new System.Drawing.Size(79, 17);
            this.rbTakeaway.TabIndex = 5;
            this.rbTakeaway.TabStop = true;
            this.rbTakeaway.Text = "Take Away";
            this.rbTakeaway.UseVisualStyleBackColor = true;
            this.rbTakeaway.CheckedChanged += new System.EventHandler(this.rbTakeaway_CheckedChanged);
            // 
            // rbDine
            // 
            this.rbDine.AutoSize = true;
            this.rbDine.Location = new System.Drawing.Point(115, 72);
            this.rbDine.Name = "rbDine";
            this.rbDine.Size = new System.Drawing.Size(59, 17);
            this.rbDine.TabIndex = 4;
            this.rbDine.TabStop = true;
            this.rbDine.Text = "Dine In";
            this.rbDine.UseVisualStyleBackColor = true;
            this.rbDine.CheckedChanged += new System.EventHandler(this.rbDine_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nomor Meja";
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(84, 115);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(239, 20);
            this.tbTable.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(239, 20);
            this.tbName.TabIndex = 0;
            // 
            // btMakeOrder
            // 
            this.btMakeOrder.Location = new System.Drawing.Point(531, 507);
            this.btMakeOrder.Name = "btMakeOrder";
            this.btMakeOrder.Size = new System.Drawing.Size(92, 23);
            this.btMakeOrder.TabIndex = 3;
            this.btMakeOrder.Text = "Buat Pesanan";
            this.btMakeOrder.UseVisualStyleBackColor = true;
            this.btMakeOrder.Click += new System.EventHandler(this.btMakeOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Harga";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(542, 463);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(240, 20);
            this.tbTotal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rp.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 103);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Buat Pesanan";
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(816, 559);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMakeOrder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCustom);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.orderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPizza)).EndInit();
            this.gbCustom.ResumeLayout(false);
            this.gbCustom.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMiscfood)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCustom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btMakeOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbTakeaway;
        private System.Windows.Forms.RadioButton rbDine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.CheckBox cbPizzaSos;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbCheddar;
        private System.Windows.Forms.CheckBox cbMozarella;
        private System.Windows.Forms.CheckBox cbOlive;
        private System.Windows.Forms.CheckBox cbPineappel;
        private System.Windows.Forms.CheckBox cbTuna;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbCustomPizza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtvMiscfood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtvPizza;
        private System.Windows.Forms.Label label8;
    }
}