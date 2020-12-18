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
    public partial class CityFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public CityFrm()
        {
            InitializeComponent();
            countryBindingSource.DataSource = db.Countries.ToList();
            RefershGrid();
            gridView1.Click += GridView1_Click;
        }

        private void GridView1_Click(object sender, EventArgs e)
        {
            City city = gridView1.GetFocusedRow() as City;
            if (city != null)
            {
                cityBindingSource.DataSource = city;
            }
        }

        void RefershGrid()
        {
            gridControl1.DataSource = db.Cities.ToList();
            countryBindingSource.DataSource = db.Countries.ToList();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {


            int id = int.Parse(IdTextEdit.Text);
            if (db.Cities.Where(i => i.Id == id).Any())
            {
                City city = cityBindingSource.Current as City;
                db.Cities.AddOrUpdate(city);
                db.SaveChanges();
                XtraMessageBox.Show("CITY ADDED SUCCESSULLY", "SUCCESS,", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefershGrid();
            }
            else
            {
                City city = new City();
                city.Name = NameTextEdit.Text;
                city.NameAr = textEdit1.Text;
                if (string.IsNullOrEmpty(CountryLookUpEdit.Text.ToString()))
                {
                    return;
                }
                city.Country_Id = int.Parse(CountryLookUpEdit.EditValue.ToString());
                db.Cities.Add(city);
                db.SaveChanges();
                XtraMessageBox.Show("CITY ADDED SUCCESSULLY", "SUCCESS,", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefershGrid();
            }


        }

        private void CityFrm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            City city = cityBindingSource.Current as City;
            var x = XtraMessageBox.Show("ARE YOU SURE TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                db.Cities.Remove(city);
                db.SaveChanges();
                RefershGrid();
            }

        }











        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            CityFrm cityFrm = new CityFrm();
            cityFrm.Show();
            cityFrm.FormClosed += CityFrm_FormClosed;
            Hide();
        }

        private void CityFrm_FormClosed(object sender, FormClosedEventArgs e)
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