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
    public partial class Graduate : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Marks Grad = new BL.CLS_Marks();
        BL.CLS_stduent std = new BL.CLS_stduent();

        public Graduate()
        {
            InitializeComponent();
            this.metroGrid1.DataSource = Grad.GetAllGraduated();
        }

        private void Graduate_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            GraduateEdit edit = new GraduateEdit();
            edit.Text += " "+ this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            edit.txtstdname.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            edit.txtdeptname.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
            edit.txtnationalStd.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
            edit.txtTotalmark.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            edit.txtTotalDeg.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
            edit.txtArrange.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
            edit.txtstdname.Enabled = false;
            edit.txtdeptname.Enabled = false;
            edit.txtnationalStd.Enabled = false;
            edit.txtTotalmark.Enabled = false;
            edit.txtTotalDeg.Enabled = false;
            edit.ShowDialog();
        }

        private void txtSearchStd_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = Grad.SearchGraduteName(txtSearchStd.Text);
            this.metroGrid1.DataSource = dataTable;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالفعل حذف الطالب المحدد ؟", "حذف الطالب", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Grad.DelGraduated(int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.metroGrid1.DataSource = Grad.GetAllGraduated();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            RPT.report_allmark_for_stu lt = new RPT.report_allmark_for_stu();
            lt.SetParameterValue("@dept_id", std.GetDeptFromgraduate(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString())));
            lt.SetParameterValue("@stu_id", int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            RPT.FRM_All_mark_for_stu s = new RPT.FRM_All_mark_for_stu();
            s.crystalReportViewer1.ReportSource = lt;
           s.ShowDialog();

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
