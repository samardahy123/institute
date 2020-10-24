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
    public partial class Accounts : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Account acc = new BL.CLS_Account();
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_login user = new BL.CLS_login();
        string Type;
        public Accounts()
        {
            InitializeComponent();
            this.metroGrid1.DataSource = acc.GetAccount();
        }
        public Accounts(string type)
        {
            this.Type = type;
            InitializeComponent();
            this.metroGrid1.DataSource = acc.GetAccount();
        }
        private void Accounts_Load(object sender, EventArgs e)
        {

        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.Rows.Count > 0)
                {
                    if (MessageBox.Show("هل تريد بالفعل حذف حساب الطالب المحدد ؟", "حذف حساب الطالب", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        acc.DelAccount(int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.metroGrid1.DataSource = acc.GetAccount();
                    }
                }
            }
            catch
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على الطالب المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchStd_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = acc.SearchStdNameAccount(txtSearchStd.Text);
            this.metroGrid1.DataSource = dataTable;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            //AddFees addFees = new AddFees();
            addFee addFees = new addFee(this.Type);
            addFees.ShowDialog();
            this.metroGrid1.DataSource = acc.GetAccount();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UpdateFee updateFees = new UpdateFee(this.Type);
            updateFees.Text = "      تعديل الأقساط للطالب: " + this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            updateFees.ID = int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString());
            updateFees.deptId = acc.GetDeptIdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.student = acc.GetStdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.txtstd.Text = acc.GetStdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.txtstd.Enabled = false;

            updateFees.txtdept.Text = acc.GetDeptFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.dept = acc.GetDeptFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.txtdept.Enabled = false;

            updateFees.lev = acc.GetLevFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.txtlev.Text = acc.GetLevFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.txtlev.Enabled = false;

            updateFees.Sem = acc.GetSemFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.txtsem.Text = acc.GetSemFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString()));
            updateFees.txtsem.Enabled = false;

            updateFees.acc_date5.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
            updateFees.code5.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
            updateFees.price5.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            updateFees.acc_date6.Text = this.metroGrid1.CurrentRow.Cells[7].Value.ToString();
            updateFees.code6.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
            updateFees.price6.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
            updateFees.m1.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();


            updateFees.acc_date7.Text = this.metroGrid1.CurrentRow.Cells[12].Value.ToString();
            updateFees.code7.Text = this.metroGrid1.CurrentRow.Cells[13].Value.ToString();
            updateFees.price7.Text = this.metroGrid1.CurrentRow.Cells[14].Value.ToString();
            updateFees.acc_date8.Text = this.metroGrid1.CurrentRow.Cells[15].Value.ToString();
            updateFees.code8.Text = this.metroGrid1.CurrentRow.Cells[16].Value.ToString();
            updateFees.price8.Text = this.metroGrid1.CurrentRow.Cells[17].Value.ToString();
            updateFees.m2.Text = this.metroGrid1.CurrentRow.Cells[18].Value.ToString();

            updateFees.acc_date9.Text = this.metroGrid1.CurrentRow.Cells[20].Value.ToString();
            updateFees.code9.Text = this.metroGrid1.CurrentRow.Cells[21].Value.ToString();
            updateFees.price9.Text = this.metroGrid1.CurrentRow.Cells[22].Value.ToString();
            updateFees.acc_date10.Text = this.metroGrid1.CurrentRow.Cells[23].Value.ToString();
            updateFees.code10.Text = this.metroGrid1.CurrentRow.Cells[24].Value.ToString();
            updateFees.price10.Text = this.metroGrid1.CurrentRow.Cells[25].Value.ToString();
            updateFees.m3.Text = this.metroGrid1.CurrentRow.Cells[26].Value.ToString();


            updateFees.acc_date11.Text = this.metroGrid1.CurrentRow.Cells[28].Value.ToString();
            updateFees.code11.Text = this.metroGrid1.CurrentRow.Cells[29].Value.ToString();
            updateFees.price11.Text = this.metroGrid1.CurrentRow.Cells[30].Value.ToString();
            updateFees.acc_date12.Text = this.metroGrid1.CurrentRow.Cells[31].Value.ToString();
            updateFees.code12.Text = this.metroGrid1.CurrentRow.Cells[32].Value.ToString();
            updateFees.price12.Text = this.metroGrid1.CurrentRow.Cells[33].Value.ToString();
            updateFees.m4.Text = this.metroGrid1.CurrentRow.Cells[34].Value.ToString();

            updateFees.acc_date1.Text = this.metroGrid1.CurrentRow.Cells[36].Value.ToString();
            updateFees.code1.Text = this.metroGrid1.CurrentRow.Cells[37].Value.ToString();
            updateFees.price1.Text = this.metroGrid1.CurrentRow.Cells[38].Value.ToString();
            updateFees.acc_date2.Text = this.metroGrid1.CurrentRow.Cells[39].Value.ToString();
            updateFees.code2.Text = this.metroGrid1.CurrentRow.Cells[40].Value.ToString();
            updateFees.price2.Text = this.metroGrid1.CurrentRow.Cells[41].Value.ToString();

            updateFees.acc_dat3.Text = this.metroGrid1.CurrentRow.Cells[42].Value.ToString();
            updateFees.code3.Text = this.metroGrid1.CurrentRow.Cells[43].Value.ToString();
            updateFees.price3.Text = this.metroGrid1.CurrentRow.Cells[44].Value.ToString();

            updateFees.acc_date4.Text = this.metroGrid1.CurrentRow.Cells[45].Value.ToString();
            updateFees.code4.Text = this.metroGrid1.CurrentRow.Cells[46].Value.ToString();
            updateFees.price4.Text = this.metroGrid1.CurrentRow.Cells[47].Value.ToString();

            updateFees.ShowDialog();
            this.metroGrid1.DataSource = acc.GetAccount();

        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            //    RPT.FeeOneStd feeOneStdReport = new RPT.FeeOneStd();
            //    feeOneStdReport.SetParameterValue("@id", acc.GetStdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString())));
            //    RPT.FeeOneStdRpt feeOneStd = new RPT.FeeOneStdRpt();
            //    feeOneStd.Text += this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            //    feeOneStd.crystalReportViewer1.ReportSource = feeOneStdReport;
            //    feeOneStd.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            //RPT.FeeTwoStd feeTwoStdReport = new RPT.FeeTwoStd();
            //feeTwoStdReport.SetParameterValue("@id", acc.GetStdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString())));
            //RPT.FeeTwoStdRpt feeTwoStd = new RPT.FeeTwoStdRpt();
            //feeTwoStd.Text += this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            //feeTwoStd.crystalReportViewer1.ReportSource = feeTwoStdReport;
            //feeTwoStd.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            //RPT.FeeThreeStd feeThreeStdReport = new RPT.FeeThreeStd();
            //feeThreeStdReport.SetParameterValue("@id", acc.GetStdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString())));
            //RPT.FeeThreeStdRpt feeThreeStd = new RPT.FeeThreeStdRpt();
            //feeThreeStd.Text += this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            //feeThreeStd.crystalReportViewer1.ReportSource = feeThreeStdReport;
            //feeThreeStd.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            //RPT.FeePostponeStd feePostponeStdReport = new RPT.FeePostponeStd();
            //feePostponeStdReport.SetParameterValue("@id", acc.GetStdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString())));
            //RPT.FeePostponeStdRpt feePostponeStd = new RPT.FeePostponeStdRpt();
            //feePostponeStd.Text += this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            //feePostponeStd.crystalReportViewer1.ReportSource = feePostponeStdReport;
            //feePostponeStd.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            //RPT.FeeConverStd feeConverStdReport = new RPT.FeeConverStd();
            //feeConverStdReport.SetParameterValue("@id", acc.GetStdFromAccount(int.Parse(this.metroGrid1.CurrentRow.Cells[0].Value.ToString())));
            //RPT.FeeConverStdRpt feeConverStd = new RPT.FeeConverStdRpt();
            //feeConverStd.Text += this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            //feeConverStd.crystalReportViewer1.ReportSource = feeConverStdReport;
            //feeConverStd.ShowDialog();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
