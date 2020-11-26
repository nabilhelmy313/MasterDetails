using CustomerService.Models;
using CustomerService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerService.Controllers
{
    public class CustServController : Controller
    {
       private AppDbContext db = new AppDbContext();

        // GET: CustServ
        public ActionResult Index()
        {

            CustServViewModel country = new CustServViewModel
            {
                Country = db.Countries.ToList(),
                City = db.Cities.ToList(),
                Branch = db.Branches.ToList(),
                Employees = db.Employees.ToList()
            };
            ViewBag.con = db.Countries.ToList();
            return View(country);
        }
        public JsonResult GetCities(int id)
        {
            var cities = new CustServViewModel
            {
                City = db.Cities.Where(c => c.Country.Id == id).ToList()
            };
            List<City> cit = new List<City>();
            cit = cities.City;
            return Json(cit,JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetBranches(int id)
        {
            var branches = new CustServViewModel
            {
                Branch = db.Branches.Where(b => b.City.Id == id).ToList(),
                
            };
            List<CustServViewModel> custServs = new List<CustServViewModel>();
            List<Branch> bran = new List<Branch>();
            bran = branches.Branch;
            for (int i = 0; i < bran.Count(); i++)
            {
                custServs.Add(new CustServViewModel
                {
                    ID=bran[i].Id,
                    Name=bran[i].Name,
                    StartTime = bran[i].StartTime.ToString("hh:mm tt"),
                    EndTime = bran[i].EndTime.ToString("hh:mm tt"),
                    Address=bran[i].Address,
                    Phone1=bran[i].Phone1,
                    Phone2=bran[i].Phone2,
                    BranchNumber=bran.Count()
                });
            }
            return Json(custServs, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetEmps(int id)
        {
            CustServViewModel employee = new CustServViewModel()
            {
                Employees = db.Employees.Where(c => c.Branch.Id == id).ToList()
            };
            List<CustServViewModel> list = new List<CustServViewModel>();
            List<Employee> Emp = new List<Employee>();
            Emp = employee.Employees;
            for (int i = 0; i <Emp.Count() ; i++)
            {
                list.Add(new CustServViewModel
                {
                    EmpName = Emp[i].Name,
                    EmpPhone1=Emp[i].Phone1,
                    EmpPhone2=Emp[i].Phone2,
                    EmpPhoto=Emp[i].Photo,
                    EmpRole=Emp[i].Role
                });
            }
            return Json(list,JsonRequestBehavior.AllowGet);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}