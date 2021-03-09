using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class BookKeeper : Employee, IManager
    {
        public List_of_workers Workers => throw new NotImplementedException();

        public EventHandler<SalaryEventArgs> salaryEvent; //our templated delegate

        public void GiveSalary(SalaryEventArgs args)
        {
            if (salaryEvent != null)
            {
                salaryEvent(this, args);
            }
        }

        public BookKeeper() : base()
        {

        }
        public BookKeeper(string name, string surname, string patron, DateTime birthDate, Gender gender, Nationality nat,
            EducationLevel edLevel, float mani, int ages) 
            : base(name, surname, patron, birthDate, gender, nat, edLevel, mani, ages)
        {

        }
        public void ControlWork()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
