using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Windows.Forms;



namespace Institute.PL
{
    public partial class config : MetroFramework.Forms.MetroForm
    {
        public config()
        {
            InitializeComponent();
            txtserver.Text = Properties.Settings.Default.Server;
            txtdatabase.Text= Properties.Settings.Default.Database ;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbsql.Checked = true;
                txtusername.Text = Properties.Settings.Default.ID;
                txtpassword.Text = Properties.Settings.Default.Password;

            }
            else {
                rbwindows.Checked = true;
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.ReadOnly = true;
                txtpassword.ReadOnly = true;
            }

            txtusername.Text = Properties.Settings.Default.ID;
            txtpassword.Text = Properties.Settings.Default.Password;





        }

        private void config_Load(object sender, EventArgs e)
        {
            //txtserver.Text = Properties.Settings.Default.Server;
            //txtdatabase.Text= Properties.Settings.Default.Database ;
            //txtusername.Text = Properties.Settings.Default.Mode;
            //txtpassword.Text = Properties.Settings.Default.ID;
            
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtserver.Text;
          Properties.Settings.Default.Database = txtdatabase.Text;
            Properties.Settings.Default.Mode = rbsql.Checked == true ? "SQL" : "Windows";
           // Properties.Settings.Default.DATABASEUSERNAME = txtusername.Text;
           // Properties.Settings.Default.DATABASEPASSWORD= txtpassword.Text;
           // if (checkBox1.Checked == false)
           // {
           //     Properties.Settings.Default.checkshow = false;
           // }
           // else {
           //     Properties.Settings.Default.checkshow =true;
           // }
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح","تاكيد");

        }

        

        private void rbwindows_CheckedChanged(object sender, EventArgs e)
        {
        //    txtusername.ReadOnly = true;
        //    txtpassword.ReadOnly = true;
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtusername.ReadOnly = true;
        //    txtpassword.ReadOnly = true;
        //}

        private void rbsql_CheckedChanged(object sender, EventArgs e)
        {
            txtusername.ReadOnly = false;
            txtpassword.ReadOnly = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

            txtusername.ReadOnly = true;
            txtpassword.ReadOnly = true;
        }

        //private void rbsql_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    txtusername.ReadOnly = false;
        //    txtpassword.ReadOnly = false;
        //}
    }
}
