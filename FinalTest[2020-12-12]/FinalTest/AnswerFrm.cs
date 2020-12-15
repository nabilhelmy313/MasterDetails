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
    public partial class AnswerFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public AnswerFrm()
        {
            InitializeComponent();
            RefreshGrid();
        }
       void RefreshGrid()
        {
            gridControl1.DataSource = db.Answers.ToList();
            questionBindingSource.DataSource = db.Questions.ToList();

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
            AnswerFrm answerFrm = new AnswerFrm();
            answerFrm.Show();
            answerFrm.FormClosed += AnswerFrm_FormClosed;
            Hide();
        }

        private void AnswerFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close() ;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(IdTextEdit.Text);
            if (db.Answers.Where(id => id.Id == x).Any())
            {
                try
                {
                    Answer answer = answerBindingSource.Current as Answer;
                    answer.Text = TextTextEdit.Text;
                    if (string.IsNullOrEmpty(Question_IdLookUpEdit.Text))
                    {
                        XtraMessageBox.Show("PLEASE ENTER THE QUESTION");
                        return;
                    }
                    answer.Question_Id = int.Parse(Question_IdLookUpEdit.EditValue.ToString());
                    answer.DateTime = DateTime.Now;
                    answer.IsUpdated = true;
                    db.Answers.AddOrUpdate(answer);
                    db.SaveChanges();
                    XtraMessageBox.Show("Answer UPDATED SUCCUESSFULLY");
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Answer answer = new Answer();
                    answer.Text = TextTextEdit.Text;
                    if (!string.IsNullOrEmpty(Question_IdLookUpEdit.Text))
                    {
                        answer.Question_Id = int.Parse(Question_IdLookUpEdit.EditValue.ToString());
                    }
                    answer.DateTime = DateTime.Now;
                    answer.IsUpdated = false;
                    db.Answers.Add(answer);
                    db.SaveChanges();
                    XtraMessageBox.Show("Answer ADD SUCCUESSFULLY");
                    RefreshGrid();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Answer question = answerBindingSource.Current as Answer;
            var x = MessageBox.Show("ARE YOU SURE TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                try
                {
                    db.Answers.Remove(question);
                    db.SaveChanges();
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            Answer answer = gridView1.GetFocusedRow() as Answer;
            if (answer!=null)
            {
                answerBindingSource.DataSource = answer;
            }
        }
    }
}