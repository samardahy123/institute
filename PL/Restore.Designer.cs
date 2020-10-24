namespace Institute.PL
{
    partial class Restore
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
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btnbackuo = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbrowse = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtfilename = new MetroFramework.Controls.MetroTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(508, 218);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(124, 40);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "خروج";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnbackuo
            // 
            this.btnbackuo.Location = new System.Drawing.Point(332, 218);
            this.btnbackuo.Name = "btnbackuo";
            this.btnbackuo.Size = new System.Drawing.Size(146, 40);
            this.btnbackuo.TabIndex = 6;
            this.btnbackuo.Text = "استعادة النسخة الاحتياطية";
            this.btnbackuo.UseSelectable = true;
            this.btnbackuo.Click += new System.EventHandler(this.btnbackuo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbrowse);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtfilename);
            this.groupBox1.Location = new System.Drawing.Point(13, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(24, 54);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 2;
            this.btnbrowse.Text = "...";
            this.btnbrowse.UseSelectable = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(292, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(326, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "الرجاء تحديد مسار تواجد النسخة الاحتياطية";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 279);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.btnbackuo);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Restore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استعادة النسخة الاحتياطية المحفوظة";
            this.Load += new System.EventHandler(this.Restore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btnbackuo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnbrowse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtfilename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}