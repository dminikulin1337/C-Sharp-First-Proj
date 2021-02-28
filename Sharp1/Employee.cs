using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    abstract class Employee : Human
    {
        public EducationLevel eduLVL;
        private float _salary;
        private int _age_of_work;
        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 0.0f && value < float.MaxValue)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentException("Значение зарплаты не соответсвует норме, заданой Гражданским кодексом Украины.");
                }
            }
        }
        public int Age_of_Work
        {
            get 
            {
                return _age_of_work;
            }
            set
            {
                if (value >= 0 && value <= 30) // человек может проработать 30 лет максимум, после этого он выходит на пенсию
                {
                    _age_of_work = value;
                }
                else
                {
                    throw new ArgumentException("Сотрудник либо на пенсии, либо еще не устроился");
                }
            }
        }
        public Employee() : base()
        {
            Salary = default;
            Age_of_Work = default;
        }
        public Employee(string name, string surname, string patron, 
                            DateTime birth, Gender gen, Nationality nat, EducationLevel edlevel, 
                            float mani, int ages)
            : base(name, surname, patron, birth, gen, nat)
        {
            this.eduLVL = edlevel;
            Salary = mani;
            Age_of_Work = ages;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Education level: {eduLVL}; " +
                $"\n\tSalary: {Salary}; " +
                $"\n\tAge of work: {Age_of_Work};";
        }
        public new void print()
        {
            //new method which erases base class method            
            base.print();
            Console.WriteLine(this);
        }
    }
}
