using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class QuestionFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public QuestionFrm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        void RefreshGrid()
        {
            gridControl1.DataSource = db.Questions.ToList();
            categoryBindingSource.DataSource = db.Categories.ToList();
            answerBindingSource.DataSource = db.Categories.ToList();
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

        private void barButtonItem7_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void TextTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
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

        private void gridView1_Click(object sender, EventArgs e)
        {
            Question question = gridView1.GetFocusedRow() as Question;
             ICollection<Answer> answer = question.Answers;
            if (question != null)
            {
                questionBindingSource.DataSource = question;
               

                if (answer.Count()!=0)
                {
                    var an = db.Answers.Where(a => a.Question_Id == question.Id).FirstOrDefault().Text;
                    var ar=db.Answers.Where(a => a.Question_Id == question.Id).FirstOrDefault().TextAr; 
                    answertxt.Text = an;
                    aartext.Text=ar;
                }
                else
                {
                    answertxt.Text = "";
                    aartext.Text = "";
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(IdTextEdit.Text);
            if (string.IsNullOrEmpty(catlookup.Text))
            {
                XtraMessageBox.Show("PLEASE SELECT CATEGORY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Questions.Where(id => id.Id == x).Any())
            {
                Answer answer = new Answer();
                try
                {
                    Question question = questionBindingSource.Current as Question;
                    question.Text = TextTextEdit.Text;
                    question.TextAr = qartext.Text;
                    question.DateTime = DateTime.Now;
                    question.IsUpdated = true;
                    question.Category_Id =int.Parse(catlookup.EditValue.ToString());
                    
                    db.Questions.AddOrUpdate(question);
                    db.SaveChanges();
                    var qid = question.Id;
                    //UPDATE ANSWER IF EXISIT
                    ICollection<Answer> answers = question.Answers;
                    if (answers.Count() != 0)
                    {
                        var ansId = db.Answers.Where(a => a.Question_Id == qid).FirstOrDefault().Id;
                        if (!string.IsNullOrEmpty(answertxt.Text))
                        {
                            Answer aa = new Answer();
                            aa.Id = ansId;
                            aa.Text = answertxt.Text;
                            aa.TextAr = aartext.Text;
                            aa.IsUpdated = true;
                            aa.DateTime = DateTime.Now;
                            aa.Question_Id = qid;
                            db.Answers.AddOrUpdate(aa);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(answertxt.Text))
                        {


                            answer.Question_Id = qid;
                            answer.Text = answertxt.Text;
                            answer.Text = aartext.Text;
                            answer.IsUpdated = false;
                            answer.DateTime = DateTime.Now;
                            question.Category_Id = int.Parse(catlookup.EditValue.ToString());
                            db.Answers.Add(answer);
                            db.SaveChanges();
                        }
                    }
                    XtraMessageBox.Show("QUESTION UPDATED SUCCUESSFULLY");
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
                    Question question = new Question();
                    question.Text = TextTextEdit.Text;
                    question.TextAr = qartext.Text;
                    question.DateTime = DateTime.Now;
                    question.IsUpdated = false;
                    question.Category_Id = int.Parse(catlookup.EditValue.ToString());
                    
                    db.Questions.Add(question);
                    db.SaveChanges();
                    var qid = question.Id;
                  
                    if (!string.IsNullOrEmpty(answertxt.Text))
                    {
                        Answer answer = new Answer();
                        answer.Question_Id = qid;
                        answer.Text = answertxt.Text;
                        answer.TextAr = aartext.Text;
                        answer.IsUpdated = false;
                        answer.DateTime = DateTime.Now;
                        db.Answers.Add(answer);
                        db.SaveChanges();
                    }
                    
                    XtraMessageBox.Show("QUESTION ADD SUCCUESSFULLY");
                    RefreshGrid();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Question question = questionBindingSource.Current as Question;
            var x = MessageBox.Show("ARE YOU SURE TO DELETE", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                try
                {
                    db.Questions.Remove(question);
                    db.SaveChanges();
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void QuestionFrm_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}