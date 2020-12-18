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
    public partial class CountryFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public CountryFrm()
        {
            InitializeComponent();
            RefershGrid();
            gridView1.Click += GridView1_Click;
        }

        private void GridView1_Click(object sender, EventArgs e)
        {
            Country country = gridView1.GetFocusedRow() as Country;
            if (country != null)
            {
                countryBindingSource.DataSource = country;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void simpleButton6_Click(object sender, EventArgs e)

        {

            int id = int.Parse(IdTextEdit.Text);
            if (db.Countries.Where(i => i.Id == id).Any())
            {
                Country country = countryBindingSource.Current as Country;
                db.Countries.AddOrUpdate(country);
                db.SaveChanges();
                XtraMessageBox.Show("COUNTRY UPDATED SUCCUESSFULLY", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefershGrid();
            }
            else
            {
                Country country = new Country();
                country.Name = NameTextEdit.Text;
                country.NameAr = textEdit1.Text;
                db.Countries.Add(country);
                db.SaveChanges();
                XtraMessageBox.Show("COUNTRY ADDED SUCCUESSFULLY", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefershGrid();
            }


        }

        private void RefershGrid()
        {
            gridControl1.DataSource = db.Countries.Local.ToBindingList();
            db.Countries.Load();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            countryBindingSource.DataSource = new Country();
        }




        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            Country country = countryBindingSource.Current as Country;
            var x = MessageBox.Show("ARE YOU SURE TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                db.Countries.Remove(country);
                db.SaveChanges();
                RefershGrid();
            }
        }



        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            CountryFrm countryFrm = new CountryFrm();
            countryFrm.Show();
            countryFrm.FormClosed += CountryFrm_FormClosed;
            Hide();
        }

        private void CountryFrm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CategoryFrm category = new CategoryFrm();
            category.Show();
            category.FormClosed += Category_FormClosed;
            Hide();
        }

        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KeywordFrm keyword = new KeywordFrm();
            keyword.Show();
            keyword.FormClosed += Keyword_FormClosed;
            Hide();
        }

        private void Keyword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuestionFrm question = new QuestionFrm();
            question.Show();
            question.FormClosed += Question_FormClosed;
            Hide();
        }

        private void Question_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AnswerFrm answer = new AnswerFrm();
            answer.Show();
            answer.FormClosed += Answer_FormClosed;
            Hide();
        }

        private void Answer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

    }
}