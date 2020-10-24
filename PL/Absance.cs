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
    public partial class Absance : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_absance abs = new BL.CLS_absance();
        BL.CLS_stduent std = new BL.CLS_stduent();

        DataTable dt;

        public Absance()
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

        private void Absance_Load(object sender, EventArgs e)
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
        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty || cmbyeare.Text == string.Empty)
            {
                MessageBox.Show("رجاءااختر القسم,الفرقة,الترم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            try
            {
                this.metroGrid2.DataSource = abs.Get_Absance(
                    int.Parse(cmbDept.SelectedValue.ToString())
                    , int.Parse(cmbLevel.SelectedValue.ToString())
                    , int.Parse(cmbSem.SelectedValue.ToString())
                    , cmbyeare.Text);

                string remove_duplicated_cell1 = metroGrid2.Rows[0].Cells[0].Value.ToString();

                for (int i = 1; i < metroGrid2.Rows.Count; i++)
                {
                    if (metroGrid2.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell1)
                    {
                        metroGrid2.Rows[i].Cells[0].Value = string.Empty;


                    }
                    else
                    {
                        remove_duplicated_cell1 = metroGrid2.Rows[i].Cells[0].Value.ToString();
                    }
                }


            }
            catch
            {
                MessageBox.Show("لا يوجد غياب لهذا القسم  الرجاء اختر القسم بشكل صحيح", "عرض الغياب", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }

        private void metroGrid2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty)
            {
                MessageBox.Show("رجاءااختر القسم,الفرقة,الترم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            RPT.rpt_absance lt = new RPT.rpt_absance();
            lt.SetParameterValue("@dept_id", int.Parse(cmbDept.SelectedValue.ToString()));
            lt.SetParameterValue("@lev_id", int.Parse(cmbLevel.SelectedValue.ToString()));
            lt.SetParameterValue("@sem_id", int.Parse(cmbSem.SelectedValue.ToString()));
            lt.SetParameterValue("@year_std", cmbyeare.Text);

            RPT.FRM_RPT_Absance abs = new RPT.FRM_RPT_Absance();



            abs.crystalReportViewer1.ReportSource = lt;
            abs.ShowDialog();

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_abasnce abs = new add_abasnce();
            abs.ShowDialog();
            //  this.metroGrid2.DataSource = abs.Get;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            UpdateAbs a = new UpdateAbs();
            a.Text = "تعديل الغياب للطالب:" + this.metroGrid2.CurrentRow.Cells[0].Value.ToString();

            a.ID = int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString());
            a.IdDept = abs.GetDeptFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString()));
            a.IdLev = abs.GetLevFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString()));
            a.IdName = abs.GetStdFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString()));
            a.IdSem = abs.GetSemFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString()));
            a.IdSub = abs.GetSubjectFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString()));
            a.txtDept.Text = this.metroGrid2.CurrentRow.Cells[2].Value.ToString();
            a.txtDept.Enabled = false;
            a.txtLev.Text = this.metroGrid2.CurrentRow.Cells[3].Value.ToString();
            a.txtLev.Enabled = false;
            a.txtSem.Text = this.metroGrid2.CurrentRow.Cells[4].Value.ToString();
            a.txtSem.Enabled = false;
            a.txtSub.Text = this.metroGrid2.CurrentRow.Cells[5].Value.ToString();
            a.txtSub.Enabled = false;
            a.txtStd.Text = abs.GetStdNameFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString()));
            a.txtStd.Enabled = false;
            a.txtlec.Text = this.metroGrid2.CurrentRow.Cells[18].Value.ToString();
            //a.txtlec.Enabled = false;
            a.numlec1.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[6].Value.ToString());
            a.numlec2.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[7].Value.ToString());
            a.numlec3.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[8].Value.ToString());
            a.numlec4.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[9].Value.ToString());
            a.numlec5.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[10].Value.ToString());
            a.numlec6.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[11].Value.ToString());
            a.numlec7.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[12].Value.ToString());
            a.numlec8.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[13].Value.ToString());
            a.numlec9.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[14].Value.ToString());
            a.numlec10.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[15].Value.ToString());
            a.numlec11.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[16].Value.ToString());
            a.numlec12.Value = int.Parse(this.metroGrid2.CurrentRow.Cells[17].Value.ToString());
            a.cmbyeare.Text = this.metroGrid2.CurrentRow.Cells[25].Value.ToString();
            a.ShowDialog();
            this.metroGrid2.DataSource = abs.Get_Absance(a.IdDept, a.IdLev, a.IdSem, a.cmbyeare.Text);

            string remove_duplicated_cell1 = metroGrid2.Rows[0].Cells[0].Value.ToString();

            for (int i = 1; i < metroGrid2.Rows.Count; i++)
            {
                if (metroGrid2.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell1)
                {
                    metroGrid2.Rows[i].Cells[0].Value = string.Empty;


                }
                else
                {
                    remove_duplicated_cell1 = metroGrid2.Rows[i].Cells[0].Value.ToString();
                }
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid2.Rows.Count > 0)
                {
                    if (MessageBox.Show("هل تريد بالفعل حذف حساب الطالب المحدد ؟", "حذف حساب الطالب", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        abs.DelAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString()));
                        MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.metroGrid2.DataSource = abs.Get_Absance(
                    int.Parse(cmbDept.SelectedValue.ToString())
                    , int.Parse(cmbLevel.SelectedValue.ToString())
                    , int.Parse(cmbSem.SelectedValue.ToString()), cmbyeare.Text);

                        string remove_duplicated_cell1 = metroGrid2.Rows[0].Cells[0].Value.ToString();

                        for (int i = 1; i < metroGrid2.Rows.Count; i++)
                        {
                            if (metroGrid2.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell1)
                            {
                                metroGrid2.Rows[i].Cells[0].Value = string.Empty;


                            }
                            else
                            {
                                remove_duplicated_cell1 = metroGrid2.Rows[i].Cells[0].Value.ToString();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على الطالب المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid2.Rows.Count > 0)
                {
                    RPT.rpt_absance_for_stu lt = new RPT.rpt_absance_for_stu();
                    lt.SetParameterValue("@dept_id", abs.GetDeptFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString())));
                    lt.SetParameterValue("@lev_id", abs.GetLevFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString())));
                    lt.SetParameterValue("@sem_id", abs.GetSemFromAbs(int.Parse(this.metroGrid2.CurrentRow.Cells[1].Value.ToString())));
                    lt.SetParameterValue("@stu_id", this.metroGrid2.CurrentRow.Cells[25].Value.ToString());
                    lt.SetParameterValue("@year_std", this.metroGrid2.CurrentRow.Cells[24].Value.ToString());

                    RPT.FRM_absance_for_stu ll = new RPT.FRM_absance_for_stu();
                    ll.crystalReportViewer1.ReportSource = lt;
                    ll.ShowDialog();
                    this.Close();
                }



            }
            catch
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على الطالب المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
