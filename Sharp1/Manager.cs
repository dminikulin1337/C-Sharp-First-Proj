using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager : Employee, IManager
    {
        private List_of_workers _workers;//worker list in current object
        public List_of_workers Workers { get { return _workers; } } //getting access to manager employees

        public List_of_workers GetWorker(int index)
        {
            throw new NotImplementedException();
        }
        public List_of_workers GetWorker(string workDescription)
        {
            throw new NotImplementedException();
        }
        
        public void ControlWork()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }

        public Manager() : base()
        {
            _workers = new List_of_workers();
        }
        public Manager(string name, string surname, string patron,
                            DateTime birth, Gender gen, Nationality nat, EducationLevel edlevel,
                            float mani, int ages, List_of_workers zelist)
            : base(name, surname, patron, birth, gen, nat, edlevel, mani, ages)
        {
            _workers = zelist;
        }
        public override string ToString()
        {
            return base.ToString() + 
                $"\n\tWorkers under control: {Workers.Count}";
        }
    }
}
