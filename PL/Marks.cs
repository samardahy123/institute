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
    public partial class Marks : MetroFramework.Forms.MetroForm
    {
        BL.CLS_department d = new BL.CLS_department();
        BL.CLS_lev_sem ls = new BL.CLS_lev_sem();
        BL.CLS_Subject s = new BL.CLS_Subject();
        BL.CLS_absance abs = new BL.CLS_absance();
        BL.CLS_stduent std = new BL.CLS_stduent();
        BL.CLS_Marks mark = new BL.CLS_Marks();
        DataTable dt;

        public Marks()
        {
            InitializeComponent();
            
            cmbDept.DataSource = dt;
            dt = d.all_department();
            cmbDept.DataSource = dt;
            cmbDept.DisplayMember = "dept_name";
            cmbDept.ValueMember = "dept_id";

            dt = ls.all_lev();
            cmbLevel.DataSource = dt;
            cmbLevel.DisplayMember = "lev_name";
            cmbLevel.ValueMember = "lev_id";

        }

        private void Marks_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ////if (int.Parse(cmbLevel.SelectedValue.ToString()) == 2 & (int.Parse(cmbSem.SelectedValue.ToString()) == 4))
            ////{
            ////    if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty)
            ////    {
            ////        MessageBox.Show("رجاءااختر القسم,الفرقة,الترم,اسم الطالب ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////        return;

            ////    }
            ////    try
            ////    {
            ////        this.metroGrid1.DataSource = mark.get_marksfor_dept_lev2_sem2(
            ////           int.Parse(cmbDept.SelectedValue.ToString())
            ////           , int.Parse(cmbLevel.SelectedValue.ToString())
            ////           , int.Parse(cmbSem.SelectedValue.ToString()));

            ////        string remove_duplicated_cell = metroGrid1.Rows[0].Cells[0].Value.ToString();
            ////        for (int i = 1; i < metroGrid1.Rows.Count; i++)
            ////        {
            ////            if (metroGrid1.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell)
            ////            {
            ////                metroGrid1.Rows[i].Cells[0].Value = string.Empty;
            ////            }
            ////            else
            ////            {
            ////                remove_duplicated_cell = metroGrid1.Rows[i].Cells[0].Value.ToString();
            ////            }
            ////        }
            ////    }
            ////    catch
            ////    {
            ////        MessageBox.Show("لا يوجد نتيجة لهذا القسم  الرجاء اختر القسم بشكل صحيح", "عرض النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    }
            ////}
            ////else {
            //   if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty)
            //    {
            //        MessageBox.Show("رجاءااختر القسم,الفرقة,الترم,اسم الطالب ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;

            //    }
            //    try
            //    {
            //        this.metroGrid1.DataSource = mark.get_marksfor_dept_lev_sem(
            //           int.Parse(cmbDept.SelectedValue.ToString())
            //           , int.Parse(cmbLevel.SelectedValue.ToString())
            //           , int.Parse(cmbSem.SelectedValue.ToString()));

            //        string remove_duplicated_cell = metroGrid1.Rows[0].Cells[0].Value.ToString();
            //        for (int i = 1; i < metroGrid1.Rows.Count; i++)
            //        {
            //            if (metroGrid1.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell)
            //            {
            //                metroGrid1.Rows[i].Cells[0].Value = string.Empty;
            //            }
            //            else
            //            {
            //                remove_duplicated_cell = metroGrid1.Rows[i].Cells[0].Value.ToString();
            //            }
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("لا يوجد نتيجة لهذا القسم  الرجاء اختر القسم بشكل صحيح", "عرض النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }



            //}



            if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty||cmbyeare.Text==string.Empty)
            {
                MessageBox.Show("رجاءا اختر القسم والفرقة والترم والسنة الدراسية ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //if()

            try
            {
                this.metroGrid1.DataSource = mark.get_marksfor_dept_lev_sem(
                   int.Parse(cmbDept.SelectedValue.ToString())
                   , int.Parse(cmbLevel.SelectedValue.ToString())
                   , int.Parse(cmbSem.SelectedValue.ToString()),cmbyeare.Text);

                string remove_duplicated_cell = metroGrid1.Rows[0].Cells[0].Value.ToString();
                for (int i = 1; i < metroGrid1.Rows.Count; i++)
                {
                    if (metroGrid1.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell)
                    {
                        metroGrid1.Rows[i].Cells[0].Value = string.Empty;
                    }
                    else
                    {
                        remove_duplicated_cell = metroGrid1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("لا يوجد نتيجة لهذا القسم  الرجاء اختر القسم بشكل صحيح", "عرض النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            Int32.TryParse(cmbLevel.SelectedValue.ToString(), out val);
            this.cmbSem.DataSource = ls.getallsemfor_lev(val);
            this.cmbSem.DisplayMember = "sem_name";
            this.cmbSem.ValueMember = "sem_id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_mark add = new Add_mark();
            add.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty||cmbyeare.Text==string.Empty)
            {
                MessageBox.Show(" رجاءا اختر القسم والفرقة والترم والسنة الدراسية ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            RPT.rpt_get_marks lt = new RPT.rpt_get_marks();
            lt.SetParameterValue("@dept_id", int.Parse(cmbDept.SelectedValue.ToString()));
            lt.SetParameterValue("@lev_id", int.Parse(cmbLevel.SelectedValue.ToString()));
            lt.SetParameterValue("@sem_id", int.Parse(cmbSem.SelectedValue.ToString()));
            lt.SetParameterValue("@year_std", cmbyeare.Text);


            RPT.FRM_RPT_Absance mark = new RPT.FRM_RPT_Absance();
            mark.Text = "تقرير النتيجة";
            mark.crystalReportViewer1.ReportSource = lt;

            mark.ShowDialog();
            //if (int.Parse(cmbLevel.SelectedValue.ToString()) == 2 & (int.Parse(cmbSem.SelectedValue.ToString()) == 2j))
            //{
            //    if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty)
            //    {
            //        MessageBox.Show("رجاءااختر القسم,الفرقة,الترم,اسم الطالب ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;

            //    }


            //    RPT.rpt_get_marks__lev1sem1 lt = new RPT.rpt_get_marks__lev1sem1();
            //    lt.SetParameterValue("@dept_id", int.Parse(cmbDept.SelectedValue.ToString()));
            //    lt.SetParameterValue("@lev_id", int.Parse(cmbLevel.SelectedValue.ToString()));
            //    lt.SetParameterValue("@sem_id", int.Parse(cmbSem.SelectedValue.ToString()));

            //    RPT.FRM_RPT_Absance mark = new RPT.FRM_RPT_Absance();
            //    mark.Text = "تقرير النتيجة";
            //    mark.crystalReportViewer1.ReportSource = lt;

            //    mark.ShowDialog();


            //}
            //else if (int.Parse(cmbLevel.SelectedValue.ToString()) == 1 & (int.Parse(cmbSem.SelectedValue.ToString()) == 2))
            //{
            //    if (cmbDept.Text == string.Empty || cmbLevel.Text == string.Empty || cmbSem.Text == string.Empty)
            //    {
            //        MessageBox.Show("رجاءااختر القسم,الفرقة,الترم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;

            //    }


            //    RPT.rpt_get_marks__lev1sem2 lt = new RPT.rpt_get_marks__lev1sem2();
            //    lt.SetParameterValue("@dept_id", int.Parse(cmbDept.SelectedValue.ToString()));
            //    lt.SetParameterValue("@lev_id", int.Parse(cmbLevel.SelectedValue.ToString()));
            //    lt.SetParameterValue("@sem_id", int.Parse(cmbSem.SelectedValue.ToString()));

            //    RPT.FRM_RPT_Absance mark = new RPT.FRM_RPT_Absance();
            //    mark.Text = "تقرير النتيجة";
            //    mark.crystalReportViewer1.ReportSource = lt;

            //    mark.ShowDialog();


            //}
            }


            private void metroButton1_Click(object sender, EventArgs e)
        {
            UpdateMark Um = new UpdateMark();
            Um.Text = "تعديل النتيجه للطالب:" + this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
            Um.ID = int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString());
            Um.IdDept = mark.GetDeptFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString()));
            Um.IdLev = mark.GetLevFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString()));
            Um.IdSem = mark.GetSemFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString()));
            Um.IdSub = mark.GetSubjectFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString()));
            Um.IdName = mark.GetStdFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString()));
            Um.txtDept.Text = this.metroGrid1.CurrentRow.Cells[8].Value.ToString();
            Um.txtDept.Enabled = false;
            Um.txtLev.Text = this.metroGrid1.CurrentRow.Cells[9].Value.ToString();
            Um.txtLev.Enabled = false;
            Um.txtSem.Text = this.metroGrid1.CurrentRow.Cells[10].Value.ToString();
            Um.txtSem.Enabled = false;
            Um.txtDeg.Text = this.metroGrid1.CurrentRow.Cells[11].Value.ToString();
            Um.txtDeg.Enabled = false;
            Um.txtStd.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
            Um.txtStd.Enabled = false;
            Um.txtSub.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
            Um.txtSub.Enabled = false;
            Um.txtDeg1.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
            Um.txtDeg2.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
            Um.txtDeg3.Text = this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
            Um.txtDegTotal.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            Um.cmbyeare.Text= this.metroGrid1.CurrentRow.Cells[12].Value.ToString();
            Um.ShowDialog();
            try
            {
                this.metroGrid1.DataSource = mark.get_marksfor_dept_lev_sem(
                   Um.IdDept,Um.IdLev,Um.IdSem,Um.cmbyeare.Text);

                string remove_duplicated_cell = metroGrid1.Rows[0].Cells[0].Value.ToString();
                for (int i = 1; i < metroGrid1.Rows.Count; i++)
                {
                    if (metroGrid1.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell)
                    {
                        metroGrid1.Rows[i].Cells[0].Value = string.Empty;
                    }
                    else
                    {
                        remove_duplicated_cell = metroGrid1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("لا يوجد نتيجة لهذا القسم  الرجاء اختر القسم بشكل صحيح", "عرض النتيجة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.Rows.Count > 0)
                {
                    if (MessageBox.Show("هل تريد بالفعل حذف حساب الطالب المحدد ؟", "حذف حساب الطالب", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        mark.DelMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString()));
                        MessageBox.Show("تمت عمليه الحذف بنجاح", "حذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.metroGrid1.DataSource = mark.get_marksfor_dept_lev_sem(
                    int.Parse(cmbDept.SelectedValue.ToString())
                    , int.Parse(cmbLevel.SelectedValue.ToString())
                    , int.Parse(cmbSem.SelectedValue.ToString()),cmbyeare.Text);

                        string remove_duplicated_cell1 = metroGrid1.Rows[0].Cells[0].Value.ToString();

                        for (int i = 1; i < metroGrid1.Rows.Count; i++)
                        {
                            if (metroGrid1.Rows[i].Cells[0].Value.ToString() == remove_duplicated_cell1)
                            {
                                metroGrid1.Rows[i].Cells[0].Value = string.Empty;
                            }
                            else
                            {
                                remove_duplicated_cell1 = metroGrid1.Rows[i].Cells[0].Value.ToString();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على الطالب المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.Rows.Count > 0)
                {

                    RPT.report_allmark_for_dept_lev_stu lt = new RPT.report_allmark_for_dept_lev_stu();
                    lt.SetParameterValue("@dept_id", mark.GetDeptFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString())));
                    lt.SetParameterValue("@lev_id", mark.GetLevFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString())));
                    lt.SetParameterValue("@sem_id", mark.GetSemFromMark(int.Parse(this.metroGrid1.CurrentRow.Cells[1].Value.ToString())));
                    lt.SetParameterValue("@stu_id", int.Parse(this.metroGrid1.CurrentRow.Cells[13].Value.ToString()));
                    lt.SetParameterValue("@year_std", this.metroGrid1.CurrentRow.Cells[12].Value.ToString());



                    RPT.frm_mark_dept_lev_stu ll = new RPT.frm_mark_dept_lev_stu();
                    ll.crystalReportViewer1.ReportSource = lt;
                    ll.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("هذه الخلية لا تحتوى على بيانات من فضلك اضغط على الطالب المطلوب", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
