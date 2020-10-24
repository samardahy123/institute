using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Institute.PL
{
    public partial class Stdudent : MetroFramework.Forms.MetroForm
    {
        BL.CLS_stduent Std = new BL.CLS_stduent();
        public Stdudent()
        {
            InitializeComponent();
            this.metroGrid1.DataSource = Std.GetAllStd();
        }

        private void Stdudent_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            RegistStd std = new RegistStd();
            std.ShowDialog(this);
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            RegistStd registStd = new RegistStd();
            registStd.ID = int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString());
            registStd.txtcode.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            registStd.txtstdname.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
            registStd.cmbDept.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
            registStd.cmbLev.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
            registStd.StdType = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
            registStd.txtNationId.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            registStd.txtPlaceG.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
            registStd.txtPlaceC.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
            registStd.txtMob.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
            registStd.txtEmail.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
            registStd.txtQualif.Text = this.metroGrid1.CurrentRow.Cells[11].Value.ToString();
            registStd.Stutus = this.metroGrid1.CurrentRow.Cells[12].Value.ToString();
            registStd.txtyear.Text = Std.GetYStudyStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtaddG.Text = Std.GetAdGStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtaddC.Text = Std.GetAdCStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.Relegion = Std.GetReligionStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtAddress.Text = Std.GetAdDetailStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtSchoolQulif.Text = Std.GetGradPlaceStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtSchoolAdQulif.Text = Std.GetGradCStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtGname.Text = Std.GetGuardianNameStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtRelation.Text = Std.GetGuardianRelStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtJob.Text = Std.GetGuardianJobStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtGNational.Text = Std.GetGuardianNationIdStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtGAdd.Text = Std.GetGuardianAdStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtGmob1.Text = Std.GetGuardianPhone1Std(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.txtGmob2.Text = Std.GetGuardianPhone2Std(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.KnowPlace = Std.GetknownStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            registStd.Frm = "Update";
            registStd.txtNationId.ReadOnly = true;
            registStd.dtjoin.Enabled = false;
            registStd.dtBirth.Enabled = false;
            registStd.dtQualif.Enabled = false;

            registStd.Text ="      تعديل بيانات الطالب: "+ this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            registStd.metroButton1.Text = "تأكيد التعديل";
            byte[] img = (byte[])Std.GetImgStd(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream memory = new MemoryStream(img);
            registStd.stdImg.Image = Image.FromStream(memory);
            registStd.ShowDialog();
            this.metroGrid1.DataSource = Std.GetAllStd();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالفعل حذف الطالب المحدد ؟", "حذف الطالب", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                Std.DelStd(int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.metroGrid1.DataSource = Std.GetAllStd();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = Std.SearchStdName(txtSearchStd.Text);
            this.metroGrid1.DataSource = dataTable;
        }
    }
}
