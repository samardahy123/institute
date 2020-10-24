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
    public partial class User : MetroFramework.Forms.MetroForm
    {
        BL.CLS_login login = new BL.CLS_login();

        public User()
        {
            InitializeComponent();
            this.dgvusers.DataSource = login.getAllUser();

        }


        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            add_user ad = new add_user();
            ad.ShowDialog();
            this.dgvusers.DataSource = login.getAllUser();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالفعل حذف المستخدم المحدد ؟", "حذف المستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                login.delete_user(int.Parse(dgvusers.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvusers.DataSource = login.search_user("");
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgvusers.DataSource = login.search_user(txtsearch.Text);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            add_user user = new add_user();
            user.frmName = "edit";
            user.Text = "تعديل المستخدم";
            user.btnsave.Text = "تعديل";
            user.id = int.Parse(this.dgvusers.CurrentRow.Cells[0].Value.ToString());
            user.txtusernam.Text = this.dgvusers.CurrentRow.Cells[1].Value.ToString();
            user.txtpass.Text = this.dgvusers.CurrentRow.Cells[2].Value.ToString();
            user.txtconfirm.Text = this.dgvusers.CurrentRow.Cells[2].Value.ToString();
            user.ComboBox1.SelectedValue = this.dgvusers.CurrentRow.Cells[3].Value.ToString();
            user.ShowDialog();
            user.Close();
            this.dgvusers.DataSource = login.getAllUser();
        }
    }
}
