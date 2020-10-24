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
    public partial class Tesstimonies2 : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem lev = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        DataTable dt;

        public Tesstimonies2()
        {
            InitializeComponent();

            dt = dept.all_department();
            combodept.DataSource = dt;
            combodept.DisplayMember = "dept_name";
            combodept.ValueMember = "dept_id";

            dt = lev.all_lev();
           combolevel.DataSource = dt;
            combolevel.DisplayMember = "lev_name";
            combolevel.ValueMember = "lev_id";
        }

        private void Tesstimonies2_Load(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {





            if (txtcode.Text == string.Empty || txtm.Text == string.Empty || txtyear.Text == string.Empty||txte.Text==string.Empty)
            {

                MessageBox.Show("برجاء ادخال كود الطالب , المكان الموصى به,المؤهل والسنة الدراسية ", "اثبات قيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }

            else
            {
                if (txtgender.Text == "أنثى")
                {
                    BL.CLS_Testimonies t1 = new BL.CLS_Testimonies();
                    t1.add_Testimonies(txtt2.Text, int.Parse(txtid.Text), txtname.Text);
                    MessageBox.Show("تم الاضافة  بنجاح والان تتم عملية طباعة اثبات القيد الموجهه", "اثبات قيد موجهه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Testimonies1 tt = new Testimonies1();

                    RPT.rpt_testimoniesF2 t = new RPT.rpt_testimoniesF2();
                    TextObject text1 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtmm"];
                    text1.Text = txtm.Text;

                    TextObject text2 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txty"];
                    text2.Text = txtyear.Text;
                    TextObject text3 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtee"];
                    text3.Text = txte.Text;

                    t.SetParameterValue("@code", txtcode.Text);
                    PL.Tesstimonies2 ll = new PL.Tesstimonies2();
                    ll.crystalReportViewer1.ReportSource = t;
                    ll.ShowDialog();
                    txtcode.Focus();
                }
                else if (txtgender.Text == "ذكر")
                {
                    BL.CLS_Testimonies t1 = new BL.CLS_Testimonies();
                    t1.add_Testimonies(txtt2.Text, int.Parse(txtid.Text), txtname.Text);
                    MessageBox.Show("تم الاضافة  بنجاح والان تتم عملية طباعة اثبات القيد الموجهه", "اثبات القيد الموجهه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //      Testimonies1 tt = new Testimonies1();

                    RPT.rpt_testimoniesM2 t = new RPT.rpt_testimoniesM2();
                    TextObject text1 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtmm"];
                    text1.Text = txtm.Text;

                    TextObject text2 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txty"];
                    text2.Text = txtyear.Text;

                    TextObject text3 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtee"];
                    text3.Text = txte.Text;

                    t.SetParameterValue("@code", txtcode.Text);
                    PL.Tesstimonies2 ll = new PL.Tesstimonies2();
                    ll.crystalReportViewer1.ReportSource = t;
                    ll.ShowDialog();
                    txtcode.Focus();
                }



            }
        }

        private void txtcode_Leave(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcode_Validated(object sender, EventArgs e)
        {
            //BL.CLS_Testimonies time1 = new BL.CLS_Testimonies();
            //DataTable dt = new DataTable();
            //dt = time1.getall_stu_info_bycode(txtcode.Text);
            //dt = std.VerifiedStd_code(txtcode.Text);

            //if (dt.Rows.Count <= 0)
            //{

            //    MessageBox.Show("برجاء ادخال كود الطالب بشكل صحيح لجلب جميع البيانات الخاصة به", "اثبات قيد موجهه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}

            

            //txtid.Text = dt.Rows[0][0].ToString();
            ////txtyear.Text = dt.Rows[0][2].ToString();
            //txtname.Text = dt.Rows[0][4].ToString();
            //combodept.Text = dt.Rows[0][36].ToString();
            //combolevel.Text = dt.Rows[0][37].ToString();
            
            //txtssn.Text = dt.Rows[0][13].ToString();
            //txtgender.Text = dt.Rows[0][11].ToString();



            BL.CLS_Testimonies time2 = new BL.CLS_Testimonies();
            DataTable dt = new DataTable();
            dt = time2.getall_stu_info_bycode(txtcode.Text);
            dt = std.VerifiedStd_code(txtcode.Text);

            if (dt.Rows.Count <= 0)
            {

                MessageBox.Show("برجاء ادخال كود الطالب بشكل صحيح لجلب جميع البيانات الخاصة به", "اثبات قيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            txtid.Text = dt.Rows[0][0].ToString();
            //txtyear.Text = dt.Rows[0][2].ToString();
            txtname.Text = dt.Rows[0][4].ToString();
            combodept.Text = dt.Rows[0][36].ToString();
            combolevel.Text = dt.Rows[0][37].ToString();

            txtssn.Text = dt.Rows[0][13].ToString();
           txtgender.Text = dt.Rows[0][11].ToString();


        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
