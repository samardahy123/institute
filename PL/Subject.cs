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


    public partial class Subject : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();

        BL.CLS_Subject s = new BL.CLS_Subject();
        DataTable dt;
        public string Type;


        public void RefreshTable()
        {
            dt = s.getSubjectFordept_lev_sem2(int.Parse(cmbDept.SelectedValue.ToString()), int.Parse(cmblevel.SelectedValue.ToString())
                , int.Parse(cmbsem.SelectedValue.ToString()));
            dgrsubject.DataSource = dt;
        }
        public Subject()
        {
            InitializeComponent();
            cmbDept.DataSource = dept.all_department();
            cmbDept.ValueMember = "dept_id";
            cmbDept.DisplayMember = "dept_name";
            cmbDept.BindingContext = BindingContext;


            cmblevel.DataSource = ls.all_lev();
            cmblevel.DisplayMember = "lev_name";
            cmblevel.ValueMember = "lev_id";
            cmblevel.BindingContext = BindingContext;
        }
        public Subject(string type)
        {
            this.Type = type;
            InitializeComponent();
            if (type == "StdAffairs")
            {
                this.metroTile1.Enabled = false;
                this.metroTile2.Enabled = false;
                this.metroTile4.Enabled = false;
            }
            else
            {
                this.metroTile1.Enabled = true;
                this.metroTile2.Enabled = true;
                this.metroTile4.Enabled = true;
            }
            cmbDept.DataSource = dept.all_department();
            cmbDept.ValueMember = "dept_id";
            cmbDept.DisplayMember = "dept_name";
            cmbDept.BindingContext = BindingContext;


            cmblevel.DataSource = ls.all_lev();
            cmblevel.DisplayMember = "lev_name";
            cmblevel.ValueMember = "lev_id";
            cmblevel.BindingContext = BindingContext;
        }

        private void Subject_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            add_subject ad = new add_subject();
            ad.ShowDialog(this);
           // this.RefreshTable();

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالفعل حذف المادة المحددة ؟", "حذف المادة", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {


                s.delet_subject(Int32.Parse(dgrsubject.CurrentRow.Cells[0].Value.ToString()));

                MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefreshTable();
            }
            else
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على المادة المطلوبة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgrsubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmblevel.Text == string.Empty || cmbsem.Text == string.Empty)
            {
                MessageBox.Show("  الرجاء اختر القسم والفرقة ةالترم لعرض المواد", "عرض المواد للقسم المحدد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dt = s.getSubjectFordept_lev_sem(int.Parse(cmbDept.SelectedValue.ToString()), int.Parse(cmblevel.SelectedValue.ToString())
                , int.Parse(cmbsem.SelectedValue.ToString()));
            RefreshTable();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UpdateSubject subject = new UpdateSubject();
            subject.Id =int.Parse(this.dgrsubject.CurrentRow.Cells[0].Value.ToString());
            subject.Text  += this.dgrsubject.CurrentRow.Cells[1].Value.ToString();
            subject.txtsubject.Text = this.dgrsubject.CurrentRow.Cells[1].Value.ToString();
            subject.metroTextBox1.Text = this.dgrsubject.CurrentRow.Cells[2].Value.ToString();
            subject.metroTextBox2.Text = this.dgrsubject.CurrentRow.Cells[3].Value.ToString();
            subject.metroTextBox3.Text = this.dgrsubject.CurrentRow.Cells[4].Value.ToString();
            subject.txtsubject.Enabled = false;
            subject.metroTextBox1.Enabled = false;
            subject.metroTextBox2.Enabled = false;
            subject.metroTextBox3.Enabled = false;
            subject.txtinstructor.Text = this.dgrsubject.CurrentRow.Cells[5].Value.ToString();
            subject.txttotal.Text = this.dgrsubject.CurrentRow.Cells[6].Value.ToString();
            subject.txtsub_t.Text = this.dgrsubject.CurrentRow.Cells[7].Value.ToString();
            subject.ShowDialog();
            this.RefreshTable();
        }
    }
}
