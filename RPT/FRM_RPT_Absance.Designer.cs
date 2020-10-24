namespace Institute.RPT
{
    partial class FRM_RPT_Absance
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
            this.txtSearchStd = new MetroFramework.Controls.MetroTextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpt_absance1 = new Institute.RPT.rpt_absance();
            this.SuspendLayout();
            // 
            // txtSearchStd
            // 
            // 
            // 
            // 
            this.txtSearchStd.CustomButton.BackgroundImage = global::Institute.Properties.Resources.search;
            this.txtSearchStd.CustomButton.Image = null;
            this.txtSearchStd.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtSearchStd.CustomButton.Name = "";
            this.txtSearchStd.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtSearchStd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchStd.CustomButton.TabIndex = 1;
            this.txtSearchStd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchStd.CustomButton.UseSelectable = true;
            this.txtSearchStd.CustomButton.Visible = false;
            this.txtSearchStd.DisplayIcon = true;
            this.txtSearchStd.ForeColor = System.Drawing.Color.White;
            this.txtSearchStd.Icon = global::Institute.Properties.Resources.search;
            this.txtSearchStd.IconRight = true;
            this.txtSearchStd.Lines = new string[0];
            this.txtSearchStd.Location = new System.Drawing.Point(434, 8);
            this.txtSearchStd.MaxLength = 32767;
            this.txtSearchStd.Name = "txtSearchStd";
            this.txtSearchStd.PasswordChar = '\0';
            this.txtSearchStd.PromptText = "ابحث  بإسم الطالب";
            this.txtSearchStd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchStd.SelectedText = "";
            this.txtSearchStd.SelectionLength = 0;
            this.txtSearchStd.SelectionStart = 0;
            this.txtSearchStd.ShortcutsEnabled = true;
            this.txtSearchStd.Size = new System.Drawing.Size(343, 37);
            this.txtSearchStd.TabIndex = 24;
            this.txtSearchStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchStd.UseSelectable = true;
            this.txtSearchStd.WaterMark = "ابحث  بإسم الطالب";
            this.txtSearchStd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchStd.WaterMarkFont = new System.Drawing.Font("Simplified Arabic Fixed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStd.TextChanged += new System.EventHandler(this.txtSearchStd_TextChanged);
            this.txtSearchStd.Click += new System.EventHandler(this.txtSearchStd_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rpt_absance1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(823, 424);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // rpt_absance1
            // 
            this.rpt_absance1.InitReport += new System.EventHandler(this.rpt_absance1_InitReport);
            // 
            // FRM_RPT_Absance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 504);
            this.Controls.Add(this.txtSearchStd);
            this.Controls.Add(this.crystalReportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RPT_Absance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقارير الغياب";
            this.Load += new System.EventHandler(this.FRM_RPT_Absance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rpt_absance rpt_absance1;
        private MetroFramework.Controls.MetroTextBox txtSearchStd;
    }
}