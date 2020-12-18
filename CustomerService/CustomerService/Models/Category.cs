using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerService.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public ICollection<Keyword> Keywords { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}