using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public delegate void ExamDelegate(string task);
    sealed class Teacher : Employee //запечатаный класс - запрещает насследовать от него
    {
        public Specialization specialty;
        public event ExamDelegate examEvent; 
        public Teacher() : base()
        {
            specialty = Specialization.undefined;
        }
        public Teacher(string name, string surname, string patron,
                            DateTime birth, Gender gen, Nationality nat, EducationLevel edlevel,
                            float mani, int ages, Specialization specialty):
            base(name, surname, patron, birth, gen, nat, edlevel, mani, ages)
        {
            this.specialty = specialty;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\tTeacher specialization: {specialty}; ";
        }
        public void Exam(string task) //exam trigger
        {
            if(examEvent != null)
            {
                examEvent(task);
            }
        }
    }
}
