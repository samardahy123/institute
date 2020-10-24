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
    public partial class addFee : MetroFramework.Forms.MetroForm
    {

        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_absance abs = new BL.CLS_absance();
        BL.CLS_stduent std = new BL.CLS_stduent();
        BL.CLS_Account acc = new BL.CLS_Account();
        BL.CLS_login user = new BL.CLS_login();
        DataTable dt;
        string Type; 
        public float price;
        private void DefaultValues()
        {
            code1.Text = "0";
            price1.Text = "0";
            code2.Text = "0";
            price2.Text = "0";
            code3.Text = "0";
            price3.Text = "0";
            code4.Text = "0";
            price4.Text = "0";
            code5.Text = "0";
            price5.Text = "0";
            code6.Text = "0";
            price6.Text = "0";
            m1.Text = " ";
            code7.Text = "0";
            price7.Text = "0";
            code8.Text = "0";
            price8.Text = "0";
            m2.Text = " ";
            code9.Text = "0";
            price9.Text = "0";
            code10.Text = "0";
            price10.Text = "0";
            m3.Text = " ";

            code11.Text = "0";
            price11.Text = "0";
            code12.Text = "0";
            price12.Text = "0";
            m4.Text = " ";


        }
        
        public addFee()
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
            this.DefaultValues();
            

        }
        public addFee(string type)
        {
             this.Type = user.Type= type;

            InitializeComponent();

            dt = d.all_department();
            cmbDept.DataSource = dt;
            cmbDept.DisplayMember = "dept_name";
            cmbDept.ValueMember = "dept_id";

            dt = ls.all_lev();
            cmbLevel.DataSource = dt;
            cmbLevel.DisplayMember = "lev_name";
            cmbLevel.ValueMember = "lev_id";
            this.DefaultValues();

        }
        private void addFee_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFee_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                if (cmbDept.SelectedValue == null || cmbLevel.SelectedValue == null || cmbStd.SelectedValue == null)
                {
                    MessageBox.Show("تأكد من اختيار القسم أو الفرقة أو الترم أو الطالب", "تنبيه");
                }
                else {
                    dt = acc.VerifiedAccountId(int.Parse(cmbDept.SelectedValue.ToString()),
                                               int.Parse(cmbLevel.SelectedValue.ToString()),
                                               int.Parse(cmbStd.SelectedValue.ToString()));
                
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الحساب موجود مسبقاً", "تنبيه");
                }
                else
                {
                    acc.Add_Account(BL.CLS_Settings.date2String(acc_date1.Value.Date), code1.Text, float.Parse(price1.Text),
                                BL.CLS_Settings.date2String(acc_date2.Value.Date), code2.Text, float.Parse(price2.Text),
                                BL.CLS_Settings.date2String(acc_dat3.Value.Date), code3.Text, float.Parse(price3.Text),
                                BL.CLS_Settings.date2String(acc_date4.Value.Date), code4.Text, float.Parse(price4.Text),
                                BL.CLS_Settings.date2String(acc_date5.Value.Date), code5.Text, float.Parse(price5.Text),
                                BL.CLS_Settings.date2String(acc_date6.Value.Date), code6.Text, float.Parse(price6.Text),
                                m1.Text, d.GetPrice1Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price5.Text) +
                                float.Parse(price6.Text)),
                                BL.CLS_Settings.date2String(acc_date7.Value.Date), code7.Text, float.Parse(price7.Text),
                                BL.CLS_Settings.date2String(acc_date8.Value.Date), code8.Text, float.Parse(price8.Text),
                                m2.Text, d.GetPrice2Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price7.Text) +
                                float.Parse(price8.Text)),
                                BL.CLS_Settings.date2String(acc_date9.Value.Date), code9.Text, float.Parse(price9.Text),
                                BL.CLS_Settings.date2String(acc_date10.Value.Date), code10.Text, float.Parse(price10.Text),
                                m3.Text,
                                d.GetPrice2Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price8.Text) +
                                float.Parse(price9.Text)),
                                BL.CLS_Settings.date2String(acc_date11.Value.Date), code11.Text,
                                float.Parse(price11.Text),
                                BL.CLS_Settings.date2String(acc_date12.Value.Date), code12.Text, float.Parse(price12.Text),
                                m4.Text, (float.Parse(price1.Text) + float.Parse(price2.Text) + float.Parse(price3.Text) +
                                float.Parse(price4.Text) + float.Parse(price5.Text) + float.Parse(price6.Text) +
                                float.Parse(price7.Text) + float.Parse(price8.Text) + float.Parse(price9.Text) +
                                float.Parse(price10.Text) + float.Parse(price11.Text) + float.Parse(price12.Text)),

                                int.Parse(cmbStd.SelectedValue.ToString()),
                                int.Parse(cmbLevel.SelectedValue.ToString()),
                                int.Parse(cmbDept.SelectedValue.ToString()));

                    MessageBox.Show("تم اضافةالحساب بنجاح", "اضافة حساب جديد");
                    this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void combolevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
                Int32.TryParse(cmbLevel.SelectedValue.ToString(), out val);
                this.cmbSem.DataSource = ls.getallsemfor_lev(val);
                this.cmbSem.DisplayMember = "sem_name";
                this.cmbSem.ValueMember = "sem_id";
         
        }

        private void combosem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
                {
                    int val1, val2, val3;
                    Int32.TryParse(cmbDept.SelectedValue.ToString(), out val1);
                    Int32.TryParse(cmbLevel.SelectedValue.ToString(), out val2);
                    Int32.TryParse(cmbSem.SelectedValue.ToString(), out val3);

                    cmbStd.DisplayMember = "stu_name";
                    cmbStd.ValueMember = "stu_id";
                    cmbStd.BindingContext = this.BindingContext;
                    cmbStd.DataSource = std.getstudentFordept_lev_sem(val1, val2, val3);

                }
            catch //(Exception ex)
                {
                    //  MessageBox.Show(ex.ToString());
                }
            
        }

        private void acc_date5_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void price6_Leave(object sender, EventArgs e)
        {
            float Rest1 = d.GetPrice1Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price5.Text) + (float.Parse(price6.Text)));
            if (Rest1 < 0)
            {
                txtrest1.Text = "0";
            }
            else
            {
                txtrest1.Text = (Rest1).ToString();
            }

            if (this.Type == "manager")
            {
                price6.Enabled = true;
            }
            else if (this.Type == "accountant")
            {
                float P = d.GetPrice1Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price5.Text));
                if (float.Parse(price6.Text) < P)
                {
                    MessageBox.Show("تأكد من المبلغ الذى أدخلته!", "تنبيه");
                    price6.Text = "";

                }
                else
                {
                    price6.Enabled = true;
                }
            }
        }

        private void price8_Leave(object sender, EventArgs e)
        {

            float Rest2 = d.GetPrice2Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price7.Text) + float.Parse(price8.Text));
            if (Rest2 < 0)
            {
                txtrest2.Text = "0";
            }
            else
            {
                txtrest2.Text = (Rest2).ToString();
            }

            if (this.Type == "manager")
            {
                price8.Enabled = true;
            }
            else if (this.Type == "accountant")
            {
                float P = d.GetPrice2Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price7.Text));
                if (float.Parse(price8.Text) < P)
                {
                    MessageBox.Show("تأكد من المبلغ الذى أدخلته!", "تنبيه");
                    price8.Text = "";

                }
                else
                {
                    price8.Enabled = true;
                }
            }
        }

        private void price10_Leave(object sender, EventArgs e)
        {
            float Rest3 = d.GetPrice3Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price9.Text) + float.Parse(price10.Text));
            if (Rest3 < 0)
            {
                txtrest3.Text = "0";
            }
            else
            {
                txtrest3.Text = (Rest3).ToString();
            }

            if (this.Type == "manager")
            {
                price10.Enabled = true;
            }
            else if (this.Type == "accountant")
            {
                float P = d.GetPrice3Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price9.Text));
                if (float.Parse(price10.Text) < P)
                {
                    MessageBox.Show("تأكد من المبلغ الذى أدخلته!", "تنبيه");
                    price10.Text = "";

                }
                else
                {
                    price10.Enabled = true;
                }
            }
        }

        private void price12_Leave(object sender, EventArgs e)
        {
            txtrest4.Text = (float.Parse(price1.Text) + float.Parse(price2.Text) + float.Parse(price3.Text) +
                          float.Parse(price4.Text) + float.Parse(price5.Text) + float.Parse(price6.Text) +
                          float.Parse(price7.Text) + float.Parse(price8.Text) + float.Parse(price9.Text) +
                          float.Parse(price10.Text) + float.Parse(price11.Text) + float.Parse(price12.Text)).ToString();



            if (this.Type == "manager")
            {
                price12.Enabled = true;
            }
            else if (this.Type == "accountant")
            {
                float P = d.GetPrice4Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price11.Text));
                if (float.Parse(price12.Text) < P)
                {
                    MessageBox.Show("تأكد من المبلغ الذى أدخلته!", "تنبيه");
                    price12.Text = "";

                }
                else
                {
                    price12.Enabled = true;
                }
            }
        }

        private void price5_Leave(object sender, EventArgs e)
        {

            float Rest1 = d.GetPrice1Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price5.Text) + (float.Parse(price6.Text)));
            if (Rest1 < 0)
            {
                txtrest1.Text = "0";
            }
            else
            {
                txtrest1.Text = (Rest1).ToString();
            }
        }

        private void price7_Leave(object sender, EventArgs e)
        {

            float Rest2 = d.GetPrice2Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price7.Text) + float.Parse(price8.Text));
            if (Rest2 < 0)
            {
                txtrest2.Text = "0";
            }
            else
            {
                txtrest2.Text = (Rest2).ToString();
            }
        }

        private void price9_Leave(object sender, EventArgs e)
        {
            float Rest3 = d.GetPrice3Dept(int.Parse(cmbDept.SelectedValue.ToString())) - (float.Parse(price9.Text) + float.Parse(price10.Text));
            if (Rest3 < 0)
            {
                txtrest3.Text = "0";
            }
            else
            {
                txtrest3.Text = (Rest3).ToString();
            }
        }

        private void price11_Leave(object sender, EventArgs e)
        {
            txtrest4.Text = (float.Parse(price1.Text) + float.Parse(price2.Text) + float.Parse(price3.Text) +
                          float.Parse(price4.Text) + float.Parse(price5.Text) + float.Parse(price6.Text) +
                          float.Parse(price7.Text) + float.Parse(price8.Text) + float.Parse(price9.Text) +
                          float.Parse(price10.Text) + float.Parse(price11.Text) + float.Parse(price12.Text)).ToString();

        }

        private void price5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrest1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrest2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrest3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtrest4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
