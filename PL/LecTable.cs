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
    public partial class LecTable : MetroFramework.Forms.MetroForm
    {
        BL.CLS_lectures lectures = new BL.CLS_lectures();
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        
        public LecTable()
        {
            InitializeComponent();
            
            metroGrid1.DataSource = lectures.GetAllLec();


            cmbDept.DataSource = dept.all_department();
            cmbDept.ValueMember = "dept_id";
            cmbDept.DisplayMember = "dept_name";
            cmbDept.BindingContext = BindingContext;


            cmblevel.DataSource = ls.all_lev();
            cmblevel.DisplayMember = "lev_name";
            cmblevel.ValueMember = "lev_id";
            cmblevel.BindingContext = BindingContext;
        }

        private void LecTable_Load(object sender, EventArgs e)
        {

        }
        private void cmblevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmblevel.SelectedValue.ToString(), out val);
            this.cmbsem.DataSource = ls.getallsemfor_lev(val);
            this.cmbsem.DisplayMember = "sem_name";
            this.cmbsem.ValueMember = "sem_id";
        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            add_lectures_table _Lectures_Table = new add_lectures_table();
            _Lectures_Table.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.Rows.Count > 0)
                {
                    if (MessageBox.Show("هل تريد بالفعل حذف القسم المحدد ؟", "حذف المستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        lectures.DelLec(int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.metroGrid1.DataSource = lectures.GetAllLec();
                    }
                }
            }
            catch
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على القسم المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmblevel.Text == string.Empty || cmbsem.Text == string.Empty)
            {
                MessageBox.Show("رجاءااختر القسم,الفرقة,الترم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            DataTable dt = new DataTable();
            dt = lectures.SearchLec(int.Parse(cmbDept.SelectedValue.ToString()),int.Parse(cmblevel.SelectedValue.ToString())
                ,int.Parse(cmbsem.SelectedValue.ToString()));
            this.metroGrid1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UpdatelecTable table = new UpdatelecTable();
            table.Id = int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString());
            table.txtyear.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            table.textBox3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
            table.textBox4.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            table.textBox1.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
            table.textBox2.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
            table.textBox5.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
            table.txtyear.Enabled = false;
            table.textBox1.Enabled = false;
            table.textBox2.Enabled = false;
            table.textBox3.Enabled = false;
            table.textBox4.Enabled = false;
            table.textBox5.Enabled = false;

            table.ShowDialog();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmblevel.Text == string.Empty || cmbsem.Text == string.Empty )
            {
                MessageBox.Show("رجاءااختر القسم,الفرقة,الترم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            RPT.lecture_table lt = new RPT.lecture_table();
            lt.SetParameterValue("@dept", int.Parse( cmbDept.SelectedValue.ToString()));
            lt.SetParameterValue("@lev", int.Parse(cmblevel.SelectedValue.ToString()));
            lt.SetParameterValue("@sem", int.Parse(cmbsem.SelectedValue.ToString()));
            PL.LecTable ll = new PL.LecTable();
            ll.crystalReportViewer1.ReportSource = lt;
            ll.ShowDialog();
        }
    }
}
