using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2.Classes
{
    public interface IViewCompany
    {

        string CompanyName { get; set; }
        ObservableCollection<Department> Departments { get; set; }
        ObservableCollection<Employee> Employees { get; set; }
        Department DepartmentSelected { get; set; }
        Employee EmployeeSelected { get; set; }
        string TextInfo { get; set; }

        void ShowEmployeeEditWindow();

    }
}
