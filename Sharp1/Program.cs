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
                //Random random = new Random();
                //List_of_workers listOfWorkers = new List_of_workers();
                //for (int i = 0; i < 7; i++)
                //{
                //    listOfWorkers.AddWorker(new Worker("Worker_" + i, "tested", "tested",
                //        DateTime.Now, Gender.Other, Nationality.Stateless, EducationLevel.None, random.Next(20000, 25000), random.Next(1, 5), false, "testing"));
                //}
                ////default sorting - for int or string
                //Array.Sort(listOfWorkers.Workers);
                //foreach (Worker worker in listOfWorkers.Workers)
                //{
                //    //Console.WriteLine(worker);
                //}
                //IWorker[] tmp = listOfWorkers.Workers;
                //Array.Sort(tmp, new WorkerAgeOfWorkAscComparer());
                //foreach (Worker worker in tmp)
                //{
                //    Console.WriteLine(worker);
                //}

                /*object ob = 45; //boxing
                int number = (int)ob; //unboxing

                Point3D<int> point = new Point3D<int>(20, 40, 20);
                Console.WriteLine(point);
                Point3D<decimal> pointY = new Point3D<decimal>(0.02m, 0.04m, 0.04m);
                Console.WriteLine(pointY);

                Random random = new Random();

                Point3D<int>[] dots = new Point3D<int>[5];
                for (int i = 0; i < dots.Length; i++)
                {
                    dots[i] = new Point3D<int>(random.Next(0, 10), random.Next(0, 10), random.Next(0, 10));
                    Console.WriteLine(dots[i]);
                }

                MyTwoParameters<Guid, Worker> myTwoParameters = new MyTwoParameters<Guid, Worker>();
                myTwoParameters.Key = Guid.NewGuid();
                myTwoParameters.Value = new Worker("Katie", "Picasso", "Juan", DateTime.Now, Gender.Female, Nationality.Stateless, EducationLevel.High, 2000f, 1, false, "unknown");
                Console.WriteLine(myTwoParameters);

                MyTwoParameters<Guid, Worker>[] anArray = new MyTwoParameters<Guid, Worker>[5];
                for (int i = 0; i < anArray.Length; i++)
                {
                    anArray[i] = new MyTwoParameters<Guid, Worker>();
                    anArray[i].Key = Guid.NewGuid();
                    anArray[i].Value = new Worker("Worker_" + i, "Surname", "Patronimic", DateTime.Now, Gender.Other, Nationality.Stateless, EducationLevel.None, 2000f, 0, false, "unknown");
                    Console.WriteLine(anArray[i]);
                }

                CalcInt calcInt = new CalcInt(15);
                calcInt = calcInt.divide(new CalcInt(5));
                Console.WriteLine(calcInt);*/

                //ArrayList employers = new ArrayList();
                //employers.Add(new Teacher());
                //employers.Add(new Worker());
                //employers.Add(new Manager());
                //employers.Add(new Director());

                //Console.WriteLine(employers.Count); //num of elements in list
                //Console.WriteLine(employers.Capacity); //разрядность

                //foreach (var item in employers)
                //{
                //    if (item is Teacher)
                //    {
                //        Console.WriteLine(((Teacher)item));
                //    }
                //    if (item is Worker)
                //    {
                //        Console.WriteLine(((Worker)item));
                //    }
                //    if (item is Manager)
                //    {
                //        Console.WriteLine(((Manager)item));
                //    }
                //    if (item is Director)
                //    {
                //        Console.WriteLine(((Director)item));
                //    }
                //}
                List<Worker> workersList = new List<Worker>();
                int WLsize = 4;
                Random random = new Random();
                for (int i = 0; i < WLsize; i++)
                {
                    workersList.Add(new Worker("Worker_" + i, "tested", "tested",
                        DateTime.Now, Gender.Other, Nationality.Stateless, EducationLevel.None, random.Next(20000, 25000), random.Next(1, 5), false, "testing"));
                }
                for (int i = 0; i < workersList.Count; i++)
                {
                    Console.WriteLine(workersList[i]);
                }
                Console.WriteLine("\n<================ sorted ===================>\n");
                workersList.Sort(new WorkerSalaryAscComparerT());
                for (int i = 0; i < workersList.Count; i++)
                {
                    Console.WriteLine(workersList[i]);
                }
                //List<> - fulfill, print, sort, print sorting
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
