using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2
{
    public class Employee
    {
        private string name;
        public string Name { get { return name; }set { name = value; } }

        private double salary;
        public double Salary { get { return salary; }set { salary = value; } }

        private string departamentName;
        public string DepartamentName { get { return departamentName; } set { departamentName = value; } }

        private Position position;
        public Position Position { get { return position; } set { position = value; } }

        public static int ID;
        public readonly int id; 

        public Employee(string name, double salary, Position position, string departamentName = "None") {

            this.name = name;
            this.salary = salary;
            this.position = position;
            this.departamentName = departamentName;
            id = ID;
            ID++;
        }

        public override string ToString()
        {
            
                return $"{Name}";
            
        }

        public string PrintInfo(bool vertical)
        {
            if (vertical)
            {
                if (departamentName == "None")
                {

                    return $"Name: {Name}, Salary: {Salary}$, Position: {position}";
                }
                else
                {
                    return $"Name: {Name}, Departament: {departamentName}, Salary: {Salary}$, Position: {position}";
                }
            }
            else {
                if (departamentName == "None")
                {

                    return $"Name: {Name} \n Salary: {Salary}$\n Position: {position}";
                }
                else
                {
                    return $"Name: {Name}\n Departament: {departamentName} \n Salary: {Salary}$ \n Position: {position}";
                }

            }

        }


    }
}
