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
    public partial class Class : MetroFramework.Forms.MetroForm
    {
        BL.CLS_class C = new BL.CLS_class();
        public Class()
        {
            InitializeComponent();
            this.gird.DataSource = C.allclasses();
        }

        private void Class_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            add_class Class = new add_class();
            Class.ShowDialog();
            this.gird.DataSource = C.allclasses();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            add_class Class = new add_class();
            Class.FrmName = "Edit";
            Class.Text = "تعديل القاعه" + this.gird.CurrentRow.Cells[1].Value.ToString();
            Class.btnadd.Text = "تعديل";
            Class.Id = int.Parse(this.gird.CurrentRow.Cells[0].Value.ToString());
            Class.ShowDialog();
            this.gird.DataSource = C.allclasses();


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            C.DelClass(int.Parse(this.gird.CurrentRow.Cells[0].Value.ToString()));
            MessageBox.Show("تم حذف القاعة بنجاح ", "حذف القاعه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.gird.DataSource = C.allclasses();


        }
    }
}
