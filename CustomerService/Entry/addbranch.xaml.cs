using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Entry
{
    /// <summary>
    /// Interaction logic for addbranch.xaml
    /// </summary>
    public partial class addbranch : Window
    {
        Db db = new Db();
        public addbranch()
        {
            InitializeComponent();
            try
            {
                //binding country
                var country = new CustViewModel
                {
                    Country = db.Countries.Distinct().ToList(),
                };
                combocountry.ItemsSource = country.Country;
                combocountry.DisplayMemberPath = "Name";
                combocountry.SelectedValuePath = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9-:]+").IsMatch(e.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id =Convert.ToInt32(lblcityid.Content);
            var city = db.Cities.Where(c => c.Id == id).FirstOrDefault();
            DateTime d1 =DateTime.Parse(combostart.SelectedItem.ToString());
            DateTime d2 = DateTime.Parse(comboend.SelectedItem.ToString());
            var cust = new Branch
            {
                Name = txtname.Text,
                Address = txtaddress.Text,
                StartTime =d1,
                EndTime=d2,
                City=city
                
            };
        }

        private void combocountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblcontryid.Content = combocountry.SelectedValue;
            int id = Convert.ToInt32(lblcontryid.Content);
            try
            {
                //binding country
                var city = new CustViewModel
                {
                    City = db.Cities.Where(c=>c.Country_Id==id).Distinct().ToList(),
                };
                combocity.ItemsSource = city.City;
                combocity.DisplayMemberPath = "Name";
                combocity.SelectedValuePath = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combocity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblcityid.Content = combocity.SelectedValue;
        }
    }
}
