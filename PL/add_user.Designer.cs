namespace Institute.PL
{
    partial class add_user
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.ComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtconfirm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtusernam = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.ComboBox1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtconfirm);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtusernam);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(21, 203);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 39);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "خروج";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(154, 203);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(99, 39);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.ItemHeight = 23;
            this.ComboBox1.Items.AddRange(new object[] {
            "مدير",
            "محاسب",
            "شئون طلاب"});
            this.ComboBox1.Location = new System.Drawing.Point(247, 81);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(186, 29);
            this.ComboBox1.TabIndex = 1;
            this.ComboBox1.UseSelectable = true;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(451, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "نوع المستخدم";
            // 
            // txtconfirm
            // 
            // 
            // 
            // 
            this.txtconfirm.CustomButton.Image = null;
            this.txtconfirm.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtconfirm.CustomButton.Name = "";
            this.txtconfirm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtconfirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtconfirm.CustomButton.TabIndex = 1;
            this.txtconfirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtconfirm.CustomButton.UseSelectable = true;
            this.txtconfirm.CustomButton.Visible = false;
            this.txtconfirm.Lines = new string[0];
            this.txtconfirm.Location = new System.Drawing.Point(247, 161);
            this.txtconfirm.MaxLength = 32767;
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtconfirm.SelectedText = "";
            this.txtconfirm.SelectionLength = 0;
            this.txtconfirm.SelectionStart = 0;
            this.txtconfirm.ShortcutsEnabled = true;
            this.txtconfirm.Size = new System.Drawing.Size(186, 23);
            this.txtconfirm.TabIndex = 3;
            this.txtconfirm.UseSelectable = true;
            this.txtconfirm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtconfirm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtconfirm.Validated += new System.EventHandler(this.txtconfirm_Validated);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(447, 161);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "تاكيد كلمة المرور";
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.CustomButton.Image = null;
            this.txtpass.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtpass.CustomButton.Name = "";
            this.txtpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpass.CustomButton.TabIndex = 1;
            this.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpass.CustomButton.UseSelectable = true;
            this.txtpass.CustomButton.Visible = false;
            this.txtpass.Lines = new string[0];
            this.txtpass.Location = new System.Drawing.Point(247, 121);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(186, 23);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSelectable = true;
            this.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(459, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "كلمة المرور";
            // 
            // txtusernam
            // 
            // 
            // 
            // 
            this.txtusernam.CustomButton.Image = null;
            this.txtusernam.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtusernam.CustomButton.Name = "";
            this.txtusernam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusernam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusernam.CustomButton.TabIndex = 1;
            this.txtusernam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusernam.CustomButton.UseSelectable = true;
            this.txtusernam.CustomButton.Visible = false;
            this.txtusernam.Lines = new string[0];
            this.txtusernam.Location = new System.Drawing.Point(247, 38);
            this.txtusernam.MaxLength = 32767;
            this.txtusernam.Name = "txtusernam";
            this.txtusernam.PasswordChar = '\0';
            this.txtusernam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusernam.SelectedText = "";
            this.txtusernam.SelectionLength = 0;
            this.txtusernam.SelectionStart = 0;
            this.txtusernam.ShortcutsEnabled = true;
            this.txtusernam.Size = new System.Drawing.Size(186, 23);
            this.txtusernam.TabIndex = 0;
            this.txtusernam.UseSelectable = true;
            this.txtusernam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusernam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(447, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "اسم المستخدم";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 345);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_user";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة مستخدم جديد";
            this.Load += new System.EventHandler(this.add_user_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroButton btnsave;
        public MetroFramework.Controls.MetroTextBox txtusernam;
        public MetroFramework.Controls.MetroTextBox txtpass;
        public MetroFramework.Controls.MetroComboBox ComboBox1;
        public MetroFramework.Controls.MetroTextBox txtconfirm;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroButton metroButton1;
    }
}