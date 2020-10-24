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
    public partial class Testimonies1 : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem lev = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
       
        DataTable dt;
        public Testimonies1()
        {
            InitializeComponent();
            //dt = dept.all_department();
            //combodept.DataSource = dt;
            //combodept.DisplayMember = "dept_name";
            //combodept.ValueMember = "dept_id";

            //dt = lev.all_lev();
            //combolev.DataSource = dt;
            //combolev.DisplayMember = "lev_name";
            //combolev.ValueMember = "lev_id";

           

        }

        private void Testimonies1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void txtdate_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtssn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) {
            //    e.Handled = true;
            //}
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter) {
            //    combodept.Focus();
            //}
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void combodept_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    combolev.Focus();
            //}
        }

        private void combolevel_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    txtssn.Focus();
            //}
        }

        private void txtssn_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    txtyear.Focus();
            //}
        }

        private void txtyear_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    btnprint.Focus();
            //}
        }

        private void btnprint_Click(object sender, EventArgs e)
        {



            if (txtcode.Text == string.Empty || txtm.Text == string.Empty || txtyear.Text == string.Empty)
            {

                MessageBox.Show("برجاء ادخال كود الطالب ,المؤهل والسنة الدراسية", "اثبات قيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }

            else
            {
                if (txtg.Text == "أنثى")
                {
                    BL.CLS_Testimonies t1 = new BL.CLS_Testimonies();
                    t1.add_Testimonies(txtt1.Text, int.Parse(txtid.Text), txtname.Text);
                    MessageBox.Show("تم الاضافة  بنجاح والان تتم عملية طباعة اثبات القيد", "اضافةاثبات قيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Testimonies1 tt = new Testimonies1();

                    RPT.rpt_testimoniesF1_ t = new RPT.rpt_testimoniesF1_();
                    TextObject text1 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtmm"];
                    text1.Text = txtm.Text;

                    TextObject text2 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txty"];
                    text2.Text = txtyear.Text;

                    t.SetParameterValue("@code", txtcode.Text);
                    PL.Testimonies1 ll = new PL.Testimonies1();
                    ll.crystalReportViewer1.ReportSource = t;
                    ll.ShowDialog();
                    txtcode.Focus();
                }
                 else if (txtg.Text == "ذكر")
                {
                    BL.CLS_Testimonies t1 = new BL.CLS_Testimonies();
                    t1.add_Testimonies(txtt1.Text, int.Parse(txtid.Text), txtname.Text);
                    MessageBox.Show("تم الاضافة  بنجاح والان تتم عملية طباعة اثبات القيد", "اضافةاثبات قيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Testimonies1 tt = new Testimonies1();

                    RPT.rpt_testimoniesM1 t = new RPT.rpt_testimoniesM1();
                    TextObject text1 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtmm"];
                    text1.Text = txtm.Text;

                    TextObject text2 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txty"];
                    text2.Text = txtyear.Text;

                    t.SetParameterValue("@code", txtcode.Text);
                    PL.Testimonies1 ll = new PL.Testimonies1();
                    ll.crystalReportViewer1.ReportSource = t;
                    ll.ShowDialog();
                    txtcode.Focus();
                }




            }





        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  e.Graphics.DrawString(panel1,new Font("Arial",12,FontStyle.Regular), Brushes.Black, 90, 100);
            //float margin = 40;
            //Font f=

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {





        }

        private void txtcode_Leave(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
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

                MessageBox.Show("برجاء ادخال كود الطالب بشكل صحيح لجلب جميع البيانات الخاصة به", "اثبات قيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            txtid.Text = dt.Rows[0][0].ToString();
            //txtyear.Text = dt.Rows[0][2].ToString();
            txtname.Text = dt.Rows[0][4].ToString();
            combodept.Text = dt.Rows[0][36].ToString();
            combolev.Text = dt.Rows[0][37].ToString();
            
            txtssn.Text = dt.Rows[0][13].ToString();
            txtg.Text = dt.Rows[0][11].ToString();






        }

        private void combolev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtssn_Validated(object sender, EventArgs e)
        {

        }
    }
}
