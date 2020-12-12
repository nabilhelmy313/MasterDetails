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
    public partial class BranchFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();

        public BranchFrm()
        {
            InitializeComponent();
            branchBindingSource.DataSource = db.Branches.Local.ToBindingList();
            db.Branches.Load();
            cityBindingSource.DataSource = db.Cities.ToList();
        }

        private void BranchFrm_Load(object sender, EventArgs e)
        {

        }
    }
}