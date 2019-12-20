using System;
using System.Collections.Generic;
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

namespace GB_Kabalkin_CSharp_Level2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Company google;
        private Department departmentSelected;
        private Employee employeeSelected;
        private Random random = new Random();

        public MainWindow()
        {

            InitializeComponent();
            CreatingGoogle();
            InitializeGoogle();

        }

        public void CreatingGoogle()
        {
            Random random = new Random();
            google = new Company("Google");
            google.HiringStaff(random.Next(1, 5), (Position)random.Next(0, 3));
            google.HiringStaff(random.Next(1, 5), (Position)random.Next(0, 3));
            google.HiringStaff(random.Next(1, 5), (Position)random.Next(0, 3));
            google.CreatingDepartaments(2);
            // PrintText(google);
        }

        public void PrintText(Company company)
        {
            Console.WriteLine(company.ToString());

        }

        public void InitializeGoogle()
        {

            LableText.Text = google.Name;
            CompanyInfoTextBox.Text = google.ToString();

            RefreshDepartamentListBox();


        }


        private void DepartamentSelection(object sender, SelectionChangedEventArgs e)
        {
            employeeSelected = null;
            StafflistBox.Items.Clear();
            string departName = (sender as ListBox).SelectedItem.ToString();

            foreach (Department department in google.Departments)
            {
                if (department.Name == departName)
                {
                    departmentSelected = department;
                    RefreshStaffListBox();
                }
            }
            
        }

        private void AddBtnClick(object sender, RoutedEventArgs e)
        {
            if (departmentSelected == null) return;

            departmentSelected.AddStaff(new Employee($"Man00{Employee.ID}", random.Next(1000, 2000), Position.worker));
            RefreshStaffListBox();

        }

        void RefreshDepartamentListBox()
        {
            DepartamentsListBox.Items.Clear();
            foreach (var item in google.Departments)
            {
                DepartamentsListBox.Items.Add(item);
            }

        }

        private void RefreshStaffListBox() {

            StafflistBox.Items.Clear();
            foreach (Employee employee in departmentSelected.Staff)
            {
                StafflistBox.Items.Add(employee);
            }
        }

        private void EditBtnClick(object sender, RoutedEventArgs e)
        {
            if (StafflistBox.SelectedItem == null) return;
            if (google.Departments==null) return;
            new Window2StaffEditor(employeeSelected, google.Departments).ShowDialog();
        }

        private void StaffSelection(object sender, SelectionChangedEventArgs e)
        {
            if (departmentSelected == null) return;
            
            if ((sender as ListBox).SelectedItem == null) return;

            string staffName = (sender as ListBox).SelectedItem.ToString();
            

            foreach (Employee employee in departmentSelected.Staff)
            {
                if (employee.Name == staffName)
                {
                    employeeSelected = employee;
                }
            }

        }

        private void DelBtnClick(object sender, RoutedEventArgs e)
        {

            if (departmentSelected == null) return;
            if (employeeSelected == null) return;

            for (int i = 0; i < departmentSelected.Staff.Count; i++)
            {
                if (employeeSelected.id == departmentSelected.Staff[i].id)
                {
                    departmentSelected.Staff.RemoveAt(i);
                    employeeSelected = null;
                    RefreshStaffListBox();
                }

            }

        }

        private void AddDepBtnClick(object sender, RoutedEventArgs e)
        {
            google.CreatingDepartaments(1);
            RefreshDepartamentListBox();
        }
    }
}
