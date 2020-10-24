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
    public partial class FRM_absance_for_stu : MetroFramework.Forms.MetroForm
    {
        
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        public FRM_absance_for_stu()
        {
            InitializeComponent();
            


            
        }

        private void FRM_absance_for_stu_Load(object sender, EventArgs e)
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
            //    dt = std.getstudentFordept_lev_sem(val1, val2, val3);


            //    this.cmbstu.DisplayMember = "stu_name";
            //    this.cmbstu.ValueMember = "stu_id";
            //    cmbstu.BindingContext = this.BindingContext;
            //    this.cmbstu.DataSource = dt;


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //if (cmbDept.Text == string.Empty || cmblevel.Text == string.Empty || cmbsem.Text == string.Empty || cmbstu.Text == string.Empty) {
            //    MessageBox.Show("رجاءااختر القسم,الفرقة,الترم,اسم الطالب ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}
            //RPT.rpt_absance_for_stu lt = new RPT.rpt_absance_for_stu();
            //lt.SetParameterValue("@dept_id", int.Parse(cmbDept.SelectedValue.ToString()));
            //lt.SetParameterValue("@lev_id", int.Parse(cmblevel.SelectedValue.ToString()));
            //lt.SetParameterValue("@sem_id", int.Parse(cmbsem.SelectedValue.ToString()));
            //lt.SetParameterValue("@stu_id", int.Parse(cmbstu.SelectedValue.ToString()));
            //lt.SetParameterValue("@year_std",cmbyeare.Text);

            //RPT.FRM_absance_for_stu ll = new RPT.FRM_absance_for_stu();
            //ll.crystalReportViewer1.ReportSource = lt;
            //ll.ShowDialog();
            //this.Close();
        }

        private void cmbstu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
