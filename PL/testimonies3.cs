using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Institute.BL;

namespace Institute.PL
{
    public partial class testimonies3 : MetroFramework.Forms.MetroForm

    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem lev = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        DataTable dt;
        public testimonies3()
        {
            InitializeComponent();
        }

        private void testimonies3_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtid_Validated(object sender, EventArgs e)
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

           txtid.Text= dt.Rows[0][0].ToString();
            //txtyear.Text = dt.Rows[0][2].ToString();
            txtname.Text = dt.Rows[0][4].ToString();
            txtdepartment.Text = dt.Rows[0][36].ToString();
            txtlevel.Text = dt.Rows[0][37].ToString();

            //   pictureBox1.Image = pictureBox1.Image = Image.FromStream(std.GetImgStd(int.Parse(txtid.Text)));

            byte[] img = (byte[])dt.Rows[0][35];
            MemoryStream memory = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(memory);


        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == string.Empty ||txtacode.Text==string.Empty)
            {

                MessageBox.Show("برجاء ادخال كود الطالب,رقم ايصال سداد الطالب ", "تغيير النظام الدراسى", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }

            else
            {

                BL.CLS_Testimonies t1 = new BL.CLS_Testimonies();
                t1.add_Testimonies(txtt1.Text, int.Parse(txtid.Text), txtname.Text);
                MessageBox.Show("تم الاضافة  بنجاح والان تتم عملية طباعة ورقة تغيير النظام الدراسى ", "تغيير النظام الدراسى", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

                RPT.rpt_testimonies3 t = new RPT.rpt_testimonies3();
                
                TextObject text1 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtccode"];
                text1.Text = txtacode.Text;

                TextObject text2 = (TextObject)t.ReportDefinition.Sections["Section3"].ReportObjects["txtsem"];
                text2.Text = combotype.Text;
                t.SetParameterValue("@code", txtcode.Text);
                PL.testimonies3 ll = new PL.testimonies3();
                ll.crystalReportViewer1.ReportSource = t;
                ll.ShowDialog();



                





            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtlevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLS_Account ac = new CLS_Account();
            string acc1 = ac.get_code1from_account(txtcode.Text);
            string acc2 = ac.get_code2from_account(txtcode.Text);


            if (acc1 ==null||acc2==null) {
                MessageBox.Show("الرجاء سداد ايصال التحويل");

                return;
            }
            
            
                if (combotype.Text == "ترم اول" )
                {
                    txtacode.Text = acc1;

               
                }
                else if (combotype.Text == "ترم ثانى")
                {
                    txtacode.Text = acc2;

                }
                else // (combotype.Text == "عام كامل")
                {
                    txtacode.Text = acc1;

                }

           


        }

        private void txtacode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

