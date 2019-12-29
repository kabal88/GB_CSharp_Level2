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
using GB_Kabalkin_CSharp_Level2.Classes;
using System.Collections.ObjectModel;

namespace GB_Kabalkin_CSharp_Level2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IViewCompany
    {
        //private Company google;
        //private Department departmentSelected;
        //private Employee employeeSelected;
        //private Random random = new Random();

        Presenter p;
        Window2StaffEditor w2 ;

        #region IViewCompany

        string IViewCompany.CompanyName
        {
            get => LableText.Text;
            set => LableText.Text = value;
        }

        ObservableCollection<Department> IViewCompany.Departments
        {
             get
            {
               return null;
            }
            set
            {

                DepartamentsListBox.ItemsSource = value;
            }

        }

        ObservableCollection<Employee> IViewCompany.Employees
        {
            get
            {
                return null;
            }
            set
            {

                StafflistBox.ItemsSource = value;
            }

        }

        public Department DepartmentSelected
        {
            get
            {
                return DepartamentsListBox.SelectedItem as Department;
            }
            set => throw new NotImplementedException();
        }

        public Employee EmployeeSelected
        {
            get => StafflistBox.SelectedItem as Employee;
            set => EmployeeSelected=value;
        }

        public string TextInfo
        {
            get => CompanyInfoTextBox.Text;
            set => CompanyInfoTextBox.Text = value;
        }

        public void ShowEmployeeEditWindow()
        {
            w2 = new Window2StaffEditor(p);
            w2.ShowDialog();
        }


        #endregion

        public MainWindow()
        {

            InitializeComponent();

            p = new Presenter(this);
            p.LoadCompany();

            DepartamentsListBox.SelectionChanged += (s, e) => p.ShowSelectedDepartament();
            StafflistBox.SelectionChanged += (s, e) => p.ShowSelectedEmployeeInfo();
            AddDepBtn.Click+=(s,e) => p.AddDepatrament();
            AddStaffBtn.Click += (s, e) => p.AddEmployee();
            DelStaffBtn.Click += (s, e) => p.DelEmployee();
            EditStaffBtn.Click += (s, e) => p.EditEmployee();
            

        }

        


       


    }
}
