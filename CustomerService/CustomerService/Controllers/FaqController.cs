using CustomerService.Models;
using CustomerService.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerService.Controllers
{
    public class FaqController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Faq
        public ActionResult Index(string search)
        {
            var c = db.Categories.ToList();
            if (search == null)
            {
                List<FAQViewModel> fAQ = new List<FAQViewModel>();
                var Q = db.Questions.OrderByDescending(a => a.Id).ToList();
                for (int i = 0; i < Q.Count(); i++)
                {
                    fAQ.Add(new FAQViewModel { Qid = Q[i].Id, QName = Q[i].Text });
                }

                for (int i = 0; i < fAQ.Count(); i++)
                {
                    var x = fAQ[i].Qid;
                    fAQ[i].Answers = db.Answers.Where(id => id.Question.Id == x).Select(a => a.Text).ToList();
                }
                ViewBag.cat = c;


                return View(fAQ);
            }
            else
            {
                var Q = db.Questions.Where(s => s.Text.Contains(search) || search == null).OrderByDescending(a => a.Id).ToList();
                List<FAQViewModel> fAQ = new List<FAQViewModel>();

                for (int i = 0; i < Q.Count(); i++)
                {
                    fAQ.Add(new FAQViewModel { Qid = Q[i].Id, QName = Q[i].Text });
                }

                for (int i = 0; i < fAQ.Count(); i++)
                {
                    var x = fAQ[i].Qid;
                    fAQ[i].Answers = db.Answers.Where(id => id.Question.Id == x).Select(a => a.Text).ToList();
                }
                ViewBag.cat = c;
                return View(fAQ);
            }

        }
        //index Arabic
        public ActionResult IndexAr(string search)
        {
                var c = db.Categories.ToList();
            if (search == null)
            {
                List<FAQViewModel> fAQ = new List<FAQViewModel>();
                var Q = db.Questions.OrderByDescending(a => a.Id).ToList();
                for (int i = 0; i < Q.Count(); i++)
                {
                    fAQ.Add(new FAQViewModel { Qid = Q[i].Id, QName = Q[i].TextAr });
                }

                for (int i = 0; i < fAQ.Count(); i++)
                {
                    var x = fAQ[i].Qid;
                    fAQ[i].Answers = db.Answers.Where(id => id.Question.Id == x).Select(a => a.TextAr).ToList();
                }
                ViewBag.cat = c;


                return View(fAQ);
            }
            else
            {
                var Q = db.Questions.Where(s => s.TextAr.Contains(search) || search == null).OrderByDescending(a => a.Id).ToList();
                List<FAQViewModel> fAQ = new List<FAQViewModel>();

                for (int i = 0; i < Q.Count(); i++)
                {
                    fAQ.Add(new FAQViewModel { Qid = Q[i].Id, QName = Q[i].TextAr });
                }

                for (int i = 0; i < fAQ.Count(); i++)
                {
                    var x = fAQ[i].Qid;
                    fAQ[i].Answers = db.Answers.Where(id => id.Question.Id == x).Select(a => a.TextAr).ToList();
                }
                ViewBag.cat = c;

                return View(fAQ);
            }
        }
        //public ActionResult CatSearch(int catid)
        //{
        //    var key = db.Keywords.Where(k => k.Category.Id == catid).ToList();
        //    return View();
        //}

        public ActionResult GetQuestionbyCat(int catid)
        {
            var Q = db.Questions.Where(c => c.Category.Id == catid).OrderByDescending(a => a.Id).ToList();
            List<FAQViewModel> fAQ = new List<FAQViewModel>();
            for (int i = 0; i < Q.Count(); i++)
            {
                fAQ.Add(new FAQViewModel { Qid = Q[i].Id, QName = Q[i].Text });
            }

            for (int i = 0; i < fAQ.Count(); i++)
            {
                var x = fAQ[i].Qid;
                fAQ[i].Answers = db.Answers.Where(id => id.Question.Id == x).Select(a => a.Text).ToList();
            }

            ViewBag.cat = db.Categories.ToList();
            return View("Index",fAQ);
        }
        public ActionResult GetQuestionbyCatAr(int catid)
        {
            var Q = db.Questions.Where(c => c.Category.Id == catid).OrderByDescending(a => a.Id).ToList();
            List<FAQViewModel> fAQ = new List<FAQViewModel>();
            for (int i = 0; i < Q.Count(); i++)
            {
                fAQ.Add(new FAQViewModel { Qid = Q[i].Id, QName = Q[i].TextAr });
            }

            for (int i = 0; i < fAQ.Count(); i++)
            {
                var x = fAQ[i].Qid;
                fAQ[i].Answers = db.Answers.Where(id => id.Question.Id == x).Select(a => a.TextAr).ToList();
            }

            ViewBag.cat = db.Categories.ToList();
            return View("IndexAr", fAQ);
        }
        //public JsonResult GetAnswer(int id)
        //{
        //    var faq = new FAQViewModel
        //    {
        //       Answers  = db.Answers.Where(k => k.Question.Id == id).ToList()
        //    };
        //    List<Answer> answers = new List<Answer>();
        //    answers = faq.Answers;
        //    return Json(answers, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult GetByCategory(int catid)
        //{
        //    var key= db.Keywords.Where(k => k.Category.Id == catid).ToList();
        //    List<Question> questions = new List<Question>();
        //    foreach (var item in key)
        //    {
        //        questions= db.Questions.Where(q => q.Keyword.Id == item.Id).ToList();
        //    }
        //    return Json(questions,JsonRequestBehavior.AllowGet);
        //}
    }
}