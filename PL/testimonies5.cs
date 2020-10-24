using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Institute.PL
{
    public partial class testimonies5 : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem lev = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        DataTable dt;
        public testimonies5()
        {
            InitializeComponent();
        }

        private void testimonies5_Load(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == string.Empty ||txtm.Text==string.Empty||txtyear.Text==string.Empty)
            {

                MessageBox.Show("برجاء ادخال كود الطالب ,شهادة الحصول,العام الدراسى  ", "تاجيل الاختباات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }

            else
            {
                BL.CLS_Testimonies t1 = new BL.CLS_Testimonies();
                t1.add_Testimonies(txtt1.Text, int.Parse(txtid.Text), txtname.Text);
                MessageBox.Show("تم الاضافة  بنجاح والان تتم عملية طباعة مستند تاجيل الاختبارات", "تاجيل الاختبارات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Testimonies1 tt = new Testimonies1();
                RPT.rpt_testimonies5 t = new RPT.rpt_testimonies5();
                TextObject text1 = (TextObject)t.ReportDefinition.Sections["Section2"].ReportObjects["txtmm"];
                text1.Text = txtm.Text;

                TextObject text2 = (TextObject)t.ReportDefinition.Sections["Section2"].ReportObjects["txty"];
                text2.Text = txtyear.Text;

               


                t.SetParameterValue("@code", txtcode.Text);
               


                PL.testimonies5 ll = new PL.testimonies5();
                ll.crystalReportViewer1.ReportSource = t;
                ll.ShowDialog();
                txtcode.Focus();


            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcode_Validated(object sender, EventArgs e)
        {
            BL.CLS_Testimonies time1 = new BL.CLS_Testimonies();
            DataTable dt = new DataTable();
            dt = time1.GetAllExam2(txtcode.Text);
            dt = std.VerifiedStd_code(txtcode.Text);

            if (dt.Rows.Count <= 0)
            {

                MessageBox.Show("برجاء ادخال كود الطالب بشكل صحيح لجلب جميع البيانات الخاصة به", "تاجيل الاختبارات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            txtid.Text = dt.Rows[0][0].ToString();
            //txtyear.Text = dt.Rows[0][2].ToString();
            txtname.Text = dt.Rows[0][4].ToString();
            combodept.Text = dt.Rows[0][36].ToString();
            combolev.Text = dt.Rows[0][37].ToString();
            txtsem.Text = dt.Rows[0][38].ToString();
            txtssn.Text = dt.Rows[0][13].ToString();


        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
