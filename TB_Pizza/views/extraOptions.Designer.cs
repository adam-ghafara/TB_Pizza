namespace TB_Pizza.views
{
    partial class extraOptions
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
            this.btLogin = new System.Windows.Forms.Button();
            this.btAdminForm = new System.Windows.Forms.Button();
            this.btOption = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(59, 50);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(125, 37);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // btAdminForm
            // 
            this.btAdminForm.Location = new System.Drawing.Point(59, 106);
            this.btAdminForm.Name = "btAdminForm";
            this.btAdminForm.Size = new System.Drawing.Size(125, 37);
            this.btAdminForm.TabIndex = 1;
            this.btAdminForm.Text = "Pojok Admins";
            this.btAdminForm.UseVisualStyleBackColor = true;
            this.btAdminForm.Click += new System.EventHandler(this.btAdminForm_Click);
            // 
            // btOption
            // 
            this.btOption.Location = new System.Drawing.Point(59, 162);
            this.btOption.Name = "btOption";
            this.btOption.Size = new System.Drawing.Size(125, 37);
            this.btOption.TabIndex = 2;
            this.btOption.Text = "Opsi";
            this.btOption.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // extraOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 342);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btOption);
            this.Controls.Add(this.btAdminForm);
            this.Controls.Add(this.btLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "extraOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btAdminForm;
        private System.Windows.Forms.Button btOption;
        private System.Windows.Forms.Button button4;
    }
}