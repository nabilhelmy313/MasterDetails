using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class CountryFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();
        public CountryFrm()
        {
            InitializeComponent();
            gridControl1.DataSource= db.Countries.ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CityFrm frm = new CityFrm();
            frm.Show();
            Hide();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            using (db)
            {
                Country c = countryBindingSource.Current as Country;
                db.Countries.AddOrUpdate(c);
                db.SaveChanges();
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            countryBindingSource.DataSource = new Country();
            }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            BranchFrm frm = new BranchFrm();
            frm.Show();
            Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            EmployeeFrm employee = new EmployeeFrm();
            employee.Show();
            Hide();
        }
    }
}