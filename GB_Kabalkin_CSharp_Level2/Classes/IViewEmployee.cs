using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2.Classes
{
    public interface IViewEmployee
    {
        string EmplName { get; set; }
        ObservableCollection<Position> Position { get; set; }
        ObservableCollection<Department> Departments { get; set; }
        Department DepartmentSelected { get; set; }
        Position PositionSelected { get; set; }
        string Salary { get; set; }
    }
}
