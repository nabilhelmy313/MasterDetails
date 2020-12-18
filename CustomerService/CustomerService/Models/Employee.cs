using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerService.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Photo { get; set; }
        public string Role { get; set; }
        public Branch Branch { get; set; }
        public Department Department { get; set; }

    }
}