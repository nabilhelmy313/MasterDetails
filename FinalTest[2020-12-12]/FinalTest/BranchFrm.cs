using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class BranchFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();

        public BranchFrm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void BranchFrm_Load(object sender, EventArgs e)
        {

        }
        void RefreshGrid()
        {
            gridControl1.DataSource = db.Branches.ToList();
            countryBindingSource.DataSource = db.Countries.ToList();
            cityBindingSource.DataSource = db.Cities.ToList();
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var look = sender as LookUpEdit;
            var row = look.GetSelectedDataRow() as Country;
            var id = row.Id;
            cityBindingSource.DataSource = db.Cities.Where(i => i.Country_Id == id).ToList();
        }

        private void SAVE(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Branch branch= gridView1.GetFocusedRow() as Branch;
            if (branch != null)
            {
                branchBindingSource.DataSource = branch;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextEdit.Text);
            if (db.Branches.Where(i => i.Id == id).Any())
            {
                Branch branch = branchBindingSource.Current as Branch;
                db.Branches.AddOrUpdate(branch);
                db.SaveChanges();
                RefreshGrid();
            }
            else if (db.Branches.Where(i => i.Id != id).Any())
            {
                Branch branch = new Branch();
                branch.Name = NameTextEdit.Text;
                branch.Address = AddressTextEdit.Text;
                branch.Phone1 = Phone1TextEdit.Text;
                branch.Phone2 = Phone2TextEdit.Text;
                branch.NameAr = textnamear.Text;
                if (string.IsNullOrEmpty( StartTimeDateEdit.Text))
                {
                    XtraMessageBox.Show("START DATE MUST ENTER");
                    return;
                }
                branch.StartTime = DateTime.Parse(StartTimeDateEdit.EditValue.ToString());
                if (string.IsNullOrEmpty(EndTimeDateEdit.Text))
                {
                    XtraMessageBox.Show("CLOSED DATE MUST ENTER");
                    return;
                }
                branch.EndTime = DateTime.Parse(EndTimeDateEdit.EditValue.ToString());
                if (!string.IsNullOrEmpty(CityLookUpEdit.Text))
                {
                    branch.City_Id = int.Parse(CityLookUpEdit.EditValue.ToString());
                }
                db.Branches.Add(branch);
                db.SaveChanges();
                RefreshGrid();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          
            Branch branch = branchBindingSource.Current as Branch;
            var x = MessageBox.Show("ARE YOU SURE TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                try
                {
                    db.Branches.Remove(branch);
                    db.SaveChanges();
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            BranchFrm branchFrm = new BranchFrm();
            branchFrm.Show();
            branchFrm.FormClosed += BranchFrm_FormClosed;
            Hide();
        }

        private void BranchFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CategoryFrm categoryFrm = new CategoryFrm();
            categoryFrm.Show();
            categoryFrm.FormClosed += CategoryFrm_FormClosed;
            Hide();
        }

        private void CategoryFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KeywordFrm keywordFrm = new KeywordFrm();
            keywordFrm.Show();
            keywordFrm.FormClosed += KeywordFrm_FormClosed;
            Hide();
        }

        private void KeywordFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuestionFrm questionFrm = new QuestionFrm();
            questionFrm.Show();
            questionFrm.FormClosed += QuestionFrm_FormClosed;
            Hide();
        }

        private void QuestionFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AnswerFrm answerFrm = new AnswerFrm();
            answerFrm.Show();
            answerFrm.FormClosed += AnswerFrm_FormClosed;
            Hide();
        }

        private void AnswerFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmployeeFrm employee = new EmployeeFrm();
            employee.Show();
            employee.FormClosed += Employee_FormClosed;
            Hide();
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DepartmentFrm department = new DepartmentFrm();
            department.Show();
            department.FormClosed += Department_FormClosed;
            Hide();
        }

        private void Department_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CountryFrm country = new CountryFrm();
            country.Show();
            country.FormClosed += Country_FormClosed;
            Hide();
        }

        private void Country_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CityFrm city = new CityFrm();
            city.Show();
            city.FormClosed += City_FormClosed;
            Hide();
        }

        private void City_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BranchFrm branch = new BranchFrm();
            branch.Show();
            branch.FormClosed += Branch_FormClosed;
            Hide();
        }

        private void Branch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}