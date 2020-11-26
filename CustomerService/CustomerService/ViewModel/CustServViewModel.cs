using CustomerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerService.ViewModel
{
    public class CustServViewModel
    {
        public List<Country> Country{ get; set; }
        public List<City> City { get; set; }
        public List<Branch> Branch { get; set; }
        public List<Employee> Employees { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int BranchNumber { get; set; }
        public int EmpNumber { get; set; }
        public int CustNumber { get; set; }
        public string EmpName { get; set; }
        public string EmpPhone1 { get; internal set; }
        public string EmpPhone2 { get; internal set; }
        public string EmpPhoto { get; internal set; }
        public string EmpRole { get; internal set; }
    }
}