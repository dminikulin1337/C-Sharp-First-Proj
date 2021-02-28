using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface IWorker
    {
        string Work(); //worker must work - Logik
        bool isWorking { get; } //work state - works or not
    }
}
