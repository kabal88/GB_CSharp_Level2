using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2
{
    public class Department
    {
        private string name;
        public string Name { get { return name; } }
        private List<Employee> staff;
        public List<Employee> Staff { get { return staff; } }
        public static int ID;

        public Department(string name)
        {

            this.name = name;
            staff = new List<Employee>();
            ID++;

        }

        public Department(string name,List<Employee> staff):this(name)
        {

            this.staff = staff;

        }

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

        public override string ToString()
        {
            return Name;
        }
    }
}
