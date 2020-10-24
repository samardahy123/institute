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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        BL.CLS_login user = new BL.CLS_login();
        string Type;
        public Main()
        {
            InitializeComponent();
        }
        public Main(string type)
        {
            this.Type = type;
            InitializeComponent();
            if (type == "else") 
            {
                this.المستخدمونToolStripMenuItem.Enabled = false;
                this.الطلابToolStripMenuItem.Enabled = false;
                this.الشعبToolStripMenuItem.Enabled = false;
                this.المصاريفToolStripMenuItem.Enabled = false;
                this.toolStripMenuItem1.Enabled = false;
                this.الجداولToolStripMenuItem.Enabled = false;
                this.إحصائيهالغيابToolStripMenuItem.Enabled = false;
                this.المعاملاتاليوميهToolStripMenuItem.Enabled = false;
                this.الحساباتToolStripMenuItem.Enabled = false;
                this.metroTile1.Enabled = false;
                this.metroTile2.Enabled = false;
                this.metroTile3.Enabled = false;
                this.metroTile4.Enabled = false;
                this.metroTile5.Enabled = false;
                this.metroTile6.Enabled = false;
                this.metroTile7.Enabled = false;
                this.metroTile8.Enabled = false;
                this.اضافهToolStripMenuItem.Enabled = false;
            }
            else if (type == "accountant")
            {
                this.المستخدمونToolStripMenuItem.Enabled = false;
                this.الشعبToolStripMenuItem.Enabled = false;
                this.الطلابToolStripMenuItem.Enabled = false;
                this.toolStripMenuItem1.Enabled = false;
                this.الجداولToolStripMenuItem.Enabled = false;
                this.إحصائيهالغيابToolStripMenuItem.Enabled = false;
                this.المعاملاتاليوميهToolStripMenuItem.Enabled = false;
                this.metroTile1.Enabled = false;
                this.metroTile2.Enabled = false;
                this.metroTile3.Enabled = false;
                this.metroTile5.Enabled = false;
                this.metroTile6.Enabled = false;
                this.metroTile7.Enabled = false;
                this.metroTile8.Enabled = false;
                this.اضافهToolStripMenuItem.Enabled = false;
               // this.نتيجةالاختباراتToolStripMenuItem.Enabled = false;
                //this.إحصائيهالغيابToolStripMenuItem.Enabled = false;
            }
            else if (type == "StdAffairs")
            {
                this.المستخدمونToolStripMenuItem.Enabled = false;
                this.المصاريفToolStripMenuItem.Enabled = false;
                this.الحساباتToolStripMenuItem.Enabled = false;
                this.metroTile4.Enabled = false;
                this.اضافهToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.المستخدمونToolStripMenuItem.Enabled = true;
                this.اضافهToolStripMenuItem.Enabled = true;
            }

        }
        int counter = 0;
        int len = 0;
        string txt;

        private void Main_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
            //timer1.Enabled = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            RegistStd Rstd = new RegistStd();
            Rstd.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts(this.Type);
            accounts.ShowDialog();
        }

        private void أضافهجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stdudent std = new Stdudent();
            std.ShowDialog();

        }

        private void إضافهمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user add_User = new add_user();
            add_User.ShowDialog();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistStd Rstd = new RegistStd();
            Rstd.ShowDialog();
        }

        private void اضافهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_subject add_Subject = new add_subject();
            add_Subject.ShowDialog();
        }

        private void عرضالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void المساحهوالاشرافالمعمارىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department department = new Department(this.Type);
            department.ShowDialog();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            LecTable lecTable = new LecTable();
            lecTable.ShowDialog();
        }

        private void المحاضراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecTable lecTable = new LecTable();
            lecTable.ShowDialog();

        }

        private void عرضحسبالشعبهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject g = new Subject(this.Type);
            g.ShowDialog();

        }

        private void اضافةجدولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_lectures_table add = new add_lectures_table();

            add.ShowDialog();
        }

        private void الشعبToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void حذفجدولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecTable table = new LecTable();
            table.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Testimonies testimonies = new Testimonies();
            testimonies.ShowDialog();
        }

        private void المعاملاتاليوميهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testimonies testimonies = new Testimonies();
            testimonies.ShowDialog();
        }

        private void اثباتقيدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Testimonies1 testimonies1 = new PL.Testimonies1();
            testimonies1.ShowDialog();
        }

        private void اثباتقيدموجههToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.Tesstimonies2 testimonies2 = new PL.Tesstimonies2();
            testimonies2.ShowDialog();
        }

        private void تغييرنظامالجدولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.testimonies3 testimonies3 = new PL.testimonies3();
            testimonies3.ShowDialog();
        }

        private void الامتحاناتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةجدولToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_exams_table ex = new add_exams_table();
            ex.ShowDialog();
        }

        private void عرضالجداولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex_Tables table = new Ex_Tables();
            table.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marks m = new Marks();
            m.ShowDialog();
        }

        private void تسجيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_mark mm = new Add_mark();
            mm.ShowDialog();
        }

        private void عرضToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Absance ab = new Absance();
            ab.ShowDialog();
        }

        private void تسجيلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_abasnce ab = new add_abasnce();
            ab.ShowDialog();
        }

        private void المدفوعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void عرضالخريجينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graduate graduate = new Graduate();
            graduate.ShowDialog();
        }

        private void شهاداتالتخرجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DegreeCertificate certificate = new DegreeCertificate();
            certificate.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {

            DegreeCertificate certificate = new DegreeCertificate();
            certificate.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            PL.frm_lec_class c = new PL.frm_lec_class();
            c.ShowDialog();
        }

        private void القسطالأولToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //RPT.FeeOneRpt feeOneRpt = new RPT.FeeOneRpt();
            //feeOneRpt.ShowDialog();
        }

        private void القسطالثانىToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //RPT.FeeTwoRpt feeTwoRpt = new RPT.FeeTwoRpt();
            //feeTwoRpt.ShowDialog();
        }

        private void القسطالثالثToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        //    RPT.FeeThreeRpt feeThreeRpt = new RPT.FeeThreeRpt();
        //    feeThreeRpt.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void اقساطالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounts ad = new Accounts(this.Type);
            ad.ShowDialog();
        }

        private void اقساطالفرقToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الفرقهالأولىToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void جميعالاقساطToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RPT.frm_all_account al = new RPT.frm_all_account();
            al.ShowDialog();
        }

        private void القسطالأولToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void جميعالاقساطللقسمالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.frm_all_fees_for_dept all = new RPT.frm_all_fees_for_dept();
            all.ShowDialog();
        }

        private void فرقةاولىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee2_Lev1 f21 = new RPT.FRM_Fee2_Lev1();
            f21.ShowDialog();
        }

        private void المصاريفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الفرقةالاولىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee1_Lev1 f11 = new RPT.FRM_Fee1_Lev1();
            f11.ShowDialog();
        }

        private void الفرقةالثانيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee1_Lev2 f12 = new RPT.FRM_Fee1_Lev2();
            f12.ShowDialog();
        }

        private void فرقةثانيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee2_Lev2 f22 = new RPT.FRM_Fee2_Lev2();
            f22.ShowDialog();
        }

        private void الفرقةالاولىToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee3_Lev1 f31 = new RPT.FRM_Fee3_Lev1();
            f31.ShowDialog();
        }

        private void الفرقةالثانيةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee3_Lev2 f32 = new RPT.FRM_Fee3_Lev2();
            f32.ShowDialog();
        }

        private void الفرقةالاولىToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee4_Lev1 f41 = new RPT.FRM_Fee4_Lev1();
            f41.ShowDialog();
        }

        private void الفرقةالثانيةToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RPT.FRM_Fee4_Lev2 f42 = new RPT.FRM_Fee4_Lev2();
            f42.ShowDialog();
        }

        private void إحصائيهالغيابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.FRM_RPT_Absance A = new RPT.FRM_RPT_Absance();
            A.ShowDialog();

        }

        private void الغيابللطالبالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.FRM_absance_for_stu s = new RPT.FRM_absance_for_stu();
            s.ShowDialog();
        }

        private void تأجيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Testimonies4 testimonies4 = new PL.Testimonies4();
            testimonies4.ShowDialog();
        }

        private void مواعيداختباراتالمجندينToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL.testimonies5 testimonies5 = new PL.testimonies5();
            testimonies5.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void الفرقةالاولىToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_lat_lev1 l1 = new RPT.FRM_rpt_lat_lev1();
            l1.ShowDialog();
        }

        private void الفرقةالثانيةToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_lat_lev2 l2 = new RPT.FRM_rpt_lat_lev2();
            l2.ShowDialog();
        }

        private void الفرقةالاولىToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_type_lev1 l1 = new RPT.FRM_rpt_type_lev1();
            l1.ShowDialog();
        }

        private void الفرقةالثانيةToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_type_lev2 l2 = new RPT.FRM_rpt_type_lev2();
            l2.ShowDialog();
        }

        private void الطلابالذيننسبةغيابهمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.FRM_rpt_abs_morethan20 f = new RPT.FRM_rpt_abs_morethan20();
            f.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            PL.add_abasnce ad = new PL.add_abasnce();
            ad.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            PL.Marks m = new PL.Marks();
            m.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label1.Text = "";
            }
            else
            {
                label1.Text = txt.Substring(0, counter);
                Random rand = new Random();
                int one = rand.Next(0, 255);
                int two = rand.Next(0, 255);
                int three = rand.Next(0, 255);
                int four = rand.Next(0, 255);
                label1.ForeColor = Color.FromArgb(one, two, three, four);
            }
        }

        private void النتيجةللطالبالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.frm_mark_dept_lev_stu ss = new RPT.frm_mark_dept_lev_stu();
            ss.ShowDialog();
        }

        private void الطلابالمنقطعينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT.frm_stu_account_lat s = new RPT.frm_stu_account_lat();
            s.ShowDialog();

        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Backup b = new PL.Backup();
            b.ShowDialog();
        }

        private void استعادةالنسخةالاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Restore r = new PL.Restore();
            r.ShowDialog();
        }

        private void اعدادتالاتصالبقاعدةالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
    }
    }

