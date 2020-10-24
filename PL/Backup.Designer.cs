namespace Institute.PL
{
    partial class Backup
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
            this.txtfilename = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnbrowse = new MetroFramework.Controls.MetroButton();
            this.btnbackuo = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbrowse);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtfilename);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtfilename
            // 
            // 
            // 
            // 
            this.txtfilename.CustomButton.Image = null;
            this.txtfilename.CustomButton.Location = new System.Drawing.Point(433, 1);
            this.txtfilename.CustomButton.Name = "";
            this.txtfilename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfilename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfilename.CustomButton.TabIndex = 1;
            this.txtfilename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfilename.CustomButton.UseSelectable = true;
            this.txtfilename.CustomButton.Visible = false;
            this.txtfilename.Lines = new string[0];
            this.txtfilename.Location = new System.Drawing.Point(105, 54);
            this.txtfilename.MaxLength = 32767;
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.PasswordChar = '\0';
            this.txtfilename.ReadOnly = true;
            this.txtfilename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfilename.SelectedText = "";
            this.txtfilename.SelectionLength = 0;
            this.txtfilename.SelectionStart = 0;
            this.txtfilename.ShortcutsEnabled = true;
            this.txtfilename.Size = new System.Drawing.Size(455, 23);
            this.txtfilename.TabIndex = 0;
            this.txtfilename.UseSelectable = true;
            this.txtfilename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfilename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(292, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(321, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "الرجاء تحديد مسار حفظ النسخة الاحتياطية";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(24, 54);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 2;
            this.btnbrowse.Text = "...";
            this.btnbrowse.UseSelectable = true;
            this.btnbrowse.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnbackuo
            // 
            this.btnbackuo.Location = new System.Drawing.Point(329, 196);
            this.btnbackuo.Name = "btnbackuo";
            this.btnbackuo.Size = new System.Drawing.Size(124, 36);
            this.btnbackuo.TabIndex = 3;
            this.btnbackuo.Text = "انشاء النسخة الاحتياطية";
            this.btnbackuo.UseSelectable = true;
            this.btnbackuo.Click += new System.EventHandler(this.btnbackuo_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(483, 196);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(124, 36);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "خروج";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 255);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.btnbackuo);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Backup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انشاء نسخة احتياطية";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtfilename;
        private MetroFramework.Controls.MetroButton btnbrowse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnbackuo;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}