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
    public partial class CityFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public CityFrm()
        {
            InitializeComponent();
            cityBindingSource.DataSource = db.Cities.Local.ToBindingList();
            countryBindingSource.DataSource = db.Countries.ToList();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            using (db)
            {
                BindingSource BindingSource = new BindingSource();
                BindingSource.DataSource = typeof(City);
                BindingSource.AddNew();

                dataLayoutControl1.AutoRetrieveFields = true;
                dataLayoutControl1.DataSource =BindingSource;
            }
        }
    }
}