namespace Institute.PL
{
    partial class add_exams_table
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
            this.btncancel = new System.Windows.Forms.Button();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtpT2 = new System.Windows.Forms.DateTimePicker();
            this.dtpT1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.comboclass = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.combosubject = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboday = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.combodepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.combolevel = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combosem = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(527, 408);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 34);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(316, 32);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(137, 20);
            this.txtyear.TabIndex = 0;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(504, 32);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 63;
            this.metroLabel9.Text = "السنة الدراسية";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(215, 290);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 62;
            this.metroLabel7.Text = "توقيت النهاية";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(482, 289);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 61;
            this.metroLabel6.Text = "توقيت البداية:";
            // 
            // dtpT2
            // 
            this.dtpT2.CustomFormat = "";
            this.dtpT2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpT2.Location = new System.Drawing.Point(43, 288);
            this.dtpT2.Name = "dtpT2";
            this.dtpT2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpT2.Size = new System.Drawing.Size(136, 20);
            this.dtpT2.TabIndex = 9;
            // 
            // dtpT1
            // 
            this.dtpT1.CustomFormat = "";
            this.dtpT1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpT1.Location = new System.Drawing.Point(316, 289);
            this.dtpT1.Name = "dtpT1";
            this.dtpT1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpT1.Size = new System.Drawing.Size(137, 20);
            this.dtpT1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(215, 223);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(79, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "تاريخ الامتحان";
            // 
            // comboclass
            // 
            this.comboclass.FormattingEnabled = true;
            this.comboclass.ItemHeight = 23;
            this.comboclass.Location = new System.Drawing.Point(316, 214);
            this.comboclass.Name = "comboclass";
            this.comboclass.Size = new System.Drawing.Size(140, 29);
            this.comboclass.TabIndex = 6;
            this.comboclass.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(502, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "اختر القاعة";
            // 
            // combosubject
            // 
            this.combosubject.FormattingEnabled = true;
            this.combosubject.ItemHeight = 23;
            this.combosubject.Location = new System.Drawing.Point(43, 158);
            this.combosubject.Name = "combosubject";
            this.combosubject.Size = new System.Drawing.Size(137, 29);
            this.combosubject.TabIndex = 5;
            this.combosubject.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(229, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "اختر المادة";
            // 
            // comboday
            // 
            this.comboday.FormattingEnabled = true;
            this.comboday.ItemHeight = 23;
            this.comboday.Items.AddRange(new object[] {
            "السبت",
            "الاحد",
            "الاثنين",
            "الثلاثاء",
            "الاربعاء ",
            "الخميس",
            "الجمعة"});
            this.comboday.Location = new System.Drawing.Point(43, 32);
            this.comboday.Name = "comboday";
            this.comboday.Size = new System.Drawing.Size(137, 29);
            this.comboday.TabIndex = 1;
            this.comboday.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(229, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "اختر اليوم";
            // 
            // combodepartment
            // 
            this.combodepartment.FormattingEnabled = true;
            this.combodepartment.ItemHeight = 23;
            this.combodepartment.Location = new System.Drawing.Point(316, 90);
            this.combodepartment.Name = "combodepartment";
            this.combodepartment.Size = new System.Drawing.Size(169, 29);
            this.combodepartment.TabIndex = 2;
            this.combodepartment.UseSelectable = true;
            this.combodepartment.SelectedIndexChanged += new System.EventHandler(this.combodepartment_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(229, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "اختر الفرقة";
            // 
            // combolevel
            // 
            this.combolevel.FormattingEnabled = true;
            this.combolevel.ItemHeight = 23;
            this.combolevel.Items.AddRange(new object[] {
            "الاولى",
            "التانية"});
            this.combolevel.Location = new System.Drawing.Point(43, 90);
            this.combolevel.Name = "combolevel";
            this.combolevel.Size = new System.Drawing.Size(137, 29);
            this.combolevel.TabIndex = 3;
            this.combolevel.UseSelectable = true;
            this.combolevel.SelectedIndexChanged += new System.EventHandler(this.combolevel_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(502, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "اختر القسم";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(420, 410);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 32);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combosem);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.txtyear);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.dtpT2);
            this.groupBox1.Controls.Add(this.dtpT1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.comboclass);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.combosubject);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.comboday);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.combodepartment);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.combolevel);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(34, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 353);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة جدول";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combosem
            // 
            this.combosem.FormattingEnabled = true;
            this.combosem.ItemHeight = 23;
            this.combosem.Location = new System.Drawing.Point(316, 158);
            this.combosem.Name = "combosem";
            this.combosem.Size = new System.Drawing.Size(140, 29);
            this.combosem.TabIndex = 4;
            this.combosem.UseSelectable = true;
            this.combosem.SelectedIndexChanged += new System.EventHandler(this.combosem_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(502, 158);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(31, 19);
            this.metroLabel10.TabIndex = 65;
            this.metroLabel10.Text = "الترم";
            // 
            // add_exams_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Name = "add_exams_table";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة جدول امتحانات";
            this.Load += new System.EventHandler(this.add_exams_table_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtyear;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker dtpT2;
        private System.Windows.Forms.DateTimePicker dtpT1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox comboclass;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox combosubject;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comboday;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox combodepartment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox combolevel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox combosem;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}