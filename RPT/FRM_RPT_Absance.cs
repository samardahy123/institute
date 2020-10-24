using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute.RPT
{
    public partial class FRM_RPT_Absance : MetroFramework.Forms.MetroForm
    {
        public FRM_RPT_Absance()
        {
            InitializeComponent();
        }

        private void FRM_RPT_Absance_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchStd_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchStd_TextChanged(object sender, EventArgs e)
        {
            BL.CLS_stduent Std = new BL.CLS_stduent();
            DataTable dataTable = new DataTable();
            dataTable = Std.SearchStdName(txtSearchStd.Text);
            //this.crystalReportViewer1.ReportSource= dataTable;
            this.crystalReportViewer1.RefreshReport();
        }

        private void rpt_absance1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
