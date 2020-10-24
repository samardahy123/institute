namespace Institute.RPT
{
    partial class frm_all_fees_for_dept
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
            this.combodept = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnprint = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combodept
            // 
            this.combodept.FormattingEnabled = true;
            this.combodept.ItemHeight = 23;
            this.combodept.Location = new System.Drawing.Point(78, 30);
            this.combodept.Name = "combodept";
            this.combodept.Size = new System.Drawing.Size(140, 29);
            this.combodept.TabIndex = 0;
            this.combodept.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(224, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "اختر القسم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.combodept);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 149);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(993, 366);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // btnprint
            // 
            this.btnprint.ActiveControl = null;
            this.btnprint.Location = new System.Drawing.Point(325, 93);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(142, 44);
            this.btnprint.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnprint.TabIndex = 29;
            this.btnprint.Text = "طباعة ";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.TileImage = global::Institute.Properties.Resources.edit;
            this.btnprint.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnprint.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnprint.UseSelectable = true;
            this.btnprint.UseTileImage = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // frm_all_fees_for_dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 542);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_all_fees_for_dept";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جميع الاقساط للقسم المحدد";
            this.Load += new System.EventHandler(this.frm_all_fees_for_dept_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox combodept;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroTile btnprint;
    }
}