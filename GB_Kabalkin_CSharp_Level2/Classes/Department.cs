using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2
{
    public class Department
    {
        #region Variables
        private string name;
        public string Name { get { return name; } }
        private ObservableCollection<Employee> staff;
        public ObservableCollection<Employee> Staff { get { return staff; } }
        public static int counter;
        public readonly int ID;
        #endregion

        public Department(string name)
        {
            
            this.name = name;
            staff = new ObservableCollection<Employee>();
            this.ID = counter;
            counter++;
            
        }

        public Department(string name, ObservableCollection<Employee> staff):this(name)
        {

            this.staff = staff;

        }

        #region Metods
        public void AddStaff(Employee employee)
        {
            staff.Add(employee);
            employee.DepartamentName = Name;
        }

        public void AddStaff(ref Employee employee)
        {
            staff.Add(employee);
            employee.DepartamentName = Name;
        }

        public void DeleteStaff(ref Employee employee)
        {
            for (int i = 0; i < staff.Count; i++)
            {
                if (staff[i].id == employee.id)
                {
                    staff.RemoveAt(i);
                    employee.DepartamentName = "None";
                }
            }
                        
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
