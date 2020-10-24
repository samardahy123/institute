using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute.PL
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        BL.CLS_login log = new BL.CLS_login();
        List<string> cmb = new List<string>();
        DataTable dt;
        public Login()
        {
            
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //dt = log.getusers();
            //if (dt.Rows.Count > 0)
            //{
            //    ComboBox1.DisplayMember = "userName";
            //    ComboBox1.ValueMember = "id";
            //    ComboBox1.DataSource = dt;
            //}
            //else
            //{

            //    IDictionary<int, string> comboSource = new Dictionary<int, string>();
            //    comboSource.Add(1, "Admin");
            //    ComboBox1.DataSource = new BindingSource(comboSource, null);
            //    ComboBox1.DisplayMember = "Value";
            //    ComboBox1.ValueMember = "Key";
            //}

        }

        //private void txtlogin_Click(object sender, EventArgs e)
        //{
        //    string selected = this.ComboBox1.GetItemText(this.ComboBox1.SelectedItem);
        //    DataTable dt = log.login(selected, txtpass.Text);
        //    if (selected == "Admin" && txtpass.Text == "111")
        //    {
        //        string type;
        //        log.Type = type = "manager";
        //        Main main = new Main(type);
        //        this.Visible = false;
        //        main.ShowDialog(this);
        //        this.Close();

        //    }
        //    else if(ComboBox1.SelectedValue != null && txtpass.Text.Length > 0)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            string Type = log.GetUserType(int.Parse(ComboBox1.SelectedValue.ToString()));
        //            string type;
        //            if (Type == "مدير")
        //            {
        //                log.Type = type = "manager";
        //            }
        //            else if (Type == "محاسب")
        //            {
        //                log.Type = type = "accountant";
        //            }
        //            else if (Type == "شئون طلاب")
        //            {
        //                log.Type = type = "StdAffairs";
        //            }
        //            else
        //            {
        //                log.Type = type = "else";
        //            }
        //            Main main = new Main(type);
        //            this.Visible = false;
        //            main.ShowDialog(this);
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("بالرجاء ادخال البيانات بشكل صحيح");
        //        }
        //    }
        //}  


        private void txtlogin_Click(object sender, EventArgs e)
        {
            string selected = this.metroTextBox1.Text;
            DataTable dt = log.login(selected, txtpass.Text);
            if (selected == "Admin" && txtpass.Text == "111")
            {
                string type;
                log.Type = type = "manager";
                Main main = new Main(type);
                this.Visible = false;
                main.ShowDialog(this);
                this.Close();

            }
            else 
            {
                if (dt.Rows.Count > 0)
                {
                    string Type = log.GetUserTypeByName(selected);
                    string type;
                    if (Type == "مدير")
                    {
                        log.Type = type = "manager";
                    }
                    else if (Type == "محاسب")
                    {
                        log.Type = type = "accountant";
                    }
                    else if (Type == "شئون طلاب")
                    {
                        log.Type = type = "StdAffairs";
                    }
                    else
                    {
                        log.Type = type = "else";
                    }
                    Main main = new Main(type);
                    this.Visible = false;
                    main.ShowDialog(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("بالرجاء ادخال البيانات بشكل صحيح");
                }
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            config c = new config();
            c.ShowDialog();
        }
    }
    }

