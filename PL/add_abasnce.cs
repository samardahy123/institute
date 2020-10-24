using CrystalDecisions.Shared;
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
    public partial class add_abasnce : MetroFramework.Forms.MetroForm
    {
        public string frmType = "Add";
        public int ID;
        public string StdName, Sub, Sem;
        public int IdName, IdSub, IdSem;
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        DataTable dt;
        BL.CLS_absance abs = new BL.CLS_absance();
        public add_abasnce()
        {
            InitializeComponent();

            combodept.DataSource = d.all_department();
            combodept.ValueMember = "dept_id";
            combodept.DisplayMember = "dept_name";
            combodept.BindingContext = BindingContext;

            combolevel.DataSource = ls.all_lev();
            combolevel.DisplayMember = "lev_name";
            combolevel.ValueMember = "lev_id";
            combolevel.BindingContext = BindingContext;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void add_abasnce_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (frmType == "Add")
            {
                if (cmbstd.Text == string.Empty || combodept.Text == string.Empty || combolevel.Text == string.Empty || combosem.Text == string.Empty || combosubject.Text == string.Empty || txtlec.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = new DataTable();
                dt = abs.VerifiedAbsSTDId(int.Parse(combodept.SelectedValue.ToString()),
                                           int.Parse(combolevel.SelectedValue.ToString()),
                                           int.Parse(cmbstd.SelectedValue.ToString()),
                                           int.Parse(combosubject.SelectedValue.ToString()),
                                           int.Parse(combosem.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذه الماده مضاف درجاتها مسبقاً", "تنبيه");
                }
                else 
                {
                    float Total;
                    Total = Convert.ToInt32(txtlec.Text.ToString());
                    //int sub_t = Convert.ToInt32(txtt.Text.ToString());
                    Math.Round(Total);
                    int totalLecAttend;
                    totalLecAttend = int.Parse(numlec1.Value.ToString()) + int.Parse(numlec2.Value.ToString()) + int.Parse(numlec3.Value.ToString()) + int.Parse(numlec4.Value.ToString()) + int.Parse(numlec5.Value.ToString()) + int.Parse(numlec6.Value.ToString())
                        + int.Parse(numlec7.Value.ToString()) + int.Parse(numlec8.Value.ToString()) + int.Parse(numlec9.Value.ToString()) + int.Parse(numlec10.Value.ToString()) + int.Parse(numlec11.Value.ToString()) + int.Parse(numlec12.Value.ToString());
                   // Math.Round(totalLecAttend);
                    float totalAttenDeg;
                    totalAttenDeg =( (totalLecAttend / Total) * 100);
                  //  Math.Round(totalAttenDeg);
                    float totalLecAbs;
                    totalLecAbs = (Total - totalLecAttend);
                    Math.Round(totalLecAbs);
                    float totalAbsDeg;
                    totalAbsDeg = ((totalLecAbs / Total) * 100);
                   // Math.Round(totalAbsDeg);
                    int ss = s.get_sub_t(Convert.ToInt32(combosubject.SelectedValue));
                    float SubDeg;
                    SubDeg = (totalLecAttend / Total) * ss;
                    Math.Round(SubDeg);

                    abs.add_absance(Convert.ToInt32(Total), Convert.ToInt32(totalLecAttend), totalAttenDeg, Convert.ToInt32(totalLecAbs), totalAbsDeg, SubDeg,
                        Convert.ToInt32(cmbstd.SelectedValue), Convert.ToInt32(combosubject.SelectedValue), Convert.ToInt32(combodept.SelectedValue),
                        Convert.ToInt32(combolevel.SelectedValue), Convert.ToInt32(combosem.SelectedValue),
                        int.Parse(numlec1.Value.ToString()), int.Parse(numlec2.Value.ToString()), int.Parse(numlec3.Value.ToString()),
                        int.Parse(numlec4.Value.ToString()), int.Parse(numlec5.Value.ToString()), int.Parse(numlec6.Value.ToString()),
                        int.Parse(numlec7.Value.ToString()), int.Parse(numlec8.Value.ToString()), int.Parse(numlec9.Value.ToString()),
                        int.Parse(numlec10.Value.ToString()), int.Parse(numlec11.Value.ToString()), int.Parse(numlec12.Value.ToString()),cmbyeare.Text);


                    MessageBox.Show("تم اضافة غياب المادة بنجاح ", "اضافة غياب مادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                }
            }
            else
            {
                //this.cmbstd.SelectedValue = StdName;
                //this.combosem.SelectedValue = Sem;
                //this.combosubject.SelectedValue = Sub;
                if (/*cmbstd.Text == string.Empty ||*/ combodept.Text == string.Empty || combolevel.Text == string.Empty ||/* combosem.Text == string.Empty || combosubject.Text == string.Empty ||*/ txtlec.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    float Total;
                    Total = Convert.ToInt32(txtlec.Text.ToString());
                    Math.Round(Total);
                    float totalLecAttend;
                    totalLecAttend = int.Parse(numlec1.Value.ToString()) + int.Parse(numlec2.Value.ToString()) + int.Parse(numlec3.Value.ToString()) + int.Parse(numlec4.Value.ToString()) + int.Parse(numlec5.Value.ToString()) + int.Parse(numlec6.Value.ToString())
                        + int.Parse(numlec7.Value.ToString()) + int.Parse(numlec8.Value.ToString()) + int.Parse(numlec9.Value.ToString()) + int.Parse(numlec10.Value.ToString()) + int.Parse(numlec11.Value.ToString()) + int.Parse(numlec12.Value.ToString());
                    Math.Round(totalLecAttend);
                    float totalAttenDeg;
                    totalAttenDeg = ((totalLecAttend / Total) * 100);
                    Math.Round(totalAttenDeg);

                    float totalLecAbs;
                    totalLecAbs = (Total - totalLecAttend);

                    Math.Round(totalLecAbs);
                    float totalAbsDeg;
                    totalAbsDeg = ((totalLecAbs / Total) * 100);
                    Math.Round(totalAbsDeg);


                    int ss = s.get_sub_t(Convert.ToInt32(combosubject.SelectedValue));
                    float SubDeg;
                    SubDeg = (totalLecAttend / Total) * ss;
                    Math.Round(SubDeg);



                    abs.UpdateAbsance(ID, Convert.ToInt32(Total), Convert.ToInt32(totalLecAttend), totalAttenDeg, Convert.ToInt32(totalLecAbs), totalAbsDeg, SubDeg,
                        IdName, IdSub, Convert.ToInt32(combodept.SelectedValue), Convert.ToInt32(combolevel.SelectedValue), IdSem,
                        int.Parse(numlec1.Value.ToString()), int.Parse(numlec2.Value.ToString()), int.Parse(numlec3.Value.ToString()),
                        int.Parse(numlec4.Value.ToString()), int.Parse(numlec5.Value.ToString()), int.Parse(numlec6.Value.ToString()),
                        int.Parse(numlec7.Value.ToString()), int.Parse(numlec8.Value.ToString()), int.Parse(numlec9.Value.ToString()),
                        int.Parse(numlec10.Value.ToString()), int.Parse(numlec11.Value.ToString()), int.Parse(numlec12.Value.ToString()),cmbyeare.Text);

                    MessageBox.Show("تم تعديل الغياب بنجاح ", "تعديل غياب مادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(combolevel.SelectedValue.ToString(), out val);
            this.combosem.DataSource = ls.getallsemfor_lev(val);
            this.combosem.DisplayMember = "sem_name";
            this.combosem.ValueMember = "sem_id";
        }

        private void combosem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int val1, val2, val3;
                Int32.TryParse(combodept.SelectedValue.ToString(), out val1);
                Int32.TryParse(combolevel.SelectedValue.ToString(), out val2);
                Int32.TryParse(combosem.SelectedValue.ToString(), out val3);
                dt = s.getSubjectFordept_lev_sem(val1, val2, val3);


                this.combosubject.DisplayMember = "sub_name";
                this.combosubject.ValueMember = "sub_id";
                combosubject.BindingContext = this.BindingContext;
                this.combosubject.DataSource = dt;



                int val12, val22, val23;
                Int32.TryParse(combodept.SelectedValue.ToString(), out val12);
                Int32.TryParse(combolevel.SelectedValue.ToString(), out val22);
                Int32.TryParse(combosem.SelectedValue.ToString(), out val23);

                cmbstd.DisplayMember = "stu_name";
                cmbstd.ValueMember = "stu_id";
                cmbstd.BindingContext = this.BindingContext;
                cmbstd.DataSource = std.getstudentFordept_lev_sem(val12, val22, val23);



        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}

        private void txtatt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textatt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbstd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtlec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (int.Parse(txtlec.Text.ToString()))
                {
                    case 1:
                       numlec2.Enabled=numlec3.Enabled=numlec4.Enabled=numlec5.Enabled= numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = true;
                        break;

                    case 2:
                         numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = true;
                        break;

                    case 3:
                        numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = true;
                        break;
                    case 4:
                         numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = true;
                        break;


                    case 5:
                        numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = true;
                        break;
                    case 6:
                        numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = true;
                        break;
                    case 7:
                        numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = true;
                        break;
                    case 8:
                        numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = true;

                        break;
                    case 9:
                        numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = true;

                        break;
                    case 10:
                        numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = true;

                        break;
                    case 11:
                        numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = true;

                        break;
                    case 12:

                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = true;

                        break;

                    default:
                        break;
                }
            }
            catch
            {
               // MessageBox.Show("من فضلك ادخل عدد المحاضرات  ", "عدد المحاضرات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtlec_Leave(object sender, EventArgs e)
        {

        }
    }
}
