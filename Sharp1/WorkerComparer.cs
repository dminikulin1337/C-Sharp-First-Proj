using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class WorkerNameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)x).Name.CompareTo(((Worker)y).Name);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerNameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Name.CompareTo(((Worker)x).Name);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSurnameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)x).Surname.CompareTo(((Worker)y).Surname);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSurnameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Surname.CompareTo(((Worker)x).Surname);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerPatronimicAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)x).Patronimic.CompareTo(((Worker)y).Patronimic);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerPatronimicDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Patronimic.CompareTo(((Worker)x).Patronimic);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerBirthDateAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)x).BirthDate.CompareTo(((Worker)y).BirthDate);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerBirthDateDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).BirthDate.CompareTo(((Worker)x).BirthDate);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSalaryAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)x).Salary.CompareTo(((Worker)y).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSalaryDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Salary.CompareTo(((Worker)x).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerAgeOfWorkAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)x).Age_of_Work.CompareTo(((Worker)y).Age_of_Work);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerAgeOfWorkDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Age_of_Work.CompareTo(((Worker)x).Age_of_Work);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
