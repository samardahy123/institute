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
    public partial class FRM_rpt_abs_morethan20 : MetroFramework.Forms.MetroForm
    {

        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_absance abs = new BL.CLS_absance();
        BL.CLS_stduent std = new BL.CLS_stduent();


        DataTable dt;

        public FRM_rpt_abs_morethan20()
        {
            InitializeComponent();
        dt = d.all_department();
        cmbDept.DataSource = dt;
        cmbDept.DisplayMember = "dept_name";
        cmbDept.ValueMember = "dept_id";

        dt = ls.all_lev();
        cmbLevel.DataSource = dt;
        cmbLevel.DisplayMember = "lev_name";
        cmbLevel.ValueMember = "lev_id";
    }

        private void FRM_rpt_abs_morethan20_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmbLevel.SelectedValue.ToString(), out val);
            this.cmbSem.DataSource = ls.getallsemfor_lev(val);
            this.cmbSem.DisplayMember = "sem_name";
            this.cmbSem.ValueMember = "sem_id";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty||cmbyeare.Text==string.Empty)
            {
                MessageBox.Show("رجاءا اختر القسم والفرقة والرتم والسنة الدراسية ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            RPT.rpt_absance__abs_morethan20 lt = new RPT.rpt_absance__abs_morethan20();
            lt.SetParameterValue("@dept_id", int.Parse(cmbDept.SelectedValue.ToString()));
            lt.SetParameterValue("@lev_id", int.Parse(cmbLevel.SelectedValue.ToString()));
            lt.SetParameterValue("@sem_id", int.Parse(cmbSem.SelectedValue.ToString()));
            lt.SetParameterValue("@year_std",cmbyeare.Text);


            RPT.FRM_rpt_abs_morethan20 abs = new RPT.FRM_rpt_abs_morethan20();
            abs.crystalReportViewer1.ReportSource = lt;
            abs.ShowDialog();
            this.Close();

        }
    }
}
