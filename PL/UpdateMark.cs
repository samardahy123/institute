using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute.PL
{
    public partial class UpdateMark : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_Subject s = new BL.CLS_Subject();

        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        BL.CLS_absance abs = new BL.CLS_absance();
        DataTable dt;
        public int ID,IdDept, IdLev, IdName, IdSub, IdSem,Deg;

        private void txtDeg3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtDeg1.Text);
                float num2 = float.Parse(txtDeg2.Text);
                float num3 = float.Parse(txtDeg3.Text);
                float sum = num1 + num2 + num3;

                txtDegTotal.Text = sum.ToString();
            }
            catch
            {

            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDeg1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtDeg1.Text);
                float num2 = float.Parse(txtDeg2.Text);
                float num3 = float.Parse(txtDeg3.Text);
                float sum = num1 + num2 + num3;

                txtDegTotal.Text = sum.ToString();
            }
            catch
            {

            }
        }

        private string Subgrade(int m, Double p)
        {
            if (p / m * 100 >= 85)
            {
                return "امتياز";
            }
            else if (p / m * 100 >= 75)
            {
                return "جيد جدا";
            }
            else if (p / m * 100 >= 65)
            {
                return "جيد";
            }
            else if (p / m * 100 >= 50)
            {
                return "مقبول";
            }
            else
            {
                return "ضعيف";
            }
            //if (m / p * 100 >= 85)
            //{
            //    return "امتياز";
            //}
            //else if (m / p * 100 >= 75)
            //{
            //    return "جيد جداً";
            //}
            //else if (m / p * 100 >= 65)
            //{
            //    return "جيد";
            //}
            //else if (m / p * 100 >= 50)
            //{
            //    return "مقبول";
            //}
            //else
            //{
            //    return "ضعيف";
            //}
        }
        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtDeg1.Text == string.Empty || txtDeg2.Text == string.Empty || txtDeg3.Text == string.Empty || txtDegTotal.Text == string.Empty)
            {
                MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int val1;
                Int32.TryParse(txtSub.Text.ToString(), out val1);
                float valm1, valm2, valm3;
                float.TryParse(txtDeg1.Text, out valm1);

                float.TryParse(txtDeg2.Text, out valm2);

                float.TryParse(txtDeg3.Text, out valm3);

                int val;
                Int32.TryParse(txtDegTotal.Text, out val);
                BL.CLS_Marks mark = new BL.CLS_Marks();

                if (val == 200)
                {
                    mark.update_mark(ID,0,0,0, float.Parse(txtDegTotal.Text),
                        IdName, IdDept, IdLev, IdSem, IdSub,
                        Subgrade(int.Parse(txtDeg.Text), int.Parse(txtDegTotal.Text)),cmbyeare.Text);

                    MessageBox.Show("تم تعديل درجة المادة بنجاح ", "تعديل درجة مادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDegTotal.Text = "";
                }

                else
                {
                    mark.update_mark(ID, valm1, valm2, valm3, float.Parse(txtDegTotal.Text),
                        IdName,IdDept,IdLev,IdSem,IdSub,
                        Subgrade(int.Parse(txtDeg.Text), float.Parse(txtDegTotal.Text)),cmbyeare.Text);

                    MessageBox.Show("تم تعديل درجة المادة بنجاح ", "تعديل درجة مادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtDeg1.Text);
                float num2 = float.Parse(txtDeg2.Text);
                float num3 = float.Parse(txtDeg3.Text);
                float sum = num1 + num2 + num3;

                txtDegTotal.Text = sum.ToString();
            }
            catch
            {

            }

        }

        public UpdateMark()
        {
            InitializeComponent();
        }

        private void UpdateMark_Load(object sender, EventArgs e)
        {

        }
    }
}
