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
    public partial class frm_all_account : MetroFramework.Forms.MetroForm
    {
        public frm_all_account()
        {
            InitializeComponent();
        }

        private void frm_all_account_Load(object sender, EventArgs e)
        {
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            RPT.rpt_get_account lt = new RPT.rpt_get_account();

            RPT.frm_all_account abs = new RPT.frm_all_account();
             abs.crystalReportViewer1.ReportSource = lt;
            abs.ShowDialog();
        }
    }
}
