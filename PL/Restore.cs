using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Institute.PL
{
    public partial class Restore : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Server =.\SAMAR; DataBase = master; Integrated Security = true");

        SqlCommand cmd;
        public Restore()
        {
            InitializeComponent();
        }

        private void Restore_Load(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                txtfilename.Text = openFileDialog1.FileName;
            }

        }

        private void btnbackuo_Click(object sender, EventArgs e)
        {
            string strQuery = "ALTER Database Institute_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Institute_DB from Disk='" + txtfilename.Text+ "' WITH REPLACE" ;
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخة الإحتياطية بنجاح", "عملية استعادة النسخة الإحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
