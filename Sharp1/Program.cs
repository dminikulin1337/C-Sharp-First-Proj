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
            //Human human = new Human();
            //Console.WriteLine(human);
            //Console.WriteLine(human.gender);
            //Console.WriteLine(human.nationality);
            //Console.WriteLine(human.Name); //variable: read
            //human.Name = "Миша";           //variable: write
            //Console.WriteLine(human.Name);
            //Console.WriteLine(human.getName());

            try//testing class objects here
            {
                Random random = new Random();
                List_of_workers listOfWorkers = new List_of_workers();
                for (int i = 0; i < 7; i++)
                {
                    listOfWorkers.AddWorker(new Worker("Worker_" + i, "tested", "tested",
                        DateTime.Now, Gender.Other, Nationality.Stateless, EducationLevel.None, random.Next(20000, 25000), random.Next(1, 5), false, "testing"));
                }
                /*
                //listOfWorkers.ShowAllWorkers(listOfWorkers);
                //listOfWorkers.ShowSingleWorker(listOfWorkers, 4);
                Manager realManager = new Manager("Изя", "Давидыч", "Мясников",
                    DateTime.Now, Gender.Male, Nationality.Hebrew, EducationLevel.Secondary, 150000, 12, listOfWorkers);
                //Console.WriteLine(realManager);

                List_of_managers eliteList = new List_of_managers();
                for (int i = 0; i < eliteList.Managers.Length; i++)
                {
                    eliteList.AddManager(new Manager("Manager_"+i, "testing", "testing", 
                        DateTime.Now, Gender.Other, Nationality.Stateless, EducationLevel.None,
                        0, 0, listOfWorkers) );
                }
                //Console.WriteLine(eliteList);
                //eliteList.ShowSingleManager(eliteList, 1);
                //eliteList.RemoveManager(eliteList.Managers[1]);
                //eliteList.ShowSingleManager(eliteList, 1); //Managers remains, but there is one less in a list - manager here was second, but became first => Logik
                //eliteList.searchManager(eliteList.Managers[1]); //This works as same as ShowSingleManager(), but it's more complicated

                Company company = new Company("Ceramic pros", "Изготовление посуды", listOfWorkers, eliteList, new Director());
                Console.WriteLine(company); //check info here while debugging only
                Console.WriteLine();
                Director newDirector = new Director("Алексей", "Степаненко", "Альбертович",
                    new DateTime(1971, 4, 11), Gender.Male, Nationality.Ukrainian, EducationLevel.High,
                    250000, 20, company);
                company.ChangeDirector(newDirector);
                Console.WriteLine(company); //check info here while debugging only
                */
                //Random random = new Random();
                //int[] arr = new int[25];
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    arr[i] = random.Next(0, 25);
                //    Console.Write(arr[i] + " ");
                //}
                //Console.WriteLine();
                //foreach (var intel in arr)
                //{
                //    Console.Write(intel + " ");
                //}
                //Console.WriteLine();

                //Console.WriteLine("Now via IEnumerator: ");
                //IEnumerator ieArray = arr.GetEnumerator();
                //while (ieArray.MoveNext())
                //{
                //    int item = (int)ieArray.Current;
                //    Console.Write(item + " ");
                //}
                //ieArray.Reset();
                //Console.WriteLine("It works the same!!!");
                //Console.WriteLine();

                //foreach (Worker item in listOfWorkers)
                //{
                //    Console.WriteLine(item);
                //}
                //Worker worker_1 = new Worker("Катерина", "Войтенко", "Ивановна",
                //    new DateTime(1992, 10, 17), Gender.Female, Nationality.Ukrainian, EducationLevel.Secondary,
                //    30000, 0, true, "Принимает вызова клиентов");
                //Worker worker_3 = (Worker)worker_1.Clone();
                //worker_3.Name = "Ангелина";
                //Console.WriteLine(worker_1);
                //Console.WriteLine(worker_3);
                //Worker worker_4 = (Worker)worker_3.Clone(CloneWorkerMethod.Complete);
                //worker_4.Name = "Галя";
                //Console.WriteLine(worker_3);
                //Console.WriteLine(worker_4);
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
