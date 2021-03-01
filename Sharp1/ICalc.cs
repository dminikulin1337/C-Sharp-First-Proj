using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface ICalc<T>
    {
        T add(T a, T b);
        T subtract(T a, T b);
        T multiply(T a, T b);
        T divide(T a, T b);
    }
}
