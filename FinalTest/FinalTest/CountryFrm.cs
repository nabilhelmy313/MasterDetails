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

        private void simpleButton6_Click(object sender, EventArgs e)

        {
            
                int id =int.Parse(IdTextEdit.Text);
                if (db.Countries.Where(i => i.Id == id).Any())
                {
                    Country country = countryBindingSource.Current as Country;
                    db.Countries.AddOrUpdate(country);
                    db.SaveChanges();
                    RefershGrid();
                }
                else if (db.Countries.Where(i => i.Id != id).Any())
                {
                    Country country = new Country();
                    country.Name = NameTextEdit.Text;
                    db.Countries.Add(country);
                    db.SaveChanges();
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            BranchFrm frm = new BranchFrm();
            frm.Show();
            frm.FormClosed += Frm_FormClosed;
            Hide();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
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

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}