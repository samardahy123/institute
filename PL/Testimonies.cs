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
    public partial class Testimonies : MetroFramework.Forms.MetroForm
    {
        public Testimonies()
        {
            InitializeComponent();
        }

        private void Testimonies_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            PL.testimonies5 testimonies4 = new PL.testimonies5();
            testimonies4.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PL.Testimonies1 t1 = new PL.Testimonies1();
            t1.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PL.Tesstimonies2 t2 = new PL.Tesstimonies2();
            t2.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            PL.testimonies3 testimonies3 = new PL.testimonies3();
            testimonies3.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            PL.Testimonies4 testimonies4 = new PL.Testimonies4();
            testimonies4.ShowDialog();
        }
    }
}
