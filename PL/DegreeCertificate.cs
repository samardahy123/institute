using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute.PL
{
    public partial class DegreeCertificate : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Marks Grad = new BL.CLS_Marks();
        public DegreeCertificate()
        {
            InitializeComponent();
        }

        private void DegreeCertificate_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchStd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] img = (byte[])Grad.GetGraduatedImg(txtSearchStd.Text).Rows[0][0];
                MemoryStream memory = new MemoryStream(img);
                GradImg.Image = Image.FromStream(memory);
            }
            catch
            {
                MessageBox.Show("لا توجد شهادات تخرج لهذا الطالب");
            }
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = (byte[])Grad.GetGraduatedImg(txtSearchStd.Text).Rows[0][0];
                MemoryStream memory = new MemoryStream(img);
                GradImg.Image = Image.FromStream(memory);
            }
            catch
            {
                MessageBox.Show("لا توجد شهادات تخرج لهذا الطالب");
            }
        }
    }
}
