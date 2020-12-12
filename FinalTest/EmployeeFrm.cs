using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class EmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public EmployeeFrm()
        {
            InitializeComponent();
            employeeBindingSource.DataSource = db.Employees.Local.ToBindingList();
            db.Employees.Load();
            branchBindingSource.DataSource = db.Branches.ToList();
            departmentBindingSource.DataSource = db.Departments.ToList();
        }

        private void EmployeeFrm_Load(object sender, EventArgs e)
        {

        }
    }
}