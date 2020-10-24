namespace Institute.PL
{
    partial class Tesstimonies2
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
            this.btnprint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combodept = new MetroFramework.Controls.MetroComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtssn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combolevel = new MetroFramework.Controls.MetroComboBox();
            this.txtt2 = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(718, 513);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(97, 43);
            this.btnprint.TabIndex = 0;
            this.btnprint.Text = "طباعة اثبات القيد الموجهه";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtt2);
            this.groupBox1.Controls.Add(this.txtm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txte);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtyear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(718, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 487);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الطالب";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.txtgender);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.combodept);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtssn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.combolevel);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(52, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 264);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(17, 16);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtgender
            // 
            this.txtgender.Enabled = false;
            this.txtgender.Location = new System.Drawing.Point(18, 235);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(125, 20);
            this.txtgender.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "اسم الطالب";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "النوع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "الشعبة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "الرقم القومى";
            // 
            // combodept
            // 
            this.combodept.Enabled = false;
            this.combodept.FormattingEnabled = true;
            this.combodept.ItemHeight = 23;
            this.combodept.Location = new System.Drawing.Point(17, 97);
            this.combodept.Name = "combodept";
            this.combodept.Size = new System.Drawing.Size(125, 29);
            this.combodept.TabIndex = 6;
            this.combodept.UseSelectable = true;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(17, 52);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(125, 20);
            this.txtname.TabIndex = 5;
            // 
            // txtssn
            // 
            this.txtssn.Enabled = false;
            this.txtssn.Location = new System.Drawing.Point(17, 191);
            this.txtssn.Name = "txtssn";
            this.txtssn.Size = new System.Drawing.Size(125, 20);
            this.txtssn.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "رقم الطالب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "الفرقة";
            // 
            // combolevel
            // 
            this.combolevel.Enabled = false;
            this.combolevel.FormattingEnabled = true;
            this.combolevel.ItemHeight = 23;
            this.combolevel.Items.AddRange(new object[] {
            "الاولى",
            "التانية"});
            this.combolevel.Location = new System.Drawing.Point(17, 142);
            this.combolevel.Name = "combolevel";
            this.combolevel.Size = new System.Drawing.Size(125, 29);
            this.combolevel.TabIndex = 7;
            this.combolevel.UseSelectable = true;
            // 
            // txtt2
            // 
            this.txtt2.Location = new System.Drawing.Point(88, 29);
            this.txtt2.Name = "txtt2";
            this.txtt2.Size = new System.Drawing.Size(80, 20);
            this.txtt2.TabIndex = 31;
            this.txtt2.Text = "اثبات قيد موجهه";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(77, 109);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(125, 20);
            this.txtm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "للحصول على";
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(76, 147);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(125, 20);
            this.txte.TabIndex = 2;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(76, 72);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(125, 20);
            this.txtcode.TabIndex = 0;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            this.txtcode.Leave += new System.EventHandler(this.txtcode_Leave);
            this.txtcode.Validated += new System.EventHandler(this.txtcode_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "يتم توصية اثبات القيد الى";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "كود الطالب";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(75, 188);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(125, 20);
            this.txtyear.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "العام الدراسى";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(7, 55);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(705, 484);
            this.crystalReportViewer1.TabIndex = 11;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tesstimonies2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tesstimonies2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اثبات القيد الموجهه";
            this.Load += new System.EventHandler(this.Tesstimonies2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox combolevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtssn;
        private System.Windows.Forms.TextBox txtname;
        private MetroFramework.Controls.MetroComboBox combodept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtt2;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}