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
    public partial class Department : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        public string Type;
        public Department()
        {
            InitializeComponent();
            this.dgvusers.DataSource = d.all_department1();

        }
        public Department(string type)
        {
            this.Type = type;
            InitializeComponent();
            if (type == "StdAffairs")
            {
                this.metroTile1.Enabled = false;
                this.metroTile2.Enabled = false;
                this.metroTile4.Enabled = false;
            }
            else
            {
                this.metroTile1.Enabled = true;
                this.metroTile2.Enabled = true;
                this.metroTile4.Enabled = true;
            }
            this.dgvusers.DataSource = d.all_department1();

        }
        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void dgvusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            Add_New_Department ad = new Add_New_Department();
            ad.ShowDialog();
            this.dgvusers.DataSource = d.all_department1();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (dgvusers.Rows.Count > 0)
                {
                    if (MessageBox.Show("هل تريد بالفعل حذف المستخدم المحدد ؟", "حذف المستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {


                        d.delet_department(dgvusers.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dgvusers.DataSource = d.all_department1();
                    }
                }
                else
                {
                    MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على القسم المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Add_New_Department Edit_Dept = new Add_New_Department();
            Edit_Dept.FrmName = "Edit";
            Edit_Dept.ID = int.Parse(dgvusers.CurrentRow.Cells[0].Value.ToString());
            Edit_Dept.Text = " تعديل لقسم  " + dgvusers.CurrentRow.Cells[1].Value.ToString();
            Edit_Dept.txtdept.Text = dgvusers.CurrentRow.Cells[1].Value.ToString();
            Edit_Dept.txttotal.Text = dgvusers.CurrentRow.Cells[2].Value.ToString();
            Edit_Dept.txtprice1.Text = dgvusers.CurrentRow.Cells[3].Value.ToString();
            Edit_Dept.dtpp1.Text = dgvusers.CurrentRow.Cells[4].Value.ToString();

            Edit_Dept.txtprice2.Text = dgvusers.CurrentRow.Cells[5].Value.ToString();
            Edit_Dept.dtp2.Text = dgvusers.CurrentRow.Cells[6].Value.ToString();

            Edit_Dept.txtpric3.Text = dgvusers.CurrentRow.Cells[7].Value.ToString();
            Edit_Dept.dtp3.Text = dgvusers.CurrentRow.Cells[8].Value.ToString();
            Edit_Dept.txtprice4.Text = dgvusers.CurrentRow.Cells[9].Value.ToString();
            Edit_Dept.dtpp4.Text = dgvusers.CurrentRow.Cells[10].Value.ToString();

            Edit_Dept.btnadddept.Text = "تعديل";
            Edit_Dept.ShowDialog();
            this.dgvusers.DataSource = d.all_department1();
        }
    }
}
