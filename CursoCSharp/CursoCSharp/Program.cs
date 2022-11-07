using System;
using System.Globalization;
using CursoCSharp.Entities.Enum;
using CursoCSharp.Entities;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();

            //Console.Write("Enter worker date: ");

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter level (Junior, Midlevel or Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Enter base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Worker many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n ; i++)
            {
                Console.WriteLine($"Enter #{1} contract date: ");

                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
            }




        }
    }
}

