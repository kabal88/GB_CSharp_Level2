using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2
{
    public class Employee
    {
        #region Variables
        private string employeeName;
        public string EmployeeName { get { return employeeName; }set { employeeName = value; } }

        private double salary;
        public double Salary { get { return salary; }set { salary = value; } }

        private string departamentName;
        public string DepartamentName { get { return departamentName; } set { departamentName = value; } }

        private Position position;
        public Position Position { get { return position; } set { position = value; } }

        public static int ID;
        public readonly int id;
        #endregion


        public Employee(string name, double salary, Position position, string departamentName = "None") {

            this.employeeName = name;
            this.salary = salary;
            this.position = position;
            this.departamentName = departamentName;
            id = ID;
            ID++;
        }

        public override string ToString()
        {
            
                return $"{EmployeeName}";
            
        }

        #region Metods
        public string PrintInfo(bool vertical=false)
        {
            if (vertical)
            {
                if (departamentName == "None")
                {
                    return $"Name: {EmployeeName} \nSalary: {Salary}$\nPosition: {position}";
                }
                else
                {
                    return $"Name: {EmployeeName}\nDepartament: {departamentName} \nSalary: {Salary}$ \nPosition: {position}";
                }
                
            }
            else {
                if (departamentName == "None")
                {
                    return $"Name: {EmployeeName}, Salary: {Salary}$, Position: {position}";
                }
                else
                {
                    return $"Name: {EmployeeName}, Departament: {departamentName}, Salary: {Salary}$, Position: {position}";
                }

            }

        }
        #endregion

    }
}
