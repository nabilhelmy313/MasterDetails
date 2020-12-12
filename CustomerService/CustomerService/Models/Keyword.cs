using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerService.Models
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public int Counter { get; set; }
        public Category Category { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}