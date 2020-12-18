using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace CustomerService.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string TextAr { get; set; }
        public string Photo { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsUpdated { get; set; }
        public Question Question { get; set; }

    }
}