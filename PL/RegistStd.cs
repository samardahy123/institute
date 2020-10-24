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
    public partial class RegistStd : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_stduent std = new BL.CLS_stduent();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        public string Frm = "Add";
        public string Stutus = "";
        public string Gender = "";
        public string StdType = "";
        public string Relegion = "";
        public string KnowPlace = "";
        public int ID;
        public RegistStd()
        {
            InitializeComponent();
            StutusMethod();
            StdTypeMethod();

            this.cmbDept.DataSource = dept.all_department();
            this.cmbDept.DisplayMember = "dept_name";
            this.cmbDept.ValueMember = "dept_id";

            this.cmbLev.DataSource = ls.all_lev();
            this.cmbLev.DisplayMember = "lev_name";
            this.cmbLev.ValueMember = "lev_id";
        }

        private void StutusMethod()
        {
            if (Stutus == "أعزب") rdStus1.Checked = true;
            else if (Stutus == "متزوج") rdStus2.Checked = true;
            else if (Stutus == "أخرى") rdStus3.Checked = true;
        }

        private void StdTypeMethod()
        {
            if (StdType == "انتساب") metroRadioButton1.Checked = true;
            else if (StdType == "انتظام") metroRadioButton2.Checked = true;
            else if (StdType == "أون لاين") metroRadioButton3.Checked = true;
        }

        private void GenderMethod()
        {
            if (Gender == "ذكر") rdG1.Checked = true;
            else if (Gender == "أنثى") rdG.Checked = true;
        }
        private void RelegionMethod()
        {
            if (Relegion == "مسلم") rdRel1.Checked = true;
            else if (Relegion == "مسيحي") rdRel2.Checked = true;
        }

        private void RegistStd_Load(object sender, EventArgs e)
        {
          
        }

        private void metroLabel34_Click(object sender, EventArgs e)
        {

        }


        private void rdStus1_CheckedChanged(object sender, EventArgs e)
        {
            Stutus = "أعزب";
        }

        private void rdStus2_CheckedChanged(object sender, EventArgs e)
        {
            Stutus = "متزوج";
        }

        private void rdStus3_CheckedChanged(object sender, EventArgs e)
        {
            Stutus = "أخرى";
        }

        private void rdG1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "ذكر";
        }

        private void rdG_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "أنثى";
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StdType = "انتساب";
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            StdType = "انتظام";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "ملفات الصور|*.JPG; *.PNG; *.GIF; *.BMP";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                stdImg.Image = Image.FromFile(fileDialog.FileName);
            }

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            if (Frm == "Add")
            {
                MemoryStream stream = new MemoryStream();

                if (stdImg.Image == null)
                    MessageBox.Show("تأكد من إدخال صوره الطالب");

                else if (txtNationId.Text == "")
                    MessageBox.Show("تأكد من الرقم القومى للطالب");

                else if (txtcode.Text == "")
                    MessageBox.Show("تأكد من كود الطالب");
                else if (cmbDept.Text == string.Empty || cmbLev.Text == string.Empty || cmbSem.Text == string.Empty)
                    MessageBox.Show("اختر القسم والفرقة والترم للطالب");
                else if (stdImg.Image != null || txtNationId.Text != "" || txtcode.Text != "")
                {
                    stdImg.Image.Save(stream, stdImg.Image.RawFormat);
                    byte[] img = stream.ToArray();

                    std.AddStd(txtcode.Text, txtyear.Text, dtjoin.Text,
                            txtstdname.Text, dtBirth.Value.Day, dtBirth.Value.Month, dtBirth.Value.Year,
                            txtaddG.Text, txtaddC.Text, Stutus, Gender,
                            txtPlaceG.Text, txtPlaceC.Text, Relegion,
                            txtNationId.Text, txtMob.Text, txtHPhone.Text,
                            txtEmail.Text, txtAddress.Text, Convert.ToInt32(cmbDept.SelectedValue),
                            StdType, txtQualif.Text, dtQualif.Value.Year.ToString(), txtSchoolQulif.Text,
                            txtSchoolAdQulif.Text, txtGname.Text, txtRelation.Text, txtJob.Text, txtGNational.Text,
                            txtGAdd.Text, txtGmob1.Text, txtGmob2.Text, img, KnowPlace, Convert.ToInt32(cmbLev.SelectedValue), Convert.ToInt32(cmbSem.SelectedValue));

                    MessageBox.Show("تم اضافةالطالب بنجاح", "اضافة طالب جديد");

                    this.Close();
                }
            }
            else
            {
                MemoryStream stream = new MemoryStream();
                stdImg.Image.Save(stream, stdImg.Image.RawFormat);
                byte[] img = stream.ToArray();

                std.UpdateStd(ID, txtcode.Text, txtyear.Text, dtjoin.Text,
                        txtstdname.Text, dtBirth.Value.Day, dtBirth.Value.Month, dtBirth.Value.Year,
                        txtaddG.Text, txtaddC.Text, Stutus, Gender,
                        txtPlaceG.Text, txtPlaceC.Text, Relegion,
                        txtNationId.Text, txtMob.Text, txtHPhone.Text,
                        txtEmail.Text, txtAddress.Text, Convert.ToInt32(cmbDept.SelectedValue),
                        StdType, txtQualif.Text, dtQualif.Value.Year.ToString(), txtSchoolQulif.Text,
                        txtSchoolAdQulif.Text, txtGname.Text, txtRelation.Text, txtJob.Text, txtGNational.Text,
                        txtGAdd.Text, txtGmob1.Text, txtGmob2.Text, img, KnowPlace, Convert.ToInt32(cmbLev.SelectedValue), Convert.ToInt32(cmbSem.SelectedValue));

                MessageBox.Show("تم تعديل البيانات بنجاح", "تعديل بيانات");
                this.Close();
            }
        }

        private void txtNationId_Validated(object sender, EventArgs e)
        {
            if (Frm == "Add")
            {
                DataTable dt = new DataTable();
                dt = std.VerifiedStdId(txtNationId.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الطالب موجود مسبقاً", "تنبيه");
                    txtNationId.Focus();
                    txtNationId.SelectionStart = 0;

                }
            }

        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            KnowPlace += "فيس بوك";
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            KnowPlace += "أوراق دعائيه";
        }

        private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            KnowPlace += "لافتات طرق";
        }

        private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            KnowPlace += "اتصالات هاتفيه";
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            KnowPlace += "ترشيح صديق" + txtF.Text;
        }

        private void metroCheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            KnowPlace += "أخرى" + txtOther.Text;
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLev_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmbLev.SelectedValue.ToString(), out val);
            this.cmbSem.DataSource = ls.getallsemfor_lev(val);
            this.cmbSem.DisplayMember = "sem_name";
            this.cmbSem.ValueMember = "sem_id";
        }

        private void stdImg_Click(object sender, EventArgs e)
        {

        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNationId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGNational_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGmob1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGmob2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtstdname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("enter characters only");
            }
        }

        private void txtaddG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("enter characters only");
            }
        }

        private void txtaddC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("enter characters only");
            }
        }

        private void txtPlaceG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("enter characters only");
            }
        }

        private void txtPlaceC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("enter characters only");
            }
        }

        private void txtRel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("enter characters only");
            }
        }

        private void txtcode_Leave(object sender, EventArgs e)
        {
         
        }
        private void txtcode_Validated(object sender, EventArgs e)
        {
            if (Frm == "Add")
            {
                DataTable dt = std.VerifiedStd_code(txtcode.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذاالكود موجود مسبقاً", "تنبيه");
                    txtcode.Focus();
                    txtcode.SelectionStart = 0;

                }
            }
        }

        private void rdRel1_CheckedChanged(object sender, EventArgs e)
        {
            Relegion = "مسلم";
        }

        private void rdRel2_CheckedChanged(object sender, EventArgs e)
        {
            Relegion = "مسيحي";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            StdType = "أون لاين";
        }

        //private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        //{
        //    StdType = "أون لاين";
        //}
    }
}
