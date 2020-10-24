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
    public partial class GraduateEdit : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Marks Grad = new BL.CLS_Marks();
        public GraduateEdit()
        {
            InitializeComponent();
        }

        private void GraduateEdit_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "ملفات الصور|*.JPG; *.PNG; *.GIF; *.BMP";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                GradImg.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();

            if (GradImg.Image == null)
                MessageBox.Show("تأكد من إدخال صوره الشهاده");

            else if (txtArrange.Text == "")
                MessageBox.Show("تأكد من ترتيب الطالب ");

            else if (GradImg.Image != null || txtArrange.Text != "")
            {
                GradImg.Image.Save(stream, GradImg.Image.RawFormat);
                byte[] img = stream.ToArray();
                
                Grad.UpdateGraduated(txtnationalStd.Text, img, txtTotalDeg.Text, int.Parse(txtArrange.Text));
                
                MessageBox.Show("تم تعديل الخريج بنجاح ", "تعديل بيانات الخريج", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
