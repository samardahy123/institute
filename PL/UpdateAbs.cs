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
    public partial class UpdateAbs : MetroFramework.Forms.MetroForm
    {

        public int ID;
        public string StdName, Sub, Sem;
        public int IdDept, IdLev, IdName, IdSub, IdSem, SubDegT;

        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        DataTable dt;
        BL.CLS_absance abs = new BL.CLS_absance();
        public UpdateAbs()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtDept.Text == string.Empty || txtLev.Text == string.Empty || txtSem.Text == string.Empty || txtSub.Text == string.Empty || txtStd.Text == string.Empty || txtlec.Text == string.Empty)
            {
                MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                float Total;
                Total = Convert.ToInt32(txtlec.Text.ToString());
                Math.Ceiling(Total);
                float totalLecAttend;
                totalLecAttend = int.Parse(numlec1.Value.ToString())
                               + int.Parse(numlec2.Value.ToString())
                               + int.Parse(numlec3.Value.ToString())
                               + int.Parse(numlec4.Value.ToString())
                               + int.Parse(numlec5.Value.ToString())
                               + int.Parse(numlec6.Value.ToString())
                               + int.Parse(numlec7.Value.ToString())
                               + int.Parse(numlec8.Value.ToString())
                               + int.Parse(numlec9.Value.ToString())
                               + int.Parse(numlec10.Value.ToString())
                               + int.Parse(numlec11.Value.ToString())
                               + int.Parse(numlec12.Value.ToString());
                Math.Ceiling(totalLecAttend);
                float totalAttenDeg;
                totalAttenDeg = ((totalLecAttend / Total) * 100);
                Math.Ceiling(totalAttenDeg);
                float totalLecAbs;
                totalLecAbs = (Total - totalLecAttend);
                Math.Ceiling(totalLecAbs);
                float totalAbsDeg;
                totalAbsDeg = ((totalLecAbs / Total) * 100);
                Math.Ceiling(totalAbsDeg);
                int ss = s.get_sub_t(this.IdSub);
                float SubDeg;
                SubDeg = (totalLecAttend / Total) * ss;
                Math.Ceiling(SubDeg);
                abs.UpdateAbsance(ID,
                        Convert.ToInt32(txtlec.Text.ToString()),
                        Convert.ToInt32(totalLecAttend),
                        totalAttenDeg,
                        Convert.ToInt32(totalLecAbs),
                        totalAbsDeg,
                        SubDeg,
                        IdName,
                        IdSub,
                        IdDept,
                        IdLev,
                        IdSem,
                        int.Parse(numlec1.Value.ToString()),
                        int.Parse(numlec2.Value.ToString()),
                        int.Parse(numlec3.Value.ToString()),
                        int.Parse(numlec4.Value.ToString()),
                        int.Parse(numlec5.Value.ToString()),
                        int.Parse(numlec6.Value.ToString()),
                        int.Parse(numlec7.Value.ToString()),
                        int.Parse(numlec8.Value.ToString()),
                        int.Parse(numlec9.Value.ToString()),
                        int.Parse(numlec10.Value.ToString()),
                        int.Parse(numlec11.Value.ToString()),
                        int.Parse(numlec12.Value.ToString())
                        ,cmbyeare.Text);

                MessageBox.Show("تم تعديل الغياب بنجاح ", "تعديل غياب مادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void combosem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtatt_num_TextChanged(object sender, EventArgs e)
        {

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

                        numlec2.Enabled= numlec3.Enabled= numlec4.Enabled= numlec5.Enabled= numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = true;

                        numlec2.Value= numlec3.Value = numlec4.Value = numlec5.Value = numlec6.Value = numlec7.Value = numlec8.Value = numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;
                    case 2:

                        numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled= numlec2.Enabled = true;

                        numlec3.Value = numlec4.Value = numlec5.Value = numlec6.Value = numlec7.Value = numlec8.Value = numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;
                    case 3:

                         numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled= true;

                         numlec4.Value = numlec5.Value = numlec6.Value = numlec7.Value = numlec8.Value = numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;
                    case 4:

                        numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = true;

                        numlec5.Value = numlec6.Value = numlec7.Value = numlec8.Value = numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;

                    case 5:
                       
                        numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = true;

                        numlec6.Value = numlec7.Value = numlec8.Value = numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;
                    case 6:
                        numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec7.Value = numlec8.Value = numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled =numlec6.Enabled= true;

                        break;
                    case 7:
                        numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled =numlec7.Enabled= true;
                        numlec8.Value = numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;
                    case 8:
                        numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled =numlec8.Enabled= true;

                        numlec9.Value = numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;
                    case 9:
                       
                        numlec10.Enabled = numlec11.Enabled = numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled =numlec9.Enabled= true;

                        numlec10.Value = numlec11.Value = numlec12.Value = 0;
                        break;
                    case 10:
                        numlec11.Enabled = numlec12.Enabled = false;

                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled= true;

                        numlec11.Value = numlec12.Value = 0;
                        break;
                    case 11:
                        numlec12.Enabled = false;
                        numlec1.Enabled = numlec2.Enabled = numlec3.Enabled = numlec4.Enabled = numlec5.Enabled = numlec6.Enabled = numlec7.Enabled = numlec8.Enabled = numlec9.Enabled = numlec10.Enabled = numlec11.Enabled = true;

                       
                        numlec12.Value = 0;
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
             //   MessageBox.Show("من فضلك اختر رقم المحاضرة وادخل عدد المحاضرات  ", "عدد المحاضرات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtlec_Leave(object sender, EventArgs e)
        {

        }

        private void UpdateAbs_Load(object sender, EventArgs e)
        {

        }
    }
}
