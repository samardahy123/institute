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
    public partial class UpdatelecTable : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_class c = new BL.CLS_class();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        public int Id;
        BL.CLS_lectures lec = new BL.CLS_lectures();
        DataTable dt;
        public UpdatelecTable()
        {
            InitializeComponent();
            dt = c.allclasses();
            comboclass.DataSource = dt;
            comboclass.DisplayMember = "class_name";
            comboclass.ValueMember = "clas_id";
        }


        private void UpdatelecTable_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if (txtyear.Text == string.Empty || textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox5.Text == string.Empty ||
                textBox4.Text == string.Empty|| comboday.Text == string.Empty || textBox3.Text == string.Empty ||
               dtpT1.Value.TimeOfDay.Hours >= dtpT2.Value.TimeOfDay.Hours
               )

            {
                MessageBox.Show("  الرجاء ادخال جميع البييانات مع التاكد من عدم حدوث تضارب فى مواعيد المحاضرة", "اضافة جدول محاضرات جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BL.CLS_lectures l = new BL.CLS_lectures();
            l.UpdateLecTale(this.Id,comboday.Text.ToString(),
                            BL.CLS_Settings.time2String(dtpT1.Value),
                            BL.CLS_Settings.time2String(dtpT2.Value),
                            txtyear.Text,
                            l.GetLevFromLecTable(this.Id),
                            l.GetSemFromLecTable(this.Id),
                            l.GetSubFromLecTable(this.Id),
                            l.GetDeptFromLecTable(this.Id),
                            Convert.ToInt32(comboclass.SelectedValue));
            MessageBox.Show("تم تعديل  جدول المحاضرة  بنجاح", "تعديل جدول المحاضرات ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
