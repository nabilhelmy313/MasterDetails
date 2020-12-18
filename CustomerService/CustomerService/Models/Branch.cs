using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerService.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string Address { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public City City { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}