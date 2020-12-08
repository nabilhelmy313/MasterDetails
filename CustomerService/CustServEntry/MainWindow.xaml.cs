using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustServEntry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        custservEntities db = new custservEntities();
        BindingList<AllEmployee> bs;
        public MainWindow()
        {
            InitializeComponent();
            GetEmp();
        }
        void GetEmp()
        {
             bs = new BindingList<AllEmployee>(db.AllEmployees.ToList());
            dg.ItemsSource = bs;
            
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            AllEmployee VM = dg.SelectedItem as AllEmployee;
            if (VM != null)
            {
                VM.Id =Convert.ToInt32(txtid.Text);
                VM.Name = txtName.Text;
                VM.Phone1 = txtphone1.Text;
                VM.Phone2 = txtphone2.Text;
                VM.Role = txtrole.Text;
                VM.BranchName = combobranch.Text;
                
                VM.DepartmentName = combodept.Text;
                btndelete.IsEnabled = true;
                btnupdate.IsEnabled = true;
                btnadd.IsEnabled = false;
                db.SaveChanges();
                int u = bs.Count;
            }
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void combodept_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void combobranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnemp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataGrid dg = sender as DataGrid;
                AllEmployee VM = dg.SelectedItem as AllEmployee;
                if (VM != null)
                {
                    txtid.Text = VM.Id.ToString();
                    txtName.Text = VM.Name;
                    txtphone1.Text = VM.Phone1;
                    txtphone2.Text = VM.Phone2;
                    txtrole.Text = VM.Role;
                    combobranch.Text = VM.BranchName;
                    combodept.Text = VM.DepartmentName;
                    btndelete.IsEnabled = true;
                    btnupdate.IsEnabled = true;
                    btnadd.IsEnabled = false;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
