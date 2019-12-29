using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2.Classes
{
    public class Presenter
    {

        private IViewCompany viewCompany;
        private IViewEmployee viewEmployee;
        private Model model;
        private Random random = new Random();



        public Presenter(IViewCompany ViewCompany)
        {
            this.viewCompany = ViewCompany;
            model = new Model();
        }

        #region Main Widow

        public void LoadCompany()
        {
            model.CreateCompany();
            viewCompany.CompanyName = model.Company.CompanyName;
            viewCompany.Departments = model.Company.Departments;
        }

        public void AddDepatrament()
        {

            model.Company.CreatingDepartaments(1);
            viewCompany.Departments = model.Company.Departments;

        }

        public void ShowSelectedDepartament() {

            if (viewCompany.DepartmentSelected == null)
            {
                viewCompany.TextInfo = $"nothing selected";
                return;
            }

            viewCompany.Employees = viewCompany.DepartmentSelected.Staff;
            viewCompany.TextInfo = $"{viewCompany.DepartmentSelected.Name} - selected. \nEmployees QTY: {viewCompany.DepartmentSelected.Staff.Count.ToString()}";

        }

        public void AddEmployee()
        {
            if (viewCompany.DepartmentSelected == null) return;

            viewCompany.DepartmentSelected.AddStaff(new Employee($"Man00{Employee.ID}", random.Next(1000, 2000), Position.worker));

        }

        public void DelEmployee()
        {
            if (viewCompany.DepartmentSelected == null) return;
            if (viewCompany.EmployeeSelected == null) return;

            for (int i = 0; i < viewCompany.DepartmentSelected.Staff.Count; i++)
            {
                if (viewCompany.EmployeeSelected.id == viewCompany.DepartmentSelected.Staff[i].id)
                {
                    viewCompany.DepartmentSelected.Staff.RemoveAt(i);
                    return;
                }
            }
        }

        public void EditEmployee()
        {
            if (viewCompany.DepartmentSelected == null) return;
            if (viewCompany.EmployeeSelected == null) return;

            viewCompany.ShowEmployeeEditWindow();
        }

        #endregion


        #region Edit Employee Window

        public void InitViewEmployee(IViewEmployee viewEmployee)
        {
            this.viewEmployee = viewEmployee;
        }

        public void ShowSelectedEmployeeInfo()
        {
            if (viewCompany.EmployeeSelected == null) return;
            viewCompany.TextInfo = viewCompany.EmployeeSelected.PrintInfo(true);
        }

        public void LoadEmployeeEdition()
        {
            if (viewCompany.EmployeeSelected == null) {

                viewEmployee.EmplName = "None";
                viewEmployee.Position = null;
                viewEmployee.Departments = null;
                viewEmployee.Salary = "None";
                

                return;
            }
            viewEmployee.EmplName = viewCompany.EmployeeSelected.EmployeeName;
            viewEmployee.Position = GetPositions();
            viewEmployee.Departments = model.Company.Departments;
            viewEmployee.Salary = viewCompany.EmployeeSelected.Salary.ToString();

            foreach (Department item in model.Company.Departments)
            {
                if (item.Name == viewCompany.EmployeeSelected.DepartamentName)
                    viewEmployee.DepartmentSelected = item;

            }

            viewEmployee.PositionSelected = viewCompany.EmployeeSelected.Position;
            
        }

        public void SaveBtnClick()
        {
            if (viewCompany.EmployeeSelected == null) return;

            viewCompany.EmployeeSelected.EmployeeName = viewEmployee.EmplName;
            viewCompany.EmployeeSelected.Position = viewEmployee.PositionSelected;

            if (double.TryParse(viewEmployee.Salary, out double result)) viewCompany.EmployeeSelected.Salary = result;

            Department depTemp = viewEmployee.DepartmentSelected;
            depTemp.AddStaff(viewCompany.EmployeeSelected);
            DelEmployee();

            
            
        }


        #endregion




        private ObservableCollection<Position> GetPositions()
        {
            ObservableCollection<Position> col = new ObservableCollection<Position>();
            foreach (Position position in Enum.GetValues(typeof(Position)))
            {
                col.Add(position);                
            }

            return col;
        }


    }
}
