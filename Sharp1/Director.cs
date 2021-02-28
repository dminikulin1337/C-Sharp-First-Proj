using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Director : Employee
    {
        private Company _company;//company which is owned by director

        private Company Company { get { return _company; } }
        public Director() : base()
        {
            _company = Company;
        }
        public Director(string name, string surname, string patron,
                            DateTime birth, Gender gen, Nationality nat, EducationLevel edlevel,
                            float mani, int ages, Company company)
            : base(name, surname, patron, birth, gen, nat, edlevel, mani, ages)
        {
            _company = company;
        }
        public override string ToString()
        {
            return base.ToString() + 
                $"\n\tCompany owned: {Company}";
        }
    }
}
