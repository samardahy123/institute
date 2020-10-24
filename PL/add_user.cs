using Institute.BL;
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
    public partial class add_user : MetroFramework.Forms.MetroForm
    {
        public string frmName = "Add";
        public int id;
        public add_user()
        {
            InitializeComponent();
            //foreach (var item in Enum.GetValues(typeof(UserType)))
            //{
            //    ComboBox1.Items.Add(item);
            //}
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (this.frmName == "Add")
            {
                if (txtusernam.Text == string.Empty || txtusernam.Text == string.Empty || txtpass.Text == string.Empty || txtconfirm.Text == string.Empty || ComboBox1.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtpass.Text != txtconfirm.Text)
                {
                    MessageBox.Show("كلمة المرور غير متطابقة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BL.CLS_login use = new BL.CLS_login();
                use.add_user(txtusernam.Text, txtpass.Text, ComboBox1.Text); ;
                MessageBox.Show("تم اضافةالمستخدم بنجاح", "اضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtusernam.Clear(); txtpass.Clear(); txtconfirm.Clear(); txtusernam.Focus();

            }
            else
            {
                if (txtusernam.Text == string.Empty || txtusernam.Text == string.Empty || txtpass.Text == string.Empty || txtconfirm.Text == string.Empty|| ComboBox1.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtpass.Text != txtconfirm.Text)
                {
                    MessageBox.Show("كلمة المرور غير متطابقة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BL.CLS_login use = new BL.CLS_login();
                use.Updateuser(id,txtusernam.Text, txtpass.Text, ComboBox1.Text); ;
                MessageBox.Show("تم تعديل المستخدم بنجاح", "تعديل مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtusernam.Clear(); txtpass.Clear(); txtconfirm.Clear(); txtusernam.Focus();

            }
        }
        private void txtconfirm_Validated(object sender, EventArgs e)
        {
            if (txtpass.Text != txtconfirm.Text) {
                MessageBox.Show("كلمة المرور غير متطابقة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtid_Click(object sender, EventArgs e)
        {
            
            
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void add_user_Load(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
