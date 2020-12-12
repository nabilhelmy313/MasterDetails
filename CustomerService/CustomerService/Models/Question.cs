using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace CustomerService.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateTime{ get; set; }
        public bool IsUpdated { get; set; }
        public Keyword Keyword { get; set; }
        public ICollection<Answer> Answers{ get; set; }
    }
}