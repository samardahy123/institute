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
    public partial class Add_mark : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_Marks mark = new BL.CLS_Marks();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_stduent std = new BL.CLS_stduent();
        BL.CLS_absance abs = new BL.CLS_absance();
        DataTable dt;

        private string Subgrade(int m, Double p)
        {


            if (p / m * 100 >= 85)
            {
                return "امتياز";
            }
            else if (p / m * 100 >= 75)
            {
                return "جيد جدا";
            }
            else if (p / m * 100 >= 65)
            {
                return "جيد";
            }
            else if (p / m * 100 >= 50)
            {
                return "مقبول";
            }
            else
            {
                return "ضعيف";
            }
            //}
            //else 
            //{
            //    if (p>=42)
            //    {
            //        return "امتياز";
            //    }
            //    else if (p >=37)
            //    {
            //        return "جيد جدا";
            //    }
            //    else if (p >=32)
            //    {
            //        return "جيد";
            //    }
            //    else if (p >=25)
            //    {
            //        return "مقبول";
            //    }
            //    else
            //    {
            //        return "ضعيف";
            //    }
            //}

        }

        public Add_mark()
        {
            InitializeComponent();

            combodept.DataSource = d.all_department();
            combodept.ValueMember = "dept_id";
            combodept.DisplayMember = "dept_name";
            combodept.BindingContext = BindingContext;
            List<BL.lectures_num> ln = new List<BL.lectures_num>();
            ln.Add(new BL.lectures_num() { num = 12, name = "12" });
            ln.Add(new BL.lectures_num() { num = 13, name = "13" });


            combolevel.DataSource = ls.all_lev();
            combolevel.DisplayMember = "lev_name";
            combolevel.ValueMember = "lev_id";
            combolevel.BindingContext = BindingContext;
        }

        private void Add_mark_Load(object sender, EventArgs e)
        {

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

        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(combolevel.SelectedValue.ToString(), out val);
            this.combosem.DataSource = ls.getallsemfor_lev(val);
            this.combosem.DisplayMember = "sem_name";
            this.combosem.ValueMember = "sem_id";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void combosubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val1;// val2, val3, val4, val5;
            Int32.TryParse(combosubject.SelectedValue.ToString(), out val1);
            //Int32.TryParse(combodept.SelectedValue.ToString(), out val2);
            //Int32.TryParse(combolevel.SelectedValue.ToString(), out val3);
            //Int32.TryParse(combosem.SelectedValue.ToString(), out val4);
            //Int32.TryParse(cmbstd.SelectedValue.ToString(), out val5);

            txt_ts.Text = (s.GetTotalDegFromSubName(val1).ToString());
            //  txtm3.Text = (abs.get_sub_abs_deg(val2, val3, val4, val1, val5).ToString());

            txt_ts.Enabled = false;
            int val;
            Int32.TryParse(txt_ts.Text, out val);
            
           
            if (val == 200)
            {
              //  txtm1.Text = txtm2.Text = txtm3.Text = "-------";
                txtm1.Visible = false;
                txtm2.Visible = false;
                txtm3.Visible = false;

                metroLabel6.Visible = false;
                metroLabel7.Visible = false;
                metroLabel8.Visible = false;


            }
            else
            {
                txtm1.Visible = true;
                txtm2.Visible = true;
                txtm3.Visible = true;
                metroLabel6.Visible = true;
                metroLabel7.Visible = true;
                metroLabel8.Visible = true;


            }
            txttotal.Text = "";
            txtm1.Text = "";
            txtm2.Text = "";
            txtm3.Text = "";

        }

        private void cmbstd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val5;
            Int32.TryParse(cmbstd.SelectedValue.ToString(), out val5);
            txttype.Text = std.GetStuType(val5).ToString();
        }

        private void txtm1_Click(object sender, EventArgs e)
        {

            //double dt1;
            //int val1, val2, val3, val4, val5;
            //Int32.TryParse(combodept.SelectedValue.ToString(), out val1);
            //Int32.TryParse(combolevel.SelectedValue.ToString(), out val2);
            //Int32.TryParse(combosem.SelectedValue.ToString(), out val3);
            //Int32.TryParse(combosubject.SelectedValue.ToString(), out val4);
            //Int32.TryParse(cmbstd.SelectedValue.ToString(), out val5);
            //dt1 = abs.get_sub_abs_deg(val1, val2, val3, val4, val5);
            //txtm3.Text = dt1.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           // if()
            DataTable dt = new DataTable();
            dt = mark.VerifiedMarkSTDId(int.Parse(combodept.SelectedValue.ToString()),
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
                if (combodept.Text == string.Empty || combolevel.Text == string.Empty ||
                combosem.Text == string.Empty || combosubject.Text == string.Empty ||
                cmbstd.Text == string.Empty || txtm1.Text == string.Empty ||
                txtm2.Text == string.Empty || txtm3.Text == string.Empty || txt_ts.Text == string.Empty||cmbyeare.Text==string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    int val1;
                    Int32.TryParse(combosubject.SelectedValue.ToString(), out val1);
                    float valm1, valm2, valm3;
                    float.TryParse(txtm1.Text, out valm1);

                    float.TryParse(txtm2.Text, out valm2);

                    float.TryParse(txtm3.Text, out valm3);

                    txt_ts.Text = (s.GetTotalDegFromSubName(val1).ToString());
                    int val;
                    Int32.TryParse(txt_ts.Text, out val);

                    if (val == 200)
                    {
                        
                        mark.add_marks(0, 0, 0, float.Parse(txttotal.Text),
                            Convert.ToInt32(cmbstd.SelectedValue), Convert.ToInt32(combodept.SelectedValue), Convert.ToInt32(combolevel.SelectedValue),
                            Convert.ToInt32(combosem.SelectedValue), Convert.ToInt32(combosubject.SelectedValue),
                             Subgrade(int.Parse(txt_ts.Text), float.Parse(txttotal.Text)),cmbyeare.Text);

                        MessageBox.Show("تم اضافة درجة المادة بنجاح بنجاح", "اضافة درجة مادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       

                    }

                    else
                    {
                        mark.add_marks(valm1, valm2, valm3, float.Parse(txttotal.Text),
                            Convert.ToInt32(cmbstd.SelectedValue), Convert.ToInt32(combodept.SelectedValue), Convert.ToInt32(combolevel.SelectedValue), Convert.ToInt32(combosem.SelectedValue),
                            Convert.ToInt32(combosubject.SelectedValue),
                            Subgrade(int.Parse(txt_ts.Text), float.Parse(txttotal.Text)),cmbyeare.Text);

                        MessageBox.Show("تم اضافة درجة المادة بنجاح بنجاح", "اضافة درجة مادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
        private void txtm3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtm2_Click(object sender, EventArgs e)
        {

        }



        private void txttotal_Click(object sender, EventArgs e)
        {

        }

        private void txtm3_Click(object sender, EventArgs e)
        {

        }

        private void txtm2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtm1.Text);
                float num2 = float.Parse(txtm2.Text);
                float num3 = float.Parse(txtm3.Text);
                float sum = num1 + num2 + num3;

                txttotal.Text = sum.ToString();
            }
            catch
            {

            }
        }

        private void txtm3_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtm1.Text);
                float num2 = float.Parse(txtm2.Text);
                float num3 = float.Parse(txtm3.Text);
                float sum = num1 + num2 + num3;

                txttotal.Text = sum.ToString();
            }
            catch
            {

            }
        }

        private void txt_ts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtm1_TextChanged(object sender, EventArgs e)
        {
            if (txttype.Text == "انتظام")
            {
                int val1, val2, val3, val4, val5;
                Int32.TryParse(combosubject.SelectedValue.ToString(), out val1);
                Int32.TryParse(combodept.SelectedValue.ToString(), out val2);
                Int32.TryParse(combolevel.SelectedValue.ToString(), out val3);
                Int32.TryParse(combosem.SelectedValue.ToString(), out val4);
                Int32.TryParse(cmbstd.SelectedValue.ToString(), out val5);


                txtm3.Text = (abs.get_sub_abs_deg(val2, val3, val4, val1, val5).ToString());
            }
            else if (txttype.Text == "انتساب") {

                int ss = s.get_sub_t(Convert.ToInt32(combosubject.SelectedValue));

                float subb = ss * 75 / 100;
                txtm3.Text = subb.ToString();
                  }
        }

        private void txtm2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtm1.Text);
                float num2 = float.Parse(txtm2.Text);
                float num3 = float.Parse(txtm3.Text);
                float sum = num1 + num2 + num3;

                txttotal.Text = sum.ToString();
            }
            catch
            {

            }
        }

        private void txtm3_TextChanged_2(object sender, EventArgs e)
        {
            //int val1, val2, val3, val4, val5;
            //Int32.TryParse(combosubject.SelectedValue.ToString(), out val1);
            //Int32.TryParse(combodept.SelectedValue.ToString(), out val2);
            //Int32.TryParse(combolevel.SelectedValue.ToString(), out val3);
            //Int32.TryParse(combosem.SelectedValue.ToString(), out val4);
            //Int32.TryParse(cmbstd.SelectedValue.ToString(), out val5);


            //txtm3.Text = (abs.get_sub_abs_deg(val2, val3, val4, val1, val5).ToString());

        }

        private void txtm1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_ts_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtm1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtm3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtm2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
