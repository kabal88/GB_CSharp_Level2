using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using GB_Kabalkin_CSharp_Level2.Classes;

namespace GB_Kabalkin_CSharp_Level2
{
    /// <summary>
    /// Interaction logic for Window2StaffEditor.xaml
    /// </summary>
    public partial class Window2StaffEditor : Window,IViewEmployee
    {

        Presenter p;

        #region IViewEmployee

        public string EmplName
        {
            get => NameTextBox.Text;
            set => NameTextBox.Text = value;
        }

        public ObservableCollection<Department> Departments
        {
            get => DepartamentComboBox.ItemsSource as ObservableCollection<Department>;
            set => DepartamentComboBox.ItemsSource = value;
        }

        public Department DepartmentSelected
        {
            get
            {
                return DepartamentComboBox.SelectedItem as Department;
            }
            set
            {
                DepartamentComboBox.SelectedItem = value;
            }
        }


        public ObservableCollection<Position> Position
        {
            get => PositionComboBox.ItemsSource as ObservableCollection<Position>;
            set => PositionComboBox.ItemsSource = value;
        }

        public Position PositionSelected
        {
            get
            {
                if (PositionComboBox.SelectedIndex == -1) return 0;
                else return (Position)PositionComboBox.SelectedIndex;
            }
            set
            {
                PositionComboBox.SelectedItem = value;
            }
        }

        public string Salary
        {
            get => SalaryTextBox.Text;
            set => SalaryTextBox.Text=value;
        }
        #endregion

        public Window2StaffEditor()
        {
            InitializeComponent();
        }

        public Window2StaffEditor(Presenter presenter) : this()
        {
            p = presenter;
            if (p != null)
            {
                p.InitViewEmployee(this);
                p.LoadEmployeeEdition();

                SaveBtn.Click += (s, e) => p.SaveBtnClick();
                SaveBtn.Click += (s, e) => this.Close();
            }
        }
    }
}
