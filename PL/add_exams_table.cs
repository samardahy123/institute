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
    public partial class add_exams_table : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_class c = new BL.CLS_class();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        DataTable dt;
        public add_exams_table()
        {
            InitializeComponent();
            dt = d.all_department();
            combodepartment.DataSource = dt;
            combodepartment.DisplayMember = "dept_name";
            combodepartment.ValueMember = "dept_id";

            dt = c.allclasses();
            comboclass.DataSource = dt;
            comboclass.DisplayMember = "class_name";
            comboclass.ValueMember = "clas_id";


            dt = ls.all_lev();
            combolevel.DataSource = dt;
            combolevel.DisplayMember = "lev_name";
            combolevel.ValueMember = "lev_id";


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // if (dtpT1.Value.TimeOfDay.Hours < dtpT2.Value.TimeOfDay.Hours)
            if (comboday.Text == string.Empty ||
           comboclass.Text == string.Empty ||
           combodepartment.Text == string.Empty ||
           combosubject.Text == string.Empty ||
           combolevel.Text == string.Empty ||
           combosem.Text == string.Empty ||
            txtyear.Text == string.Empty ||
           dtpT1.Value >= dtpT2.Value)
            {

                MessageBox.Show("الرجاء ادخال جميع البيانات والتاكد من عدم حدوث تعارض فى مواعيد الامتحان", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                BL.CLS_exam ex= new BL.CLS_exam();
                ex.add_exams(comboday.Text.ToString(),
                               BL.CLS_Settings.date2String(dateTimePicker1.Value),
                               BL.CLS_Settings.time2String(dtpT1.Value),
                               BL.CLS_Settings.time2String(dtpT2.Value),
                               txtyear.Text, Convert.ToInt32(combosubject.SelectedValue),
                                Convert.ToInt32(comboclass.SelectedValue),
                                Convert.ToInt32(combolevel.SelectedValue),
                               Convert.ToInt32(combodepartment.SelectedValue),
                               Convert.ToInt32(combosem.SelectedValue));
                MessageBox.Show("تم اضافة  جدول الامتحانات  بنجاح", "اضافة جدول امتحانات جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            
            

        }

        private void add_exams_table_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combodepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int val, val1, val2;

            //Int32.TryParse(combodepartment.SelectedValue.ToString(), out val);
            //Int32.TryParse(combolevel.SelectedValue.ToString(), out val1);
            //Int32.TryParse(combosem.SelectedValue.ToString(), out val2);

            //dt = s.getSubjectFordepartment(val,val1,val2);
            //combosubject.DataSource = dt;
            //combosubject.DisplayMember = "sub_name";
            //combosubject.ValueMember = "sub_id";
        }

        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(combolevel.SelectedValue.ToString(), out val);
            dt = ls.getallsemfor_lev(val);
            combosem.DataSource = dt;
            combosem.DisplayMember = "sem_name";
            combosem.ValueMember = "sem_id";
        }

        private void combosem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val, val1, val2;
            Int32.TryParse(combodepartment.SelectedValue.ToString(), out val);
            Int32.TryParse(combolevel.SelectedValue.ToString(), out val1);
            Int32.TryParse(combosem.SelectedValue.ToString(), out val2);
            // dt = s.getSubjectFordept_lev_sem(val, val1, val2);
            this.combosubject.DataSource = s.getSubjectFordept_lev_sem(val, val1, val2);
            this.combosubject.DisplayMember = "sub_name";
            this.combosubject.ValueMember = "sub_id";
            //combosubject.BindingContext = this.BindingContext;

        }
    }
}
