using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GB_Kabalkin_CSharp_Level2
{
    public class Company: INotifyPropertyChanged
    {
        #region Variables
        private string companyName;
        public string CompanyName { get { return companyName; } }

        ObservableCollection<Department> departments;        
        public ObservableCollection<Department> Departments { get { return departments; } }

        Random random = new Random();
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;



        public Company(string name)
        {

            this.companyName = name;
            departments = new ObservableCollection<Department>() { new Department("None") };
        }

        #region Metods
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
                departments.Add(new Department($"Department 00{Department.counter}"));
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Departments)));
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
        #endregion


    }
}
