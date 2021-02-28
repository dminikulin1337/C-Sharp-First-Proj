using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            try//testing class objects here
            {
                Random random = new Random();
                List_of_workers listOfWorkers = new List_of_workers();
                for (int i = 0; i < 7; i++)
                {
                    listOfWorkers.AddWorker(new Worker("Worker_" + i, "tested", "tested",
                        DateTime.Now, Gender.Other, Nationality.Stateless, EducationLevel.None, random.Next(20000, 25000), random.Next(1, 5), false, "testing"));
                }
                //default sorting - for int or string
                Array.Sort(listOfWorkers.Workers);
                foreach (Worker worker in listOfWorkers.Workers)
                {
                    //Console.WriteLine(worker);
                }
                IWorker[] tmp = listOfWorkers.Workers;
                Array.Sort(tmp, new WorkerAgeOfWorkAscComparer());
                foreach (Worker worker in tmp)
                {
                    Console.WriteLine(worker);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is an error: ");
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
}
