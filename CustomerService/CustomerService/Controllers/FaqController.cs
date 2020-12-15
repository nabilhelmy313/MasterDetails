using CustomerService.Models;
using CustomerService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerService.Controllers
{
    public class FaqController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Faq
        public ActionResult Index(string search="nasfd")
        {
            if (search == null)
            {
                FAQViewModel fAQ = new FAQViewModel
                {
                    Categories = db.Categories.ToList(),
                    Questions = db.Questions.ToList(),
                    Keywords = db.Keywords.ToList(),
                };
                return View(fAQ);
            }
            else
            {
                FAQViewModel fAQ = new FAQViewModel
                {
                    Categories = db.Categories.ToList(),
                    Questions = db.Questions.Where(s=>s.Text.Contains(search)||search==null).ToList(),
                    Keywords = db.Keywords.ToList(),
                };
                return View(fAQ);
            }
            
        }
        public JsonResult GetQuestionbykey(int id)
        {
            var faq = new FAQViewModel
            {
                Questions = db.Questions.Where(k => k.Keyword.Id == id).ToList()
            };
            List<Question> questions = new List<Question>();
            questions = faq.Questions;
            return Json(questions,JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetAnswer(int id)
        {
            var faq = new FAQViewModel
            {
               Answers  = db.Answers.Where(k => k.Question.Id == id).ToList()
            };
            List<Answer> answers = new List<Answer>();
            answers = faq.Answers;
            return Json(answers, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetByCategory(int catid)
        {
            var key= db.Keywords.Where(k => k.Category.Id == catid).ToList();
            List<Question> questions = new List<Question>();
            foreach (var item in key)
            {
                questions= db.Questions.Where(q => q.Keyword.Id == item.Id).ToList();
            }
            return Json(questions,JsonRequestBehavior.AllowGet);
        }
    }
}