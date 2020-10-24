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
    public partial class add_class : MetroFramework.Forms.MetroForm
    {
        BL.CLS_class cLS = new BL.CLS_class();
        public string FrmName = "Add";
        public int Id;
        public add_class()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (FrmName == "Add")
            {
                if (txt_class.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل القاعة الجديدة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cLS.add_class(txt_class.Text);
                MessageBox.Show("تم اضافةالقاعة بنجاح بنجاح", "اضافة قاعة جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_class.Clear();
                txt_class.Focus();
            }
            else
            {

                cLS.UpdateClass(this.Id,txt_class.Text);
                MessageBox.Show("تم تعديل القاعة بنجاح ", "تعديل القاعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_class.Clear();
                txt_class.Focus();
            }

        }

        private void add_class_Load(object sender, EventArgs e)
        {

        }

        private void txt_class_KeyPress(object sender, KeyPressEventArgs e)
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
