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
    public partial class add_subject : MetroFramework.Forms.MetroForm
    {

        BL.CLS_department us = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();

        DataTable dt;
        public add_subject()
        {
            InitializeComponent();
            dt = us.all_department();
            ComboBox1.DataSource = dt;
            ComboBox1.DisplayMember = "dept_name";
            ComboBox1.ValueMember = "dept_id";

            dt = ls.all_lev();
            cmbLevel.DataSource = dt;
            cmbLevel.DisplayMember = "lev_name";
            cmbLevel.ValueMember = "lev_id";



        }

        private void add_subject_Load(object sender, EventArgs e)
        {
            
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnaddsubject_Click(object sender, EventArgs e)
        {
            if (txtsubject.Text == string.Empty || ComboBox1.Text == string.Empty ||cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty || txtinstructor.Text==string.Empty||txttotal.Text==string.Empty||txtsub_t.Text==string.Empty)
            {
                MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            BL.CLS_Subject sub = new BL.CLS_Subject();
            sub.add_subjects(txtsubject.Text, Convert.ToInt32(ComboBox1.SelectedValue), Convert.ToInt32(cmbLevel.SelectedValue), Convert.ToInt32(cmbSem.SelectedValue),txtinstructor.Text, Convert.ToInt32(txttotal.Text), Convert.ToInt32(txtsub_t.Text));

            MessageBox.Show("تم اضافةالمادة بنجاح بنجاح", "اضافة مادة جديدة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtsubject.Clear();
            txtsubject.Focus();

        }

        private void txtid_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmbLevel.SelectedValue.ToString(), out val);
            this.cmbSem.DataSource = ls.getallsemfor_lev(val);
            this.cmbSem.DisplayMember = "sem_name";
            this.cmbSem.ValueMember = "sem_id";
        }

        private void txttotal_Validated(object sender, EventArgs e)
        {
            
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtsub_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
    }

