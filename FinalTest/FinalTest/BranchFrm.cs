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
    public partial class BranchFrm : DevExpress.XtraEditors.XtraForm
    {
        custservEntities db = new custservEntities();

        public BranchFrm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void BranchFrm_Load(object sender, EventArgs e)
        {

        }
        void RefreshGrid()
        {
            gridControl1.DataSource = db.Branches.ToList();
            countryBindingSource.DataSource = db.Countries.ToList();
            cityBindingSource.DataSource = db.Cities.ToList();
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var look = sender as LookUpEdit;
            var row = look.GetSelectedDataRow() as Country;
            var id = row.Id;
            cityBindingSource.DataSource = db.Cities.Where(i => i.Country_Id == id).ToList();
        }

        private void SAVE(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Branch branch= gridView1.GetFocusedRow() as Branch;
            if (branch != null)
            {
                branchBindingSource.DataSource = branch;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdTextEdit.Text);
            if (db.Branches.Where(i => i.Id == id).Any())
            {
                Branch branch = branchBindingSource.Current as Branch;
                db.Branches.AddOrUpdate(branch);
                db.SaveChanges();
                RefreshGrid();
            }
            else if (db.Branches.Where(i => i.Id != id).Any())
            {
                Branch branch = new Branch();
                branch.Name = NameTextEdit.Text;
                branch.Address = AddressTextEdit.Text;
                branch.Phone1 = Phone1TextEdit.Text;
                branch.Phone2 = Phone2TextEdit.Text;
                branch.StartTime =DateTime.Parse(StartTimeDateEdit.EditValue.ToString());
                branch.EndTime = DateTime.Parse(EndTimeDateEdit.EditValue.ToString());
                branch.City_Id = int.Parse(CityLookUpEdit.EditValue.ToString()) ;
                db.Branches.Add(branch);
                db.SaveChanges();
                RefreshGrid();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Branch branch =gridView1.GetFocusedRow() as Branch;
            if (branch!=null)
            {
                db.Branches.Remove(branch);
                db.SaveChanges();
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            CountryFrm country = new CountryFrm();
            country.Show();
            country.FormClosed += Country_FormClosed;
            Hide();
        }

        private void Country_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            CityFrm city = new CityFrm();
            city.Show();
            city.FormClosed += City_FormClosed;
            Hide();
        }

        private void City_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            BranchFrm branch = new BranchFrm();
            branch.Show();
            branch.FormClosed += Branch_FormClosed;
            Hide();
        }

        private void Branch_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            IdTextEdit.Text ="0";
            NameTextEdit.Text = "";
            Phone1TextEdit.Text = "";
            Phone2TextEdit.Text="";
            AddressTextEdit.Text = "";
            CityLookUpEdit.EditValue = "";
        }

        private void gridView1_LostFocus(object sender, EventArgs e)
        {
            IdTextEdit.Text = "0";
            NameTextEdit.Text = "";
            Phone1TextEdit.Text = "";
            Phone2TextEdit.Text = "";
            AddressTextEdit.Text = "";
            CityLookUpEdit.EditValue = ""; IdTextEdit.Text = "0";
            NameTextEdit.Text = "";
            Phone1TextEdit.Text = "";
            Phone2TextEdit.Text = "";
            AddressTextEdit.Text = "";
            CityLookUpEdit.EditValue = "";
        }
    }
}