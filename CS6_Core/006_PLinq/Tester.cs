using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConsoleApplication
{
    public class Tester
    {
        public void Test01()
        {
            var watch = Stopwatch.StartNew();
            Write("Pres ENTER to start.");
            ReadLine();
            watch.Start();
            IEnumerable<int> numbers = Enumerable.Range(1, 200000000);
            //var squares = numbers.Select(number => number * 2).ToArray();
            var squares = numbers.AsParallel().Select(number => number * 2).ToArray();
            watch.Stop();
            WriteLine($"{watch.ElapsedMilliseconds:#,##0} elapsed miliseconds");
        }
    }
}