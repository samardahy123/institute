namespace Institute.RPT
{
    partial class frm_all_account
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpt_get_account1 = new Institute.RPT.rpt_get_account();
            this.btnprint = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rpt_get_account1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1095, 370);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // btnprint
            // 
            this.btnprint.ActiveControl = null;
            this.btnprint.Location = new System.Drawing.Point(935, 10);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(123, 44);
            this.btnprint.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnprint.TabIndex = 30;
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
            // frm_all_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.crystalReportViewer1);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frm_all_account";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جميع الاقساط للطالب";
            this.Load += new System.EventHandler(this.frm_all_account_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
       // private PL.get_all_accounts get_all_accounts1;
        private rpt_get_account rpt_get_account1;
        private MetroFramework.Controls.MetroTile btnprint;
        // private PL.get_all_accounts get_all_accounts2;
    }
}