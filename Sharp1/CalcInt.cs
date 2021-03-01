using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class CalcInt : ICalc<CalcInt>
    {
        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public CalcInt(int num)
        {
            Number = num;
        }
        public CalcInt add(CalcInt a)
        {
            return new CalcInt(this.Number += a.Number);
        }
        public CalcInt add(CalcInt a, CalcInt b)
        {
            return new CalcInt(a.Number + b.Number);
        }

        public CalcInt divide(CalcInt a)
        {
            if (a.Number == 0) throw new DivideByZeroException();
            return new CalcInt(this.Number /= a.Number);
        }
        public CalcInt divide(CalcInt a, CalcInt b)
        {
            if (b.Number == 0) throw new DivideByZeroException();
            return new CalcInt(a.Number / b.Number);
        }

        public CalcInt multiply(CalcInt a)
        {
            return new CalcInt(this.Number *= a.Number);
        }
        public CalcInt multiply(CalcInt a, CalcInt b)
        {
            return new CalcInt(a.Number * b.Number);
        }

        public CalcInt subtract(CalcInt a)
        {
            return new CalcInt(this.Number - a.Number);
        }
        public CalcInt subtract(CalcInt a, CalcInt b)
        {
            return new CalcInt(a.Number -= b.Number);
        }
        public override string ToString()
        {
            return $"Number: {Number};";
        }
    }
}
