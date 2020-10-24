namespace Institute.PL
{
    partial class DegreeCertificate
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DegreeCertificate));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtSearchStd = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.GradImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.txtSearchStd);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(672, 66);
            this.metroPanel1.TabIndex = 23;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.White;
            this.metroTile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTile1.Location = new System.Drawing.Point(32, 8);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(93, 51);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 24;
            this.metroTile1.Text = "عرض";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = global::Institute.Properties.Resources.icons8_silver_medal_40;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // txtSearchStd
            // 
            // 
            // 
            // 
            this.txtSearchStd.CustomButton.BackgroundImage = global::Institute.Properties.Resources.search;
            this.txtSearchStd.CustomButton.Image = null;
            this.txtSearchStd.CustomButton.Location = new System.Drawing.Point(320, 1);
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
            this.txtSearchStd.Location = new System.Drawing.Point(280, 15);
            this.txtSearchStd.MaxLength = 32767;
            this.txtSearchStd.Name = "txtSearchStd";
            this.txtSearchStd.PasswordChar = '\0';
            this.txtSearchStd.PromptText = "ابحث  بإسم الطالب";
            this.txtSearchStd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchStd.SelectedText = "";
            this.txtSearchStd.SelectionLength = 0;
            this.txtSearchStd.SelectionStart = 0;
            this.txtSearchStd.ShortcutsEnabled = true;
            this.txtSearchStd.Size = new System.Drawing.Size(356, 37);
            this.txtSearchStd.TabIndex = 23;
            this.txtSearchStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchStd.UseSelectable = true;
            this.txtSearchStd.WaterMark = "ابحث  بإسم الطالب";
            this.txtSearchStd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchStd.WaterMarkFont = new System.Drawing.Font("Simplified Arabic Fixed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStd.TextChanged += new System.EventHandler(this.txtSearchStd_TextChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.GradImg);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 132);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(672, 298);
            this.metroPanel2.TabIndex = 25;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // GradImg
            // 
            this.GradImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradImg.Image = global::Institute.Properties.Resources.diploma;
            this.GradImg.InitialImage = global::Institute.Properties.Resources.contract;
            this.GradImg.Location = new System.Drawing.Point(0, 0);
            this.GradImg.Name = "GradImg";
            this.GradImg.Size = new System.Drawing.Size(672, 298);
            this.GradImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GradImg.TabIndex = 2;
            this.GradImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 45);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // DegreeCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DegreeCertificate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "        شهاده تخرج";
            this.Load += new System.EventHandler(this.DegreeCertificate_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GradImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtSearchStd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox GradImg;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}