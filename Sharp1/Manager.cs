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

        public EventHandler<TaskEventArgs> TaskList;

        public void GiveTask(TaskEventArgs args)
        {
            if (TaskList != null)
            {
                TaskList(this, args);
            }
        }

        public void AcceptFinish(TaskEventArgs args)
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

        public void ControlWork()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
    }
}
