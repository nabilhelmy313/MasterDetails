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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();

        public XtraForm1()
        {
            InitializeComponent();
            keywordBindingSource.DataSource = db.Keywords.Local.ToBindingList();
            db.Keywords.Load();
            categoryBindingSource.DataSource = db.Categories.ToList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            keywordBindingSource.AddNew();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}