namespace Institute.PL
{
    partial class add_subject
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
            this.ComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtsubject = new MetroFramework.Controls.MetroTextBox();
            this.btnaddsubject = new MetroFramework.Controls.MetroButton();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbLevel = new MetroFramework.Controls.MetroComboBox();
            this.cmbSem = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtinstructor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txttotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtsub_t = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.ItemHeight = 23;
            this.ComboBox1.Location = new System.Drawing.Point(185, 68);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(207, 29);
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.UseSelectable = true;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.ComboBox1.SelectedValueChanged += new System.EventHandler(this.ComboBox1_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "القسم";
            // 
            // txtsubject
            // 
            // 
            // 
            // 
            this.txtsubject.CustomButton.Image = null;
            this.txtsubject.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtsubject.CustomButton.Name = "";
            this.txtsubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsubject.CustomButton.TabIndex = 1;
            this.txtsubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsubject.CustomButton.UseSelectable = true;
            this.txtsubject.CustomButton.Visible = false;
            this.txtsubject.Lines = new string[0];
            this.txtsubject.Location = new System.Drawing.Point(185, 252);
            this.txtsubject.MaxLength = 32767;
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.PasswordChar = '\0';
            this.txtsubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsubject.SelectedText = "";
            this.txtsubject.SelectionLength = 0;
            this.txtsubject.SelectionStart = 0;
            this.txtsubject.ShortcutsEnabled = true;
            this.txtsubject.Size = new System.Drawing.Size(207, 23);
            this.txtsubject.TabIndex = 4;
            this.txtsubject.UseSelectable = true;
            this.txtsubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnaddsubject
            // 
            this.btnaddsubject.Location = new System.Drawing.Point(193, 392);
            this.btnaddsubject.Name = "btnaddsubject";
            this.btnaddsubject.Size = new System.Drawing.Size(92, 33);
            this.btnaddsubject.TabIndex = 7;
            this.btnaddsubject.Text = "اضافة";
            this.btnaddsubject.UseSelectable = true;
            this.btnaddsubject.Click += new System.EventHandler(this.btnaddsubject_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(353, 392);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 33);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "خروج";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 256);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "المادة";
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.ItemHeight = 23;
            this.cmbLevel.Location = new System.Drawing.Point(185, 117);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(207, 29);
            this.cmbLevel.TabIndex = 1;
            this.cmbLevel.UseSelectable = true;
            this.cmbLevel.SelectedIndexChanged += new System.EventHandler(this.cmbLevel_SelectedIndexChanged);
            // 
            // cmbSem
            // 
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.ItemHeight = 23;
            this.cmbSem.Location = new System.Drawing.Point(185, 170);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(207, 29);
            this.cmbSem.TabIndex = 2;
            this.cmbSem.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "الفرقه";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "الترم";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 218);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "اسم المحاضر";
            // 
            // txtinstructor
            // 
            // 
            // 
            // 
            this.txtinstructor.CustomButton.Image = null;
            this.txtinstructor.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtinstructor.CustomButton.Name = "";
            this.txtinstructor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtinstructor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtinstructor.CustomButton.TabIndex = 1;
            this.txtinstructor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtinstructor.CustomButton.UseSelectable = true;
            this.txtinstructor.CustomButton.Visible = false;
            this.txtinstructor.Lines = new string[0];
            this.txtinstructor.Location = new System.Drawing.Point(185, 214);
            this.txtinstructor.MaxLength = 32767;
            this.txtinstructor.Name = "txtinstructor";
            this.txtinstructor.PasswordChar = '\0';
            this.txtinstructor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtinstructor.SelectedText = "";
            this.txtinstructor.SelectionLength = 0;
            this.txtinstructor.SelectionStart = 0;
            this.txtinstructor.ShortcutsEnabled = true;
            this.txtinstructor.Size = new System.Drawing.Size(207, 23);
            this.txtinstructor.TabIndex = 3;
            this.txtinstructor.UseSelectable = true;
            this.txtinstructor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtinstructor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 299);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(109, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "الدرجة الكلية للمادة";
            // 
            // txttotal
            // 
            // 
            // 
            // 
            this.txttotal.CustomButton.Image = null;
            this.txttotal.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txttotal.CustomButton.Name = "";
            this.txttotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttotal.CustomButton.TabIndex = 1;
            this.txttotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttotal.CustomButton.UseSelectable = true;
            this.txttotal.CustomButton.Visible = false;
            this.txttotal.Lines = new string[0];
            this.txttotal.Location = new System.Drawing.Point(185, 295);
            this.txttotal.MaxLength = 32767;
            this.txttotal.Name = "txttotal";
            this.txttotal.PasswordChar = '\0';
            this.txttotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttotal.SelectedText = "";
            this.txttotal.SelectionLength = 0;
            this.txttotal.SelectionStart = 0;
            this.txttotal.ShortcutsEnabled = true;
            this.txttotal.Size = new System.Drawing.Size(207, 23);
            this.txttotal.TabIndex = 5;
            this.txttotal.UseSelectable = true;
            this.txttotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            this.txttotal.Validated += new System.EventHandler(this.txttotal_Validated);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(24, 340);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(150, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "الدرجة  الغياب الكلية للمادة";
            // 
            // txtsub_t
            // 
            // 
            // 
            // 
            this.txtsub_t.CustomButton.Image = null;
            this.txtsub_t.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtsub_t.CustomButton.Name = "";
            this.txtsub_t.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsub_t.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsub_t.CustomButton.TabIndex = 1;
            this.txtsub_t.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsub_t.CustomButton.UseSelectable = true;
            this.txtsub_t.CustomButton.Visible = false;
            this.txtsub_t.Lines = new string[0];
            this.txtsub_t.Location = new System.Drawing.Point(185, 336);
            this.txtsub_t.MaxLength = 32767;
            this.txtsub_t.Name = "txtsub_t";
            this.txtsub_t.PasswordChar = '\0';
            this.txtsub_t.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsub_t.SelectedText = "";
            this.txtsub_t.SelectionLength = 0;
            this.txtsub_t.SelectionStart = 0;
            this.txtsub_t.ShortcutsEnabled = true;
            this.txtsub_t.Size = new System.Drawing.Size(207, 23);
            this.txtsub_t.TabIndex = 6;
            this.txtsub_t.UseSelectable = true;
            this.txtsub_t.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsub_t.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsub_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsub_t_KeyPress);
            // 
            // add_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 448);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtsub_t);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtinstructor);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnaddsubject);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ComboBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_subject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة مواد جديدة ";
            this.Load += new System.EventHandler(this.add_subject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtsubject;
        private MetroFramework.Controls.MetroButton btnaddsubject;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbLevel;
        private MetroFramework.Controls.MetroComboBox cmbSem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtinstructor;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txttotal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtsub_t;
    }
}