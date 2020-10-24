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
    public partial class add_lectures_table : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_class c = new BL.CLS_class();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_lectures lec = new BL.CLS_lectures();
        DataTable dt;
        public add_lectures_table()
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combodepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {


            int val;
            Int32.TryParse(combolevel.SelectedValue.ToString(), out val);
            this.combosem.DataSource = ls.getallsemfor_lev(val);
            this.combosem.DisplayMember = "sem_name";
            this.combosem.ValueMember = "sem_id";
            //int val;
            ////Int32.TryParse(combolevel.SelectedValue.ToString(), out val);
            ////dt = ls.getallsemfor_lev(val);
            ////combosem.DataSource = dt;
            ////combosem.DisplayMember = "sem_name";
            ////combosem.ValueMember = "sem_id";
            ////combosem.BindingContext = this.BindingContext;


           
            //combosubject.BindingContext = this.BindingContext;

        }

        private void add_lectures_table_Load(object sender, EventArgs e)
        {

        }

        private void combosubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(combosubject.SelectedValue.ToString(), out val);
            dt = s.select_instructorname(val);
           comboinstructor.DataSource = dt;
            comboinstructor.DisplayMember = "instrcutor_name";
            comboinstructor.ValueMember = "instrcutor_name";
          // combosem.BindingContext = this.BindingContext;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool checkNotInterval()
        {
            bool resault = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String dtime_s1 = dt.Rows[i][2].ToString();
                String dtime_s2 = dt.Rows[i][3].ToString();
                DateTime dtime1 = BL.CLS_SqlToStringDate.ConvertString2Time(dtime_s1);
                DateTime dtime2 = BL.CLS_SqlToStringDate.ConvertString2Time(dtime_s2);
                if (!(dtpT1.Value >= dtime2 && dtpT2.Value >= dtime2) && !(dtpT1.Value <= dtime1 && dtpT2.Value <= dtime1) && comboday.SelectedIndex == Int32.Parse(dt.Rows[i][0].ToString()))
                {
                    resault = false;
                    break;
                }
            }
            return resault;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DataTable datatale = lec.VerifiedLecTable(comboday.Text.ToString(), BL.CLS_Settings.time2String(dtpT1.Value), txtyear.Text, Convert.ToInt32(combosubject.SelectedValue),
                Convert.ToInt32(combodepartment.SelectedValue), Convert.ToInt32(combolevel.SelectedValue),
                Convert.ToInt32(combosem.SelectedValue), Convert.ToInt32(comboclass.SelectedValue));

            if (txtyear.Text == string.Empty || combodepartment.Text == string.Empty || combolevel.Text == string.Empty || combosem.Text == string.Empty || comboinstructor.Text == string.Empty
               || comboday.Text == string.Empty || combosubject.Text == string.Empty ||
               dtpT1.Value.TimeOfDay.Hours >= dtpT2.Value.TimeOfDay.Hours
               )

            {
                MessageBox.Show("  الرجاء ادخال جميع البييانات مع التاكد من عدم حدوث تضارب فى مواعيد المحاضرة", "اضافة جدول محاضرات جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (datatale.Rows.Count > 0)
            {
                MessageBox.Show("هذا اليوم أو الفصل غير فارغ فى هذا التوقيت ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BL.CLS_lectures l = new BL.CLS_lectures();
            l.add_lectures(comboday.Text.ToString(),
                            BL.CLS_Settings.time2String(dtpT1.Value),
                            BL.CLS_Settings.time2String(dtpT2.Value),
                            txtyear.Text,
                            Convert.ToInt32(combolevel.SelectedValue),
                            Convert.ToInt32(combosem.SelectedValue),
                            Convert.ToInt32(combosubject.SelectedValue),
                            Convert.ToInt32(combodepartment.SelectedValue),
                            Convert.ToInt32(comboclass.SelectedValue));
            MessageBox.Show("تم اضافة  جدول المحاضرة  بنجاح", "اضافة جدول محاضرات جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            txtyear.Clear();
            txtyear.Focus();

            }

        private void combosem_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int val1, val2, val3;
                Int32.TryParse(combodepartment.SelectedValue.ToString(), out val1);
                Int32.TryParse(combolevel.SelectedValue.ToString(), out val2);
                Int32.TryParse(combosem.SelectedValue.ToString(), out val3);
                dt = s.getSubjectFordept_lev_sem(val1, val2, val3);

                
                this.combosubject.DisplayMember = "sub_name";
                this.combosubject.ValueMember = "sub_id";
                combosubject.BindingContext = this.BindingContext;
                this.combosubject.DataSource = dt;

               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void comboclass_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
    
    } 


    


