using CustomerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerService.ViewModel
{
    public class FAQViewModel
    {
        public List<Category> Categories{ get; set; }
        public List<Keyword> Keywords { get; set; }
        public List<Question> Questions { get; set; }
        public List<string> Answers { get; set; }
        public int CatId { get; set; }
        public string CatNAme { get; set; }
        public string KeyWord { get; set; }
        public int Counter { get; set; }
        public int Qid { get; set; }
        public string QName { get; set; }
        public DateTime QDate { get; set; }
        public bool QIsUpdate { get; set; }
        public string AText { get; set; }
        public DateTime ADate { get; set; }
        public bool AIsUpdated { get; set; }


    }
    public class Ans
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Photo { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsUpdated { get; set; }
    }
}