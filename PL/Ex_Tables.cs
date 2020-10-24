using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute.PL
{
    public partial class Ex_Tables : MetroFramework.Forms.MetroForm
    {
        BL.CLS_exam exam = new BL.CLS_exam();
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        public Ex_Tables()
        {
            InitializeComponent();

            metroGrid1.DataSource = exam.GetAllExam();


            cmbDept.DataSource = dept.all_department();
            cmbDept.ValueMember = "dept_id";
            cmbDept.DisplayMember = "dept_name";
            cmbDept.BindingContext = BindingContext;


            cmblevel.DataSource = ls.all_lev();
            cmblevel.DisplayMember = "lev_name";
            cmblevel.ValueMember = "lev_id";
            cmblevel.BindingContext = BindingContext;
        }

        private void Ex_Tables_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            add_exams_table _Exam_Table = new add_exams_table();
            _Exam_Table.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmblevel.Text == string.Empty || cmbsem.Text == string.Empty)
            {
                MessageBox.Show("رجاءااختر القسم,الفرقة,الترم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            DataTable dt = new DataTable();
            dt =exam.SearchExam(int.Parse(cmbDept.SelectedValue.ToString()), int.Parse(cmblevel.SelectedValue.ToString())
                , int.Parse(cmbsem.SelectedValue.ToString()));
            this.metroGrid1.DataSource = dt;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.Rows.Count > 0)
                {
                    if (MessageBox.Show("هل تريد بالفعل حذف الامتحان المحدد ؟", "حذف الامتحان", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        exam.DelExam(int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.metroGrid1.DataSource = exam.GetAllExam();
                    }
                }
            }
            catch
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على الامتحان المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmblevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmblevel.SelectedValue.ToString(), out val);
            this.cmbsem.DataSource = ls.getallsemfor_lev(val);
            this.cmbsem.DisplayMember = "sem_name";
            this.cmbsem.ValueMember = "sem_id";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmblevel.Text == string.Empty || cmbsem.Text == string.Empty)
            {
                MessageBox.Show("رجاءااختر القسم,الفرقة,الترم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            RPT.rpt_exams_table lt = new RPT.rpt_exams_table();
            lt.SetParameterValue("@dept", int.Parse(cmbDept.SelectedValue.ToString()));
            lt.SetParameterValue("@lev", int.Parse(cmblevel.SelectedValue.ToString()));
            lt.SetParameterValue("@sem", int.Parse(cmbsem.SelectedValue.ToString()));
            PL.Ex_Tables ll = new PL.Ex_Tables();
            ll.crystalReportViewer1.ReportSource = lt;
            ll.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }
    }
}
