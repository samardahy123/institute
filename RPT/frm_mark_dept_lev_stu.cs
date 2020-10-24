using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute.RPT
{
    public partial class frm_mark_dept_lev_stu : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();

       
        public frm_mark_dept_lev_stu()
        {
            InitializeComponent();
            //cmbDept.DataSource = dept.all_department();
            //cmbDept.ValueMember = "dept_id";
            //cmbDept.DisplayMember = "dept_name";
            //cmbDept.BindingContext = BindingContext;


            //cmblevel.DataSource = ls.all_lev();
            //cmblevel.DisplayMember = "lev_name";
            //cmblevel.ValueMember = "lev_id";
            //cmblevel.BindingContext = BindingContext;

        }
        private void frm_mark_dept_lev_stu_Load(object sender, EventArgs e)
        {

        }

        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combosem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmblevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int val;
            //Int32.TryParse(cmblevel.SelectedValue.ToString(), out val);
            //this.cmbsem.DataSource = ls.getallsemfor_lev(val);
            //this.cmbsem.DisplayMember = "sem_name";
            //this.cmbsem.ValueMember = "sem_id";
        }

        private void cmbsem_SelectedIndexChanged(object sender, EventArgs e)
        {

            //BL.CLS_stduent std = new BL.CLS_stduent();
            //DataTable dt;
            //try
            //{
            //    int val1, val2, val3;
            //    Int32.TryParse(cmbDept.SelectedValue.ToString(), out val1);
            //    Int32.TryParse(cmblevel.SelectedValue.ToString(), out val2);
            //    Int32.TryParse(cmbsem.SelectedValue.ToString(), out val3);
            //    //  dt = std.getstudentFordept_lev_sem(val1, val2, val3);

            //    dt = std.getstudentFordept_lev_sem22(val1, val2, val3);


            //    //this.cmbstu.DisplayMember = "stu_name";
            //    //this.cmbstu.ValueMember = "stu_id";
            //    ////.DisplayMember = "stu_name";
            //    ////cmbstd.ValueMember = "stu_id";
            //    ////cmbstd.BindingContext = this.BindingContext;
            //    ////cmbstd.DataSource = std.getstudentFordept_lev_sem(val12, val22, val23);
            //    //cmbstu.BindingContext = this.BindingContext;
            //    //this.cmbstu.DataSource = dt;


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //if (cmbDept.Text == string.Empty || cmblevel.Text == string.Empty || cmbsem.Text == string.Empty || cmbstu.Text == string.Empty||cmbyeare.Text==string.Empty)
            //{
            //    MessageBox.Show("رجاءااختر القسم,الفرقة,الترم,اسم الطالب والسنة الدراسية ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}
            //RPT.report_allmark_for_dept_lev_stu lt = new RPT.report_allmark_for_dept_lev_stu();
            //lt.SetParameterValue("@dept_id", int.Parse(cmbDept.SelectedValue.ToString()));
            //lt.SetParameterValue("@lev_id", int.Parse(cmblevel.SelectedValue.ToString()));
            //lt.SetParameterValue("@sem_id", int.Parse(cmbsem.SelectedValue.ToString()));
            //lt.SetParameterValue("@stu_id", int.Parse(cmbstu.SelectedValue.ToString()));
            //lt.SetParameterValue("@year_std",cmbyeare.Text);

      

            //RPT.frm_mark_dept_lev_stu ll = new RPT.frm_mark_dept_lev_stu();
            //ll.crystalReportViewer1.ReportSource = lt;
            //ll.ShowDialog();
            //this.Close();
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
