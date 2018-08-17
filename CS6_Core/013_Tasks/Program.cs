using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace _013_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            // WriteLine("Running methods synchronously on one thread.");
            // MethodA();
            // MethodB();
            // MethodC();
            WriteLine("Running methods asynchronously on multiple threads.");
            var taskA = new Task(MethodA);
            taskA.Start();
            var taskB = Task.Factory.StartNew(MethodB);
            var taskC = Task.Run(new Action(MethodC));
            Task[] tasks = { taskA, taskB, taskC };
            Task.WaitAll(tasks);
 
            WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
            WriteLine("Press ENTER to end.");
            ReadLine();
        }

        static void MethodA()
        {
            WriteLine("Starting Method A...");
            Thread.Sleep(3000); // simulate three seconds of work
            WriteLine("Finished Method A.");
        }
        static void MethodB()
        {
            WriteLine("Starting Method B...");
            Thread.Sleep(2000); // simulate two seconds of work
            WriteLine("Finished Method B.");
        }
        static void MethodC()
        {
            WriteLine("Starting Method C...");
            Thread.Sleep(1000); // simulate one second of work
            WriteLine("Finished Method C.");
        }
    }
}
