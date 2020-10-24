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
    public partial class Backup : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Server =.\SAMAR; DataBase = Institute_DB; Integrated Security = true");
     
        SqlCommand cmd;
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK) {
                txtfilename.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbackuo_Click(object sender, EventArgs e)
        {

            string filename = txtfilename.Text + "\\Institute_DB" + "-" + DateTime.Now.ToShortDateString().Replace('/', '-')
        + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
            string strQuery = "Backup Database Institute_DB to Disk='" + filename + ".bak'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "عملية إنشاء نسخة إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string Filename = txtfilename.Text + "\\Institute_DB" + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace('/', ':');
            //string strquery = "Backup Database Institute_DB to Disk='" + Filename + ".bak'";
            //cmd = new SqlCommand(strquery, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
