using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2
{
    public class Company
    {
        private string name;
        public string Name { get { return name; } }
        //List<Employee> staffList;
        List<Department> departments;
        //public List<Employee> StaffList { get { return staffList; } }
        public List<Department> Departments { get { return departments; } }
        Random random=new Random();

        public Company(string name)
        {

            this.name = name;
            departments = new List<Department>() { new Department("None") };
        }

        public void HiringStaff(int qty, Position position)
        {

            if (qty <= 0) { Console.WriteLine($"Error: qty ({qty}) value is not correct"); }

            for (int i = 0; i < qty; i++)
            {
                Departments[0].AddStaff(new Employee($"Man00{Employee.ID}", random.Next(1000, 2000), position));
            }
        }

        public void CreatingDepartaments(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                departments.Add(new Department($"Department 00{Department.ID}"));
            }
        }

        public void MoveStaffToDepartament(ref Employee employee,ref Department toDepartment, ref Department fromDepartment)
        {

            AddStaffToDepartament(ref employee,ref toDepartment);
            RemoveStaffToDepartament(ref employee, ref fromDepartment);

        }

        public void AddStaffToDepartament(ref Employee employee,ref Department department)
        {
            department.AddStaff(ref employee);
        }
        public void RemoveStaffToDepartament(ref Employee employee, ref Department department) {

            department.DeleteStaff(ref employee);

        }



        public override string ToString()
        {
            string result="";

            result += "Company structure: \n";
            for (int i = 0; i < departments.Count; i++)
            {
                result += $"{i + 1}. {departments[i].ToString()}:\n";
                for (int j = 0; j < departments[i].Staff.Count; j++)
                {

                    result += $"\t{j + 1}. {departments[i].Staff[j].PrintInfo(true)}\n";

                }

            }
            return result;
        }



    }
}
