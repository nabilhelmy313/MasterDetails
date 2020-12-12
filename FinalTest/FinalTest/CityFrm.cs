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
            if (city!=null)
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
            using (db)
            {
                string name=NameTextEdit.Text;
                if (db.Cities.Where(i=>i.Name==name).Any())
                {
                    City city = cityBindingSource.Current as City;
                    db.Cities.AddOrUpdate(city);
                    db.SaveChanges();
                    RefershGrid();
                }
                else if (db.Cities.Where(i => i.Name != name).Any())
                {
                    City city = new City();
                    city.Name = NameTextEdit.Text;
                    city.Country_Id = int.Parse(CountryLookUpEdit.EditValue.ToString());
                    db.Cities.Add(city);
                    db.SaveChanges();
                    RefershGrid();
                }
              
            }
        }

        private void CityFrm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            City city = cityBindingSource.Current as City;
            var x= MessageBox.Show("ARE YOU SURE TO DELETE","DELETE",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (x==DialogResult.Yes)
            {
                db.Cities.Remove(city);
                db.SaveChanges();
                RefershGrid();
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
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

        private void simpleButton5_Click(object sender, EventArgs e)
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

        private void simpleButton1_Click(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
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

        private void simpleButton3_Click(object sender, EventArgs e)
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