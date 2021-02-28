using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    sealed class Teacher : Employee //запечатаный класс - запрещает насследовать от него
    {
        public Specialization specialty;
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
    }
}
