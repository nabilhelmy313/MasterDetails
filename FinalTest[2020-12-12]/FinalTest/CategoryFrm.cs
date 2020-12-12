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
    public partial class CategoryFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public CategoryFrm()
        {
            InitializeComponent();
            RefershGrid();
            RefreshText();
        }
        void RefershGrid()
        {
            gridControl1.DataSource = db.Categories.ToList();

        }
        void RefreshText()
        {
            NameTextEdit.Text = "";
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(IdTextEdit.Text);
            if (db.Categories.Where(id => id.Id ==x).Any())
            {
                Category category = categoryBindingSource.Current as Category;
                category.Name = NameTextEdit.Text;
                db.Categories.AddOrUpdate(category);
                db.SaveChanges();
                XtraMessageBox.Show("CATEGORY SAVED SUCCUESSFULLY");
                RefershGrid();
            }
            else
            {
                Category category = new Category();
                category.Name = NameTextEdit.Text;
                db.Categories.Add(category);
                db.SaveChanges();
                XtraMessageBox.Show("CATEGORY SAVED SUCCUESSFULLY");
                RefershGrid();
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CategoryFrm categoryfrm = new CategoryFrm();
            categoryfrm.Show();
            categoryfrm.FormClosed += Categoryfrm_FormClosed;
            Hide();
        }

        private void Categoryfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Category category = categoryBindingSource.Current as Category;
            var x = MessageBox.Show("ARE YOU SURE TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                try
                {
                    db.Categories.Remove(category);
                    db.SaveChanges();
                    RefershGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            Category category = gridView1.GetFocusedRow() as Category;
            if (category!=null)
            {
                categoryBindingSource.DataSource=category;
                
            }
        }
    }
}