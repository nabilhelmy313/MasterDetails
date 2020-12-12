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
    public partial class EmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public EmployeeFrm()
        {
            InitializeComponent();
            RefreshGrid();
        }
        void RefreshGrid()
        {
            gridControl1.DataSource = db.Employees.ToList();
            branchBindingSource.DataSource = db.Branches.ToList();
            departmentBindingSource.DataSource = db.Departments.ToList();
        }

        private void EmployeeFrm_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Employee employee = gridView1.GetFocusedRow() as Employee;
            if (employee!=null)
            {
                employeeBindingSource.DataSource = employee;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Employee employee = gridView1.GetFocusedRow() as Employee;
            if (employee!=null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextEdit.Text);
            if (db.Employees.Where(i=>i.Id==id).Any())
            {
                Employee employee = employeeBindingSource.Current as Employee;
                db.Employees.AddOrUpdate(employee);
                db.SaveChanges();
                RefreshGrid();
            }
            else if (db.Employees.Where(i => i.Id != id).Any())
            {
                Employee employee = new Employee();
                employee.Name = NameTextEdit.Text;
                employee.Phone1 = Phone1TextEdit.Text;
                employee.Phone2 = Phone2TextEdit.Text;
                employee.Role = RoleTextEdit.Text;
                employee.Branch_Id = int.Parse(Branch_IdLookUpEdit.EditValue.ToString());
                employee.Department_Id = int.Parse(Department_IdLookUpEdit.EditValue.ToString());
                db.Employees.Add(employee);
                db.SaveChanges();
                RefreshGrid();
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
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

        private void simpleButton6_Click(object sender, EventArgs e)
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
    }
}