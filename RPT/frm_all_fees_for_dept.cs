using Institute.BL;
using Institute.PL;
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
    public partial class frm_all_fees_for_dept : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department dept = new BL.CLS_department();
        BL.CLS_Account acc = new BL.CLS_Account();
        public frm_all_fees_for_dept()
        {
            InitializeComponent();
            combodept.DataSource = dept.all_department();
            combodept.ValueMember = "dept_id";
            combodept.DisplayMember = "dept_name";
            combodept.BindingContext = BindingContext;

        }

        private void frm_all_fees_for_dept_Load(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (combodept.Text == string.Empty )
            {
                MessageBox.Show("رجاءااختر القسم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            RPT.rpt_all_fees_for_dept lt = new RPT.rpt_all_fees_for_dept();
            lt.SetParameterValue("@dept_id", int.Parse(combodept.SelectedValue.ToString()));
            
            RPT.frm_all_fees_for_dept ll = new RPT.frm_all_fees_for_dept();
            ll.crystalReportViewer1.ReportSource = lt;
            ll.ShowDialog();
            this.Close();
        }

        
    }
}
