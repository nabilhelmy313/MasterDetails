using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class DepartmentFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        
        public DepartmentFrm()
        {
            InitializeComponent();
            RefreshGrid();
        }
        void RefreshGrid()
        {
            gridControl1.DataSource = db.Departments.ToList();
        }
        private void DepartmentFrm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            EmployeeFrm employeeFrm = new EmployeeFrm();
            employeeFrm.Show();
            employeeFrm.FormClosed += EmployeeFrm_FormClosed;
            Hide();
        }

        private void EmployeeFrm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DepartmentFrm departmentFrm = new DepartmentFrm();
            departmentFrm.Show();
            departmentFrm.FormClosed += DepartmentFrm_FormClosed;
            Hide();
        }

        private void DepartmentFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
           Close();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextEdit.Text);
            if (db.Departments.Where(i => i.Id == id).Any())
            {
                Department department = departmentBindingSource.Current as Department;
                db.Departments.AddOrUpdate(department);
                db.SaveChanges();
                XtraMessageBox.Show("DEPARTMENT UPDATED SUCCUESSFULLY", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            else
            {
                Department department = new Department();
                department.Name = NameTextEdit.Text;
                department.NameAr = textEdit1.Text;
                db.Departments.Add(department);
                db.SaveChanges();
                XtraMessageBox.Show("DEPARTMENT ADDED SUCCUESSFULLY", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("ARE YOU SURE TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                Department department = gridView1.GetFocusedRow() as Department;
                if (x == DialogResult.Yes)
                {
                    db.Departments.Remove(department);
                    db.SaveChanges();
                    RefreshGrid();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("CAN'T DELETE THIS DEPARTMENT BECAUSE IT HAS EMPLOYEE IN IT","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            Department department = gridView1.GetFocusedRow() as Department;
            if (department != null)
            {
                departmentBindingSource.DataSource = department;
            }
        }
    }
}