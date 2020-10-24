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
    public partial class UpdateSubject : MetroFramework.Forms.MetroForm
    {
        public int Id;
        public UpdateSubject()
        {
            InitializeComponent();
        }

        private void UpdateSubject_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtsubject_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtinstructor_Click(object sender, EventArgs e)
        {

        }

        private void btnaddsubject_Click(object sender, EventArgs e)
        {
            if (txtsubject.Text == string.Empty ||txtinstructor.Text == string.Empty || txttotal.Text == string.Empty || txtsub_t.Text == string.Empty)
            {
                MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BL.CLS_Subject sub = new BL.CLS_Subject();
            sub.UpdateSubjects(this.Id,txtsubject.Text, sub.GetDeptFrmSubject(this.Id), sub.GetLevFrmSubject(this.Id), sub.GetSemFrmSubject(this.Id), txtinstructor.Text, Convert.ToInt32(txttotal.Text), Convert.ToInt32(txtsub_t.Text));
            MessageBox.Show("تم تعديل المادة بنجاح ", "تعديل المادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtsubject.Clear();
            txtsubject.Focus();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
