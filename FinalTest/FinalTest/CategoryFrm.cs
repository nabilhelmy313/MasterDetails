using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FinalTest
{
    public partial class CategoryFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        custservEntities db = new custservEntities();
        public CategoryFrm()
        {
            InitializeComponent();
            RefreshGrid();
        }
        void RefreshGrid()
        {
            gridControl1.DataSource = db.Categories.Local.ToBindingList();
            db.Categories.Load();
        }
        private void CategoryFrm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}