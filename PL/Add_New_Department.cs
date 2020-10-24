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
    public partial class Add_New_Department : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        public string FrmName = "Add";
        public int ID;

        public Add_New_Department()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadddept_Click(object sender, EventArgs e)
        {
            if (FrmName == "Add")
            {
                if (txtdept.Text == string.Empty ||txttotal.Text==string.Empty || txtprice1.Text == string.Empty|| txtprice2.Text == string.Empty||txtpric3.Text == string.Empty||txtprice4.Text==string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dept.add_department(txtdept.Text, Convert.ToInt32(txttotal.Text), Convert.ToInt32(txtprice1.Text), BL.CLS_Settings.date2String(dtpp1.Value)
                  , Convert.ToInt32(txtprice2.Text), BL.CLS_Settings.date2String(dtp2.Value), Convert.ToInt32(txtpric3.Text), BL.CLS_Settings.date2String(dtp3.Value), Convert.ToInt32(txtprice4.Text), BL.CLS_Settings.date2String(dtpp4.Value));
                MessageBox.Show("تم اضافةالقسم بنجاح بنجاح", "اضافة قسم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtdept.Clear();
                txtdept.Focus();
            }
            else
            {
                dept.UpdateDept(ID,txtdept.Text, Convert.ToInt32(txttotal.Text), Convert.ToInt32(txtprice1.Text), BL.CLS_Settings.date2String(dtpp1.Value)
                  , Convert.ToInt32(txtprice2.Text), BL.CLS_Settings.date2String(dtp2.Value), Convert.ToInt32(txtpric3.Text), BL.CLS_Settings.date2String(dtp3.Value), Convert.ToInt32(txtprice4.Text), BL.CLS_Settings.date2String(dtpp4.Value));
                MessageBox.Show("تم تعديل القسم بنجاح بنجاح", "تعديل قسم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Add_New_Department_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtdept_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtprice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtprice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtpric3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtprice4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtdept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("enter characters only");
            }
        }
    }
}
