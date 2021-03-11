using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum CloneWorkerMethod
    {
        Superficial,
        Complete
    }
    //inherited from Employee class
    class Worker : Employee, IWorker, ICloneable, IComparable
    {
        private bool _isWorking;
        private string _workDescription;
        public bool isWorking
        {
            get { return _isWorking; }
        } //interface variable

        public string Work() //interface method
        {
            return _workDescription;
        }
        public string CurrentWork
        {
            get { return _workDescription; }
        }
        public void StopWorking()
        {
            _isWorking = false;
        }
        public void NewTask(string task)
        {
            if (_isWorking == false)
            {
                if (task.Length > 0)
                {
                    _workDescription = task;
                    _isWorking = true;
                }
                else
                {
                    throw new InvalidOperationException("Worker didn't understand the task.");
                }
            }
            else
            {
                throw new Exception("Worker still at work.");
            }
        }
        public Worker() : base()
        {
            _isWorking = true;
            _workDescription = "Organizing workspace";
        }
        public Worker(string name, string surname, string patron,
                            DateTime birth, Gender gen, Nationality nat, EducationLevel edlevel,
                            float mani, int ages,
                            bool iswork, string description)
            : base(name, surname, patron, birth, gen, nat, edlevel, mani, ages)
        {
            _isWorking = false;
            this.NewTask(description);
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n\tWorking status: {isWorking};" +
                $"\n\tCurrent work: {_workDescription};";
        }

        public object Clone()
        {
            Console.WriteLine("Copying object...");

            return this.MemberwiseClone(); //superficial copying
        }
        public object Clone(CloneWorkerMethod method)
        {
            switch (method)
            {
                case CloneWorkerMethod.Superficial:
                    return this.Clone();
                    break;
                case CloneWorkerMethod.Complete:
                    return new Worker(this.Name, this.Surname, this.Patronimic,
                        this.BirthDate, this.gender, this.nationality, this.eduLVL,
                        this.Salary, this.Age_of_Work, this.isWorking, this.CurrentWork);
                    break;
            }
            throw new ArgumentException("Clone Worker Method failed");
        }

        public int CompareTo(object obj)
        {
            //default sorting - from smallest to greatest
            Worker worker = obj as Worker;
            if (worker != null)
            {
                return worker.Name.CompareTo(this.Name); //standard string comparer
            }
            else
            {
                throw new Exception("Can't compare values");
            }
        }
        public void ExamStart(string task)
        {
            Console.WriteLine($"Worker : { Name } got a task: {task}");
        }
        public void TakeSalary(Object sender, SalaryEventArgs args)
        {
            //Console.WriteLine(sender.ToString());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Name: {Name}");
            Console.ResetColor();
            Console.WriteLine($"Additional data: {args.Type}; Salary: {args.Salary};");
        }
        public void AcceptTask(Object sender, TaskEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name: {Name}");
            Console.ResetColor();
            Console.WriteLine($"Task description: {args.Description};\nExecutor: {args.Executor};\n");
        }
        public void FinishTask(Object e)
        {
            throw new NotImplementedException();
        }
    }
}
