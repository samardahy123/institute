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
    public partial class frm_lec_class : MetroFramework.Forms.MetroForm
    
    {
       
        public frm_lec_class()
        {
            InitializeComponent();
        }

        private void frm_lec_class_Load(object sender, EventArgs e)
        {
            
        }

        private void cmblevel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnprint_Click(object sender, EventArgs e)
        {



           
            
            try
            {
                RPT.rpt_lec_class lt = new RPT.rpt_lec_class();
                PL.frm_lec_class ll = new PL.frm_lec_class();
                ll.crystalReportViewer1.ReportSource = lt;
                ll.ShowDialog();
                this.Close();
            }
            catch
            {
              //  MessageBox.Show("لا يوجد محاضرات لهذا القسم  الرجاء اختر القسم بشكل صحيح", "طباعة اماكن المحاضرات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
