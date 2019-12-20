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
using System.Windows.Shapes;

namespace GB_Kabalkin_CSharp_Level2
{
    /// <summary>
    /// Interaction logic for Window2StaffEditor.xaml
    /// </summary>
    public partial class Window2StaffEditor : Window
    {
        Employee staffForEdit;
        List<Department> departments;
        Department depSelect;

        public Window2StaffEditor()
        {
            InitializeComponent();
        }

        public Window2StaffEditor(Employee employee, List<Department> departments) :this()
        {
            staffForEdit = employee;
            this.departments = departments;
            InitEmployee();
        }

        void InitEmployee()
        {
            if (staffForEdit == null) {

                NameTextBox.Text = "None";
                PositionComboBox.Text = "None";
                SalaryTextBox.Text = "None";

                return;
            }
            

            NameTextBox.Text = staffForEdit.Name;

            foreach (Position position in Enum.GetValues(typeof(Position)))
            {
                PositionComboBox.Items.Add(position);
                if (staffForEdit.Position == position)
                {
                    PositionComboBox.SelectedIndex = (int)position;
                }
            }
            if (departments != null)
            {

                for (int i = 0; i < departments.Count; i++)
                {
                    DepartamentComboBox.Items.Add(departments[i]);
                    if (staffForEdit.DepartamentName == departments[i].Name)
                    {
                        DepartamentComboBox.SelectedIndex = i;
                        depSelect = departments[i];
                    }
                }
              
            }
            SalaryTextBox.Text = staffForEdit.Salary.ToString();
            

        }

        private void OnClickCancel(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            if (staffForEdit == null)
            {
                this.Close();
                return;
            }
            staffForEdit.Name = NameTextBox.Text;
            staffForEdit.Position = (Position)PositionComboBox.SelectedItem;
            Department depTemp = ((Department)DepartamentComboBox.SelectedItem);
            staffForEdit.DepartamentName = depTemp.Name;
            depTemp.AddStaff(staffForEdit);
            depSelect.DeleteStaff(ref staffForEdit);
            if (double.TryParse(SalaryTextBox.Text, out double result)) staffForEdit.Salary = result;
            this.Close();
        }
    }
}
