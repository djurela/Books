using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Diagnostics.Process;

namespace Monitoring
{
    class Recorder
    {
        static Stopwatch timer = new Stopwatch();
        static long bytesPhisicalBefore = 0;
        static long bytesVirtualBefore = 0;

        public static void Start()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            bytesPhisicalBefore = GetCurrentProcess().WorkingSet64;
            bytesVirtualBefore = GetCurrentProcess().VirtualMemorySize64;
            timer.Restart();
        }

        public static void Stop()
        {
            timer.Stop();
            long bytesPhisicalAfter = GetCurrentProcess().WorkingSet64;
            long bytesVirtualAfter = GetCurrentProcess().VirtualMemorySize64;
            WriteLine("Stopped recording.");
            WriteLine($"{bytesPhisicalAfter - bytesPhisicalBefore} phisical bytes used");
            WriteLine($"{bytesVirtualAfter - bytesVirtualBefore} virtual bytes used");
            WriteLine($"{timer.Elapsed} time span elapsed");
            //WriteLine($"{timer.ElapsedMilliseconds} total miliseconds ellapsed.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = 10000;
            //Write("Press ENTER to start timer: ");
            //ReadLine();
            Recorder.Start();
            int[] largeArrayOfInts = Enumerable.Range(1, 10000).ToArray();
            Recorder.Stop();
            Recorder.Start();
            int[] largeArrayOfInts2 = new int[size];
            for(int i = 0; i < size; i++)
                largeArrayOfInts2[i] = size - i;
            //Write("Press ENTER to stop the timer: ");
            //ReadLine();
            Recorder.Stop();
            Recorder.Start();
            string s = "";
            for(int i = 0; i < size; i++)
                s += largeArrayOfInts2[i] + ",";
            Recorder.Stop();
            Recorder.Start();
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < size; i++)
                builder.Append(largeArrayOfInts2[i] + ",");
            Recorder.Stop();
            //Write("Press any key to continue ...");
            //ReadKey();
        }
    }
}
