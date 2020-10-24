namespace Institute.PL
{
    partial class config
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtserver = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtdatabase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.btnexit = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rbsql = new System.Windows.Forms.RadioButton();
            this.rbwindows = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(50, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "اسم السيرفر ";
            // 
            // txtserver
            // 
            // 
            // 
            // 
            this.txtserver.CustomButton.Image = null;
            this.txtserver.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtserver.CustomButton.Name = "";
            this.txtserver.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtserver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtserver.CustomButton.TabIndex = 1;
            this.txtserver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtserver.CustomButton.UseSelectable = true;
            this.txtserver.CustomButton.Visible = false;
            this.txtserver.Lines = new string[0];
            this.txtserver.Location = new System.Drawing.Point(143, 72);
            this.txtserver.MaxLength = 32767;
            this.txtserver.Name = "txtserver";
            this.txtserver.PasswordChar = '\0';
            this.txtserver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtserver.SelectedText = "";
            this.txtserver.SelectionLength = 0;
            this.txtserver.SelectionStart = 0;
            this.txtserver.ShortcutsEnabled = true;
            this.txtserver.Size = new System.Drawing.Size(177, 23);
            this.txtserver.TabIndex = 1;
            this.txtserver.UseSelectable = true;
            this.txtserver.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtserver.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(50, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "قاعدة البيانات";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtdatabase
            // 
            // 
            // 
            // 
            this.txtdatabase.CustomButton.Image = null;
            this.txtdatabase.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtdatabase.CustomButton.Name = "";
            this.txtdatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdatabase.CustomButton.TabIndex = 1;
            this.txtdatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdatabase.CustomButton.UseSelectable = true;
            this.txtdatabase.CustomButton.Visible = false;
            this.txtdatabase.Lines = new string[0];
            this.txtdatabase.Location = new System.Drawing.Point(143, 111);
            this.txtdatabase.MaxLength = 32767;
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.PasswordChar = '\0';
            this.txtdatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdatabase.SelectedText = "";
            this.txtdatabase.SelectionLength = 0;
            this.txtdatabase.SelectionStart = 0;
            this.txtdatabase.ShortcutsEnabled = true;
            this.txtdatabase.Size = new System.Drawing.Size(177, 23);
            this.txtdatabase.TabIndex = 3;
            this.txtdatabase.UseSelectable = true;
            this.txtdatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(50, 214);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "اسم المستخدم";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(64, 253);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "كلمة المرور";
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(145, 210);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.ReadOnly = true;
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(177, 23);
            this.txtusername.TabIndex = 11;
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(145, 249);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.ReadOnly = true;
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(177, 23);
            this.txtpassword.TabIndex = 12;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(284, 314);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 43);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "حفظ الاعدادت";
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(428, 314);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(82, 43);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "خروج";
            this.btnexit.UseSelectable = true;
            this.btnexit.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(50, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "طريقة الدخول";
            // 
            // rbsql
            // 
            this.rbsql.AutoSize = true;
            this.rbsql.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsql.Location = new System.Drawing.Point(145, 187);
            this.rbsql.Name = "rbsql";
            this.rbsql.Size = new System.Drawing.Size(189, 18);
            this.rbsql.TabIndex = 20;
            this.rbsql.Text = "SQL Server Authentication";
            this.rbsql.UseVisualStyleBackColor = true;
            this.rbsql.CheckedChanged += new System.EventHandler(this.rbsql_CheckedChanged);
            // 
            // rbwindows
            // 
            this.rbwindows.AutoSize = true;
            this.rbwindows.Checked = true;
            this.rbwindows.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbwindows.Location = new System.Drawing.Point(147, 163);
            this.rbwindows.Name = "rbwindows";
            this.rbwindows.Size = new System.Drawing.Size(178, 18);
            this.rbwindows.TabIndex = 21;
            this.rbwindows.TabStop = true;
            this.rbwindows.Text = "Windows Authentication\r\n";
            this.rbwindows.UseVisualStyleBackColor = true;
            this.rbwindows.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 379);
            this.Controls.Add(this.rbwindows);
            this.Controls.Add(this.rbsql);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "config";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " اعدادات التحكم فى اعدادات الاتصال بقاعدة البيانات";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtserver;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtdatabase;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroButton btnsave;
        private MetroFramework.Controls.MetroButton btnexit;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RadioButton rbsql;
        private System.Windows.Forms.RadioButton rbwindows;
    }
}