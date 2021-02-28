using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface IManager
    {
        void ControlWork();
        void Organize();

        List_of_workers Workers { get; } //give a posibility to have an access to Employees
        
    }
}
