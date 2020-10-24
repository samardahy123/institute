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
    public partial class Testimonies4 : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem lev = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        DataTable dt;

        public Testimonies4()
        {
            InitializeComponent();
        }

        private void Testimonies4_Load(object sender, EventArgs e)
        {

        }

        private void txtcode_Validated(object sender, EventArgs e)
        {
            BL.CLS_Testimonies time1 = new BL.CLS_Testimonies();
            DataTable dt = new DataTable();
            dt = time1.getall_stu_info_bycode(txtcode.Text);
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

            txtssn.Text = dt.Rows[0][13].ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == string.Empty)
            {

                MessageBox.Show("برجاء ادخال كود الطالب  ", "تاجيل الاختباات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }

            else
            {
                BL.CLS_Testimonies t1 = new BL.CLS_Testimonies();
                t1.add_Testimonies(txtt1.Text, int.Parse(txtid.Text), txtname.Text);
                MessageBox.Show("تم الاضافة  بنجاح والان تتم عملية طباعة مستند تاجيل الاختبارات", "تاجيل الاختبارات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Testimonies1 tt = new Testimonies1();

                RPT.rpt_testimonies4 t = new RPT.rpt_testimonies4();


                TextObject text3 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtcc"];
                text3.Text = txtacode.Text;
                TextObject text2 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtsem"];
                text2.Text = cmbsem.Text;
                t.SetParameterValue("@code", txtcode.Text);
                PL.Testimonies4 ll = new PL.Testimonies4();
                ll.crystalReportViewer1.ReportSource = t;
                ll.ShowDialog();
                txtcode.Focus();


            }
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BL.CLS_Account ac = new BL.CLS_Account();
            string acc1 = ac.get_code3from_account(txtcode.Text);
            string acc2 = ac.get_code4from_account(txtcode.Text);

            String s = cmbsem.Text;



            if (s == "الاول")
            {
                txtacode.Text = acc1;


            }
            else  
            {
                txtacode.Text = acc2;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
