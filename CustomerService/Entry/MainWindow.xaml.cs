using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Entry;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace Entry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Db db = new Db();
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                //binding Departments
                var dept = new CustViewModel
                {
                    DeptName = db.Departments.Distinct().ToList(),
                };
                combodept.ItemsSource = dept.DeptName;
                combodept.DisplayMemberPath = "Name";
                combodept.SelectedValuePath = "Id";
                //Binding Branches
                var Branches = new CustViewModel
                {
                    Branch = db.Branches.Distinct().ToList()
                };
                combobranch.ItemsSource = Branches.Branch;
                combobranch.DisplayMemberPath = "Name";
                combobranch.SelectedValuePath = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)|| combobranch.SelectedIndex==-1 || combodept.SelectedIndex==-1)
            {
                return;
            }

            try
            {
                //select id of department
                int deptid = Convert.ToInt32(lblid.Content);
                var dept = db.Departments.Where(d => d.Id == deptid).FirstOrDefault();
                //select id of branch
                int branchid = Convert.ToInt32(lblbid.Content);
                var bran = db.Branches.Where(b => b.Id == branchid).FirstOrDefault();
                //add emp in view model 
                var addemp = new Employee
                {
                    Name = txtName.Text,
                    Phone1 = txtphone1.Text,
                    Phone2 = txtphone2.Text,
                    Role = txtrole.Text,
                    Department = dept,
                    Branch = bran,
                    Photo = txtImagePath.Content.ToString(),
                };
                db.Employees.Add(addemp);
                db.SaveChanges();
                MessageBox.Show("YOU SAVE EMPLOYEE SUCCESSFULLY","SUCCESS",MessageBoxButton.OK,MessageBoxImage.Information);
                MainWindow main = new MainWindow();
                main.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void combodept_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          lblid.Content= combodept.SelectedValue;
        }

        private void combobranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblbid.Content = combobranch.SelectedValue; 
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Images (*.jpg,*.png)|*.jpg;*.png|All Files(*.*)|*.*";
            bool? result = open.ShowDialog();

            if (result == true)
            {
               txtImagePath.Content = open.FileName; // Stores Original Path in Textbox    
                ImageSource imgsource = new BitmapImage(new Uri(txtImagePath.Content.ToString())); // Just show The File In Image when we browse It
                imgemp.Source = imgsource;
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            addbranch a = new addbranch();
            a.Show();
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
