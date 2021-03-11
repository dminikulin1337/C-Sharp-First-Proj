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
                List<Worker> workersList = new List<Worker>();
                int WLsize = 4;
                Random random = new Random();
                for (int i = 0; i < WLsize; i++)
                {
                    workersList.Add(new Worker("Worker_" + i, "tested", "tested",
                        DateTime.Now, Gender.Other, Nationality.Stateless, EducationLevel.None, random.Next(20000, 25000), random.Next(1, 5), false, "testing"));
                }
                /*for (int i = 0; i < workersList.Count; i++)
                {
                    Console.WriteLine(workersList[i]);
                }
                Console.WriteLine("\n<================ sorted ===================>\n");
                workersList.Sort(new WorkerSalaryAscComparerT());
                for (int i = 0; i < workersList.Count; i++)
                {
                    Console.WriteLine(workersList[i]);
                }*/
                //List<> - fulfill, print, sort, print sorting

                /*CalcInt calcInt = new CalcInt(15);
                CalcDelegate calcDelegate = new CalcDelegate(calcInt.multiply);
                //Console.WriteLine(calcDelegate(calcInt));

                calcDelegate += calcInt.divide;
                calcDelegate += calcInt.subtract;
                calcDelegate += calcInt.add;

                foreach (CalcDelegate item in calcDelegate.GetInvocationList())
                {
                    Console.WriteLine(item(calcInt));
                }

                CalcDelegate<CalcInt> calcDelegateCalcInt = new CalcDelegate<CalcInt>(calcInt.add);
                Console.WriteLine(calcDelegateCalcInt(new CalcInt(15), new CalcInt(35)));

                Teacher teacher = new Teacher();

                teacher.examEvent += workersList[0].ExamStart;
                teacher.Exam($"Write a song for a teacher");
                foreach (var item in workersList)
                {
                    teacher.examEvent += item.ExamStart;
                }
                teacher.Exam($"Give $50 for room repair works");*/

                /*BookKeeper bookKeeper = new BookKeeper();
                bookKeeper.salaryEvent += workersList[0].TakeSalary;
                bookKeeper.GiveSalary(new SalaryEventArgs { Type = "Salary", Salary = 5600f });

                foreach (var item in workersList)
                {
                    bookKeeper.salaryEvent += item.TakeSalary;
                }
                Console.WriteLine("Employees got their money");
                bookKeeper.GiveSalary(new SalaryEventArgs { Type = "Avance", Salary = (float)Math.Floor(random.NextDouble() * 1000) });*/

                Worker unknown = new Worker();
                Console.WriteLine(unknown);
                Manager manager = new Manager();
                manager.TaskList += unknown.AcceptTask;
                manager.GiveTask(new TaskEventArgs { Description = "Посчитать деньги для зарплаты твоих колег; протрезвить бухгалтера", 
                    Executor = unknown.Surname + " " + unknown.Name });
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
