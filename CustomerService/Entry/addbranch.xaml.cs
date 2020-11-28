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
            try
            {
                int id = Convert.ToInt32(lblcityid.Content);
                string time1 = combostart.Text.ToString();
                string date1 = DateTime.Now.Date.ToString("d");
                DateTime datetime1 = DateTime.Parse(date1 + " " + time1);

                string time2 = comboend.Text.ToString();
                string date2 = DateTime.Now.Date.ToString("d");
                DateTime datetime2 = DateTime.Parse(date2 + " " + time2);

                var city = db.Cities.Where(c => c.Id == id).FirstOrDefault();

                var bran = new Branch
                {
                    Name = txtname.Text,
                    Address = txtaddress.Text,
                    StartTime = datetime1,
                    EndTime = datetime2,
                    City = city

                };
                db.Branches.Add(bran);
                db.SaveChanges();
                MessageBox.Show("YOU SAVE Branch SUCCESSFULLY", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
                addbranch addbranch = new addbranch();
                addbranch.Show();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            addbranch addbranch = new addbranch();
            addbranch.Show();
            Close();
        }

        private void btnemp_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
