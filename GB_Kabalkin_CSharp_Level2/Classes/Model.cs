using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Kabalkin_CSharp_Level2.Classes
{
    class Model
    {
        private Company company;
        public Company Company => this.company;


        // создаем компанию
        public void CreateCompany()
        {
            Random random = new Random();
            company = new Company("Yandex");
            company.HiringStaff(random.Next(1, 5), (Position)random.Next(0, 3));
            company.HiringStaff(random.Next(1, 5), (Position)random.Next(0, 3));
            company.HiringStaff(random.Next(1, 5), (Position)random.Next(0, 3));
            company.CreatingDepartaments(2);
        }

        
    }
}
